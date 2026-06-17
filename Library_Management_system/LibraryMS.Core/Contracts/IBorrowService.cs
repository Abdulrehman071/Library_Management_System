using LibraryMS.Core.Models;

namespace LibraryMS.Core.Contracts
{
    public interface IBorrowService
    {
        string?        EnsureDatabaseReady();
        Borrow?        IssueBook(string bookId, string memberId, DateTime issueDate, DateTime dueDate);
        bool           ReturnBook(string borrowId, DateTime returnDate);
        List<Borrow>   GetAll();
        List<Borrow>   GetActive();
        List<Borrow>   GetOverdue();
        List<Borrow>   Search(string text, string status);
        Borrow?        GetById(string id);
        int            GetActiveBorrowCount();
        int            GetOverdueBorrowCount();
    }
}
