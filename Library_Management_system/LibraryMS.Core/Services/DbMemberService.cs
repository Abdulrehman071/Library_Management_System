using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;
using Microsoft.Data.SqlClient;

namespace LibraryMS.Core.Services
{
    public class DbMemberService : IMemberService
    {
        private readonly string _connectionString;

        public DbMemberService(string connectionString)
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
                    IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Member')
                    BEGIN
                        CREATE TABLE Member (
                            Id      NVARCHAR(30)   NOT NULL PRIMARY KEY,
                            Name    NVARCHAR(200)  NOT NULL,
                            Phone   NVARCHAR(50)   NOT NULL DEFAULT '',
                            Email   NVARCHAR(200)  NOT NULL DEFAULT '',
                            Address NVARCHAR(500)  NOT NULL DEFAULT ''
                        )
                    END";
                using SqlCommand cmd = new(sql, conn);
                cmd.ExecuteNonQuery();
                return null;
            }
            catch (Exception ex) { return ex.Message; }
        }

        private static Member MapMember(SqlDataReader r) => new()
        {
            Id      = r["Id"]?.ToString()      ?? string.Empty,
            Name    = r["Name"]?.ToString()    ?? string.Empty,
            Phone   = r["Phone"]?.ToString()   ?? string.Empty,
            Email   = r["Email"]?.ToString()   ?? string.Empty,
            Address = r["Address"]?.ToString() ?? string.Empty
        };

        public List<Member> GetAll()
        {
            var list = new List<Member>();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("SELECT * FROM Member ORDER BY Name", conn);
                using SqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapMember(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error fetching members: " + ex.Message, ex); }
        }

        public Member? GetById(string id)
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("SELECT * FROM Member WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using SqlDataReader r = cmd.ExecuteReader();
                return r.Read() ? MapMember(r) : null;
            }
            catch (SqlException ex) { throw new Exception("DB error fetching member: " + ex.Message, ex); }
        }

        public void Add(Member member)
        {
            member.Id = "m-" + Guid.NewGuid().ToString("N")[..6].ToUpper();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"INSERT INTO Member (Id,Name,Phone,Email,Address)
                                     VALUES (@Id,@Name,@Phone,@Email,@Address)";
                using SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Id",      member.Id);
                cmd.Parameters.AddWithValue("@Name",    member.Name);
                cmd.Parameters.AddWithValue("@Phone",   member.Phone);
                cmd.Parameters.AddWithValue("@Email",   member.Email);
                cmd.Parameters.AddWithValue("@Address", member.Address);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception("DB error adding member: " + ex.Message, ex); }
        }

        public void Update(Member member)
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"UPDATE Member SET Name=@Name,Phone=@Phone,
                                     Email=@Email,Address=@Address WHERE Id=@Id";
                using SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Id",      member.Id);
                cmd.Parameters.AddWithValue("@Name",    member.Name);
                cmd.Parameters.AddWithValue("@Phone",   member.Phone);
                cmd.Parameters.AddWithValue("@Email",   member.Email);
                cmd.Parameters.AddWithValue("@Address", member.Address);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception("DB error updating member: " + ex.Message, ex); }
        }

        public void Delete(string id)
        {
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                using SqlCommand cmd = new("DELETE FROM Member WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception("DB error deleting member: " + ex.Message, ex); }
        }

        public List<Member> Search(string query)
        {
            var list = new List<Member>();
            try
            {
                using SqlConnection conn = new(_connectionString);
                conn.Open();
                const string sql = @"SELECT * FROM Member
                                     WHERE Name LIKE @Q OR Phone LIKE @Q OR Email LIKE @Q
                                     ORDER BY Name";
                using SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@Q", "%" + query + "%");
                using SqlDataReader r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapMember(r));
                return list;
            }
            catch (SqlException ex) { throw new Exception("DB error searching members: " + ex.Message, ex); }
        }
    }
}
