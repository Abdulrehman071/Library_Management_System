namespace LibraryMS.Core.Models
{
    public class Borrow
    {
        public string   Id         { get; set; } = string.Empty;
        public string   BookId     { get; set; } = string.Empty;
        public string   MemberId   { get; set; } = string.Empty;
        public DateTime IssueDate  { get; set; }
        public DateTime DueDate    { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string   Status     { get; set; } = "Active";   // Active | Returned | Overdue

        // Display-only (joined from Book/Member tables)
        public string BookTitle    { get; set; } = string.Empty;
        public string MemberName   { get; set; } = string.Empty;
    }
}
