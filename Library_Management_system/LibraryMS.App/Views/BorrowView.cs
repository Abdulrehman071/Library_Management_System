using LibraryMS.App.Forms;
using LibraryMS.Core.Contracts;

namespace LibraryMS.App.Views
{
    public partial class BorrowView : UserControl
    {
        private IBorrowService?  _borrowSvc;
        private IBookService?    _bookSvc;
        private IMemberService?  _memberSvc;

        public BorrowView()
        {
            InitializeComponent();
            ApplyGridStyle();
        }

        public BorrowView(IBorrowService borrowSvc, IBookService bookSvc, IMemberService memberSvc) : this()
        {
            _borrowSvc = borrowSvc;
            _bookSvc   = bookSvc;
            _memberSvc = memberSvc;
        }

        private void BorrowView_Load(object? sender, EventArgs e)
        {
            if (_borrowSvc == null) return;
            cmbStatus.SelectedIndex = 0;
            LoadGrid();
        }

        private void LoadGrid(string search = "", string status = "--ALL--")
        {
            if (_borrowSvc == null) return;
            try
            {
                var records = (string.IsNullOrWhiteSpace(search) && (status == "--ALL--" || string.IsNullOrWhiteSpace(status)))
                    ? _borrowSvc.GetAll()
                    : _borrowSvc.Search(search, status);

                dgvBorrows.Rows.Clear();
                foreach (var b in records)
                {
                    int idx = dgvBorrows.Rows.Add(
                        b.Id,
                        b.BookTitle,
                        b.MemberName,
                        b.IssueDate.ToString("dd-MMM-yyyy"),
                        b.DueDate.ToString("dd-MMM-yyyy"),
                        b.ReturnDate.HasValue ? b.ReturnDate.Value.ToString("dd-MMM-yyyy") : "—",
                        b.Status
                    );

                    // Highlight overdue rows
                    if (b.Status == "Active" && b.DueDate < DateTime.Today)
                    {
                        dgvBorrows.Rows[idx].DefaultCellStyle.ForeColor    = System.Drawing.Color.FromArgb(160, 0, 0);
                        dgvBorrows.Rows[idx].DefaultCellStyle.Font         = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
                        dgvBorrows.Rows[idx].Cells["colBStatus"].Value     = "Overdue";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrows: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbIssue_Click(object? sender, EventArgs e)
        {
            if (_borrowSvc == null || _bookSvc == null || _memberSvc == null) return;
            using var f = new IssueBookForm(_borrowSvc, _bookSvc, _memberSvc);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbReturn_Click(object? sender, EventArgs e)
        {
            if (_borrowSvc == null || dgvBorrows.CurrentRow == null) return;

            string id     = dgvBorrows.CurrentRow.Cells["colBId"].Value?.ToString()     ?? "";
            string status = dgvBorrows.CurrentRow.Cells["colBStatus"].Value?.ToString() ?? "";

            if (status == "Returned")
            {
                MessageBox.Show("This book has already been returned.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var borrow = _borrowSvc.GetById(id);
            if (borrow == null) return;

            using var f = new ReturnBookForm(_borrowSvc, borrow);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            LoadGrid();
        }

        private void tsbSearch_Click(object? sender, EventArgs e)
        {
            string status = cmbStatus.SelectedIndex > 0
                ? cmbStatus.SelectedItem?.ToString() ?? "--ALL--"
                : "--ALL--";
            LoadGrid(txtSearch.Text.Trim(), status);
        }

        private void dgvBorrows_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) tsbReturn_Click(sender, EventArgs.Empty);
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tsbSearch_Click(sender, EventArgs.Empty);
        }

        private void ApplyGridStyle()
        {
            dgvBorrows.DefaultCellStyle.SelectionBackColor              = SystemColors.Highlight;
            dgvBorrows.DefaultCellStyle.SelectionForeColor              = SystemColors.HighlightText;
            dgvBorrows.DefaultCellStyle.BackColor                       = System.Drawing.Color.White;
            dgvBorrows.DefaultCellStyle.ForeColor                       = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvBorrows.AlternatingRowsDefaultCellStyle.BackColor        = System.Drawing.Color.FromArgb(247, 247, 250);
            dgvBorrows.ColumnHeadersDefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvBorrows.ColumnHeadersDefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvBorrows.ColumnHeadersDefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            dgvBorrows.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            dgvBorrows.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }
    }
}
