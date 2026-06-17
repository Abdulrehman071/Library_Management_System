using LibraryMS.Core.Models;

namespace LibraryMS.Core.Contracts
{
    public interface IMemberService
    {
        List<Member>  GetAll();
        Member?       GetById(string id);
        void          Add(Member member);
        void          Update(Member member);
        void          Delete(string id);
        List<Member>  Search(string query);
        string?       EnsureDatabaseReady();
    }
}
