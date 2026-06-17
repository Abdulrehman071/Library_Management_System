using LibraryMS.Core.Contracts;

namespace LibraryMS.App.Views
{
    public partial class DashboardView : UserControl
    {
        private IBookService?   _bookSvc;
        private IMemberService? _memberSvc;
        private IBorrowService? _borrowSvc;

        public DashboardView()
        {
            InitializeComponent();
            ApplyGridStyle();
        }

        public DashboardView(IBookService bookSvc, IMemberService memberSvc, IBorrowService borrowSvc) : this()
        {
            _bookSvc   = bookSvc;
            _memberSvc = memberSvc;
            _borrowSvc = borrowSvc;
        }

        private void DashboardView_Load(object? sender, EventArgs e)
        {
            if (_bookSvc == null || _memberSvc == null) return;
            try
            {
                var books   = _bookSvc.GetAll();
                var members = _memberSvc.GetAll();

                lblCardBooksValue.Text    = books.Count.ToString();
                lblCardAvailValue.Text    = books.Count(b => b.Status == Core.Utilities.BookStatusEnum.Available).ToString();
                lblCardBorrowedValue.Text = books.Count(b => b.Status == Core.Utilities.BookStatusEnum.Borrowed).ToString();
                lblCardMembersValue.Text  = members.Count.ToString();

                // Borrow stats
                if (_borrowSvc != null)
                {
                    lblCardActiveValue.Text  = _borrowSvc.GetActiveBorrowCount().ToString();
                    lblCardOverdueValue.Text = _borrowSvc.GetOverdueBorrowCount().ToString();
                }

                dgvRecent.Rows.Clear();
                foreach (var b in books)
                    dgvRecent.Rows.Add(b.Title, b.Author, b.Status, b.Category);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyGridStyle()
        {
            dgvRecent.DefaultCellStyle.SelectionBackColor              = SystemColors.Highlight;
            dgvRecent.DefaultCellStyle.SelectionForeColor              = SystemColors.HighlightText;
            dgvRecent.DefaultCellStyle.BackColor                       = Color.White;
            dgvRecent.DefaultCellStyle.ForeColor                       = Color.FromArgb(30, 30, 30);
            dgvRecent.AlternatingRowsDefaultCellStyle.BackColor        = Color.FromArgb(247, 247, 250);
            dgvRecent.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(244, 244, 246);
            dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(30, 30, 30);
            dgvRecent.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvRecent.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 244, 246);
            dgvRecent.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
        }
    }
}
