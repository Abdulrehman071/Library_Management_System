using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;
using LibraryMS.Core.Utilities;
using Microsoft.Data.SqlClient;

namespace LibraryMS.Core.Services
{
    public class DbBookService : IBookService
    {
        private readonly string _connectionString;

        public DbBookService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string? EnsureDatabaseReady()
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"
                    IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Book')
                    BEGIN
                        CREATE TABLE Book (
                            Id       NVARCHAR(20)   NOT NULL PRIMARY KEY,
                            Title    NVARCHAR(300)  NOT NULL,
                            Author   NVARCHAR(200)  NOT NULL,
                            ISBN     NVARCHAR(50)   NOT NULL DEFAULT '',
                            Category NVARCHAR(50)   NOT NULL,
                            Status   NVARCHAR(50)   NOT NULL,
                            Copies   INT            NOT NULL DEFAULT 1,
                            Year     INT            NOT NULL DEFAULT 0
                        )
                    END";
                using SqlCommand cmd = new(sql, conn);
                cmd.ExecuteNonQuery();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static Book MapBook(SqlDataReader r) => new()
        {
            Id       = r["Id"]?.ToString()     ?? string.Empty,
            Title    = r["Title"]?.ToString()  ?? string.Empty,
            Author   = r["Author"]?.ToString() ?? string.Empty,
            ISBN     = r["ISBN"]?.ToString()   ?? string.Empty,
            Category = Enum.TryParse<BookCategoryEnum>(r["Category"]?.ToString(), out var cat)
                           ? cat : BookCategoryEnum.Other,
            Status   = Enum.TryParse<BookStatusEnum>(r["Status"]?.ToString(), out var st)
                           ? st : BookStatusEnum.Available,
            Copies   = r["Copies"] != DBNull.Value ? Convert.ToInt32(r["Copies"]) : 1,
            Year     = r["Year"]   != DBNull.Value ? Convert.ToInt32(r["Year"])   : 0
        };

        public Book? Add(Book book)
        {
            book.Id = "b-" + Guid.NewGuid().ToString("N")[..6].ToUpper();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"INSERT INTO Book (Id,Title,Author,ISBN,Category,Status,Copies,Year)
                                     VALUES (@Id,@Title,@Author,@ISBN,@Category,@Status,@Copies,@Year)";
                using SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Id",       book.Id);
                cmd.Parameters.AddWithValue("@Title",    book.Title);
                cmd.Parameters.AddWithValue("@Author",   book.Author);
                cmd.Parameters.AddWithValue("@ISBN",     book.ISBN);
                cmd.Parameters.AddWithValue("@Category", book.Category.ToString());
                cmd.Parameters.AddWithValue("@Status",   book.Status.ToString());
                cmd.Parameters.AddWithValue("@Copies",   book.Copies);
                cmd.Parameters.AddWithValue("@Year",     book.Year);
                return cmd.ExecuteNonQuery() > 0 ? book : null;
            }
            catch (SqlException ex) { throw new Exception("DB error adding book: " + ex.Message, ex); }
        }

        public bool Update(Book book)
        {
            if (string.IsNullOrEmpty(book.Id)) return false;
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"UPDATE Book SET Title=@Title,Author=@Author,ISBN=@ISBN,
                                     Category=@Category,Status=@Status,Copies=@Copies,Year=@Year
                                     WHERE Id=@Id";
                using SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Id",       book.Id);
                cmd.Parameters.AddWithValue("@Title",    book.Title);
                cmd.Parameters.AddWithValue("@Author",   book.Author);
                cmd.Parameters.AddWithValue("@ISBN",     book.ISBN);
                cmd.Parameters.AddWithValue("@Category", book.Category.ToString());
                cmd.Parameters.AddWithValue("@Status",   book.Status.ToString());
                cmd.Parameters.AddWithValue("@Copies",   book.Copies);
                cmd.Parameters.AddWithValue("@Year",     book.Year);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex) { throw new Exception("DB error updating book: " + ex.Message, ex); }
        }

        public bool Delete(string id)
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("DELETE FROM Book WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex) { throw new Exception("DB error deleting book: " + ex.Message, ex); }
        }

        public Book? GetById(string id)
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("SELECT * FROM Book WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using SqlDataReader r = cmd.ExecuteReader();
                return r.Read() ? MapBook(r) : null;
            }
            catch (SqlException ex) { throw new Exception("DB error fetching book: " + ex.Message, ex); }
        }

        public List<Book> GetAll()
        {
            var list = new List<Book>();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("SELECT * FROM Book ORDER BY Title", conn);
                using SqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBook(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error fetching books: " + ex.Message, ex); }
        }

        public List<Book> Search(string text, BookCategoryEnum? category, BookStatusEnum? status)
        {
            var list = new List<Book>();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                string sql = "SELECT * FROM Book WHERE 1=1";
                if (!string.IsNullOrWhiteSpace(text))
                    sql += " AND (Title LIKE @Text OR Author LIKE @Text OR ISBN LIKE @Text)";
                if (category.HasValue)
                    sql += " AND Category=@Category";
                if (status.HasValue)
                    sql += " AND Status=@Status";
                sql += " ORDER BY Title";
                using SqlCommand cmd = new(sql, conn);
                if (!string.IsNullOrWhiteSpace(text))
                    cmd.Parameters.AddWithValue("@Text", "%" + text + "%");
                if (category.HasValue)
                    cmd.Parameters.AddWithValue("@Category", category.Value.ToString());
                if (status.HasValue)
                    cmd.Parameters.AddWithValue("@Status", status.Value.ToString());
                using SqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapBook(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error searching books: " + ex.Message, ex); }
        }
    }
}
