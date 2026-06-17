using LibraryMS.Core.Utilities;

namespace LibraryMS.Core.Models
{
    public class Book
    {
        public string Id       { get; set; } = string.Empty;
        public string Title    { get; set; } = string.Empty;
        public string Author   { get; set; } = string.Empty;
        public string ISBN     { get; set; } = string.Empty;
        public BookCategoryEnum Category { get; set; }
        public BookStatusEnum   Status   { get; set; }
        public int    Copies   { get; set; }
        public int    Year     { get; set; }
    }
}
