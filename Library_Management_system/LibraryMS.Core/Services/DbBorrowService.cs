using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;
using Microsoft.Data.SqlClient;

namespace LibraryMS.Core.Services
{
    public class DbBorrowService : IBorrowService
    {
        private readonly string _connectionString;

        public DbBorrowService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string? EnsureDatabaseReady()
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // Create Borrow table
                const string sql = @"
                    IF NOT EXISTS (
                        SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Borrow'
                    )
                    BEGIN
                        CREATE TABLE Borrow (
                            Id         NVARCHAR(30)  NOT NULL PRIMARY KEY,
                            BookId     NVARCHAR(20)  NOT NULL,
                            MemberId   NVARCHAR(30)  NOT NULL,
                            IssueDate  DATE          NOT NULL,
                            DueDate    DATE          NOT NULL,
                            ReturnDate DATE          NULL,
                            Status     NVARCHAR(20)  NOT NULL DEFAULT 'Active',
                            CONSTRAINT FK_Borrow_Book   FOREIGN KEY (BookId)   REFERENCES Book(Id),
                            CONSTRAINT FK_Borrow_Member FOREIGN KEY (MemberId) REFERENCES Member(Id)
                        )
                    END";
                using var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return null;
            }
            catch (Exception ex) { return ex.Message; }
        }

        private static Borrow MapBorrow(SqlDataReader r) => new()
        {
            Id         = r["Id"]?.ToString()         ?? string.Empty,
            BookId     = r["BookId"]?.ToString()     ?? string.Empty,
            MemberId   = r["MemberId"]?.ToString()   ?? string.Empty,
            IssueDate  = r["IssueDate"]  != DBNull.Value ? Convert.ToDateTime(r["IssueDate"])  : DateTime.Today,
            DueDate    = r["DueDate"]    != DBNull.Value ? Convert.ToDateTime(r["DueDate"])    : DateTime.Today,
            ReturnDate = r["ReturnDate"] != DBNull.Value ? Convert.ToDateTime(r["ReturnDate"]) : null,
            Status     = r["Status"]?.ToString()     ?? "Active",
            BookTitle  = r.GetOrdinal("BookTitle")  >= 0 && r["BookTitle"]  != DBNull.Value ? r["BookTitle"].ToString()!  : string.Empty,
            MemberName = r.GetOrdinal("MemberName") >= 0 && r["MemberName"] != DBNull.Value ? r["MemberName"].ToString()! : string.Empty
        };

        private static Borrow MapBorrowSafe(SqlDataReader r)
        {
            var b = new Borrow
            {
                Id         = r["Id"]?.ToString()       ?? string.Empty,
                BookId     = r["BookId"]?.ToString()   ?? string.Empty,
                MemberId   = r["MemberId"]?.ToString() ?? string.Empty,
                IssueDate  = r["IssueDate"]  != DBNull.Value ? Convert.ToDateTime(r["IssueDate"])  : DateTime.Today,
                DueDate    = r["DueDate"]    != DBNull.Value ? Convert.ToDateTime(r["DueDate"])    : DateTime.Today,
                ReturnDate = r["ReturnDate"] != DBNull.Value ? Convert.ToDateTime(r["ReturnDate"]) : null,
                Status     = r["Status"]?.ToString()   ?? "Active"
            };
            try { b.BookTitle   = r["BookTitle"]?.ToString()  ?? string.Empty; } catch { }
            try { b.MemberName  = r["MemberName"]?.ToString() ?? string.Empty; } catch { }
            return b;
        }

        private const string SelectJoin = @"
            SELECT br.Id, br.BookId, br.MemberId, br.IssueDate, br.DueDate,
                   br.ReturnDate, br.Status,
                   b.Title  AS BookTitle,
                   m.Name   AS MemberName
            FROM   Borrow br
            LEFT JOIN Book   b ON br.BookId   = b.Id
            LEFT JOIN Member m ON br.MemberId = m.Id";

        public Borrow? IssueBook(string bookId, string memberId, DateTime issueDate, DateTime dueDate)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var tran = conn.BeginTransaction();

                // Check if book is available
                using (var chk = new SqlCommand("SELECT Status FROM Book WHERE Id=@Id", conn, tran))
                {
                    chk.Parameters.AddWithValue("@Id", bookId);
                    var status = chk.ExecuteScalar()?.ToString();
                    if (status != "Available")
                        throw new Exception("Book is not available for borrowing. Current status: " + status);
                }

                string id = "br-" + Guid.NewGuid().ToString("N")[..8].ToUpper();

                // Insert borrow record
                const string ins = @"
                    INSERT INTO Borrow (Id, BookId, MemberId, IssueDate, DueDate, Status)
                    VALUES (@Id, @BookId, @MemberId, @IssueDate, @DueDate, 'Active')";
                using (var cmd = new SqlCommand(ins, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@Id",       id);
                    cmd.Parameters.AddWithValue("@BookId",   bookId);
                    cmd.Parameters.AddWithValue("@MemberId", memberId);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate.Date);
                    cmd.Parameters.AddWithValue("@DueDate",   dueDate.Date);
                    cmd.ExecuteNonQuery();
                }

                // Update book status to Borrowed
                using (var upd = new SqlCommand("UPDATE Book SET Status='Borrowed' WHERE Id=@Id", conn, tran))
                {
                    upd.Parameters.AddWithValue("@Id", bookId);
                    upd.ExecuteNonQuery();
                }

                tran.Commit();
                return GetById(id);
            }
            catch (Exception ex) { throw new Exception("Error issuing book: " + ex.Message, ex); }
        }

        public bool ReturnBook(string borrowId, DateTime returnDate)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var tran = conn.BeginTransaction();

                // Get BookId
                string bookId;
                using (var get = new SqlCommand("SELECT BookId FROM Borrow WHERE Id=@Id", conn, tran))
                {
                    get.Parameters.AddWithValue("@Id", borrowId);
                    var result = get.ExecuteScalar()?.ToString();
                    if (result == null) throw new Exception("Borrow record not found.");
                    bookId = result;
                }

                // Update borrow record
                const string updBorrow = @"
                    UPDATE Borrow
                    SET ReturnDate = @ReturnDate,
                        Status     = 'Returned'
                    WHERE Id = @Id AND Status = 'Active'";
                using (var upd = new SqlCommand(updBorrow, conn, tran))
                {
                    upd.Parameters.AddWithValue("@ReturnDate", returnDate.Date);
                    upd.Parameters.AddWithValue("@Id", borrowId);
                    if (upd.ExecuteNonQuery() == 0)
                        throw new Exception("Could not return — record may already be returned.");
                }

                // Mark book as Available
                using (var updBook = new SqlCommand("UPDATE Book SET Status='Available' WHERE Id=@Id", conn, tran))
                {
                    updBook.Parameters.AddWithValue("@Id", bookId);
                    updBook.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch (Exception ex) { throw new Exception("Error returning book: " + ex.Message, ex); }
        }

        public List<Borrow> GetAll()
        {
            var list = new List<Borrow>();
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand(SelectJoin + " ORDER BY br.IssueDate DESC", conn);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBorrowSafe(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error: " + ex.Message, ex); }
        }

        public List<Borrow> GetActive()
        {
            var list = new List<Borrow>();
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand(SelectJoin + " WHERE br.Status='Active' ORDER BY br.DueDate", conn);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBorrowSafe(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error: " + ex.Message, ex); }
        }

        public List<Borrow> GetOverdue()
        {
            var list = new List<Borrow>();
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                string sql = SelectJoin + " WHERE br.Status='Active' AND br.DueDate < @Today ORDER BY br.DueDate";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBorrowSafe(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error: " + ex.Message, ex); }
        }

        public List<Borrow> Search(string text, string status)
        {
            var list = new List<Borrow>();
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                string sql = SelectJoin + " WHERE 1=1";
                if (!string.IsNullOrWhiteSpace(text))
                    sql += " AND (b.Title LIKE @Text OR m.Name LIKE @Text OR br.Id LIKE @Text)";
                if (!string.IsNullOrWhiteSpace(status) && status != "--ALL--")
                    sql += " AND br.Status=@Status";
                sql += " ORDER BY br.IssueDate DESC";
                using var cmd = new SqlCommand(sql, conn);
                if (!string.IsNullOrWhiteSpace(text))
                    cmd.Parameters.AddWithValue("@Text", "%" + text + "%");
                if (!string.IsNullOrWhiteSpace(status) && status != "--ALL--")
                    cmd.Parameters.AddWithValue("@Status", status);
                using var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBorrowSafe(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error: " + ex.Message, ex); }
        }

        public Borrow? GetById(string id)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand(SelectJoin + " WHERE br.Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using var r = cmd.ExecuteReader();
                return r.Read() ? MapBorrowSafe(r) : null;
            }
            catch (SqlException ex) { throw new Exception("DB error: " + ex.Message, ex); }
        }

        public int GetActiveBorrowCount()
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand("SELECT COUNT(*) FROM Borrow WHERE Status='Active'", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch { return 0; }
        }

        public int GetOverdueBorrowCount()
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Borrow WHERE Status='Active' AND DueDate < @Today", conn);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch { return 0; }
        }
    }
}
