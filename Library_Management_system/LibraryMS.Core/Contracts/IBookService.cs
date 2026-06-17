using LibraryMS.Core.Models;
using LibraryMS.Core.Utilities;

namespace LibraryMS.Core.Contracts
{
    public interface IBookService
    {
        Book?        Add(Book book);
        bool         Update(Book book);
        bool         Delete(string id);
        Book?        GetById(string id);
        List<Book>   GetAll();
        List<Book>   Search(string text, BookCategoryEnum? category, BookStatusEnum? status);
        string?      EnsureDatabaseReady();
    }
}
