using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;
using LibraryMS.Core.Utilities;

namespace LibraryMS.App.Forms
{
    public partial class IssueBookForm : Form
    {
        private readonly IBorrowService  _borrowSvc;
        private readonly IBookService    _bookSvc;
        private readonly IMemberService  _memberSvc;

        private List<Book>   _books   = new();
        private List<Member> _members = new();

        public IssueBookForm(IBorrowService borrowSvc, IBookService bookSvc, IMemberService memberSvc)
        {
            _borrowSvc  = borrowSvc;
            _bookSvc    = bookSvc;
            _memberSvc  = memberSvc;
            InitializeComponent();
            Load += IssueBookForm_Load;
        }

        private void IssueBookForm_Load(object? sender, EventArgs e)
        {
            // Load available books only
            _books = _bookSvc.GetAll()
                .Where(b => b.Status == BookStatusEnum.Available)
                .OrderBy(b => b.Title)
                .ToList();

            cmbBook.Items.Clear();
            foreach (var b in _books)
                cmbBook.Items.Add($"{b.Title}  [{b.Id}]");
            if (cmbBook.Items.Count > 0) cmbBook.SelectedIndex = 0;

            // Load all members
            _members = _memberSvc.GetAll().OrderBy(m => m.Name).ToList();
            cmbMember.Items.Clear();
            foreach (var m in _members)
                cmbMember.Items.Add($"{m.Name}  [{m.Id}]");
            if (cmbMember.Items.Count > 0) cmbMember.SelectedIndex = 0;

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value   = DateTime.Today.AddDays(14);
        }

        private void btnIssue_Click(object? sender, EventArgs e)
        {
            if (cmbBook.SelectedIndex < 0)
            { MessageBox.Show("Please select a book.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cmbMember.SelectedIndex < 0)
            { MessageBox.Show("Please select a member.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (dtpDueDate.Value.Date <= dtpIssueDate.Value.Date)
            { MessageBox.Show("Due date must be after issue date.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var book   = _books[cmbBook.SelectedIndex];
                var member = _members[cmbMember.SelectedIndex];

                _borrowSvc.IssueBook(book.Id, member.Id, dtpIssueDate.Value, dtpDueDate.Value);

                MessageBox.Show(
                    $"Book issued successfully!\n\nBook: {book.Title}\nMember: {member.Name}\nDue: {dtpDueDate.Value:dd-MMM-yyyy}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Issue Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
