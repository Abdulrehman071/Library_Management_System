using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;

namespace LibraryMS.App.Forms
{
    public partial class ReturnBookForm : Form
    {
        private readonly IBorrowService _borrowSvc;
        private readonly Borrow         _borrow;

        public ReturnBookForm(IBorrowService borrowSvc, Borrow borrow)
        {
            _borrowSvc = borrowSvc;
            _borrow    = borrow;
            InitializeComponent();
            Load += ReturnBookForm_Load;
        }

        private void ReturnBookForm_Load(object? sender, EventArgs e)
        {
            lblBorrowId.Text   = "Borrow ID: " + _borrow.Id;
            lblBookVal.Text    = _borrow.BookTitle;
            lblMemberVal.Text  = _borrow.MemberName;
            lblIssuedVal.Text  = _borrow.IssueDate.ToString("dd-MMM-yyyy");
            lblDueVal.Text     = _borrow.DueDate.ToString("dd-MMM-yyyy");
            dtpReturnDate.Value = DateTime.Today;

            // Highlight overdue in red
            if (DateTime.Today > _borrow.DueDate)
            {
                lblDueVal.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
                lblOverdue.Visible  = true;
                int days = (DateTime.Today - _borrow.DueDate).Days;
                lblOverdue.Text = $"OVERDUE by {days} day(s)";
            }
        }

        private void btnReturn_Click(object? sender, EventArgs e)
        {
            try
            {
                _borrowSvc.ReturnBook(_borrow.Id, dtpReturnDate.Value);
                MessageBox.Show(
                    $"Book returned successfully!\n\nBook: {_borrow.BookTitle}\nMember: {_borrow.MemberName}\nReturn Date: {dtpReturnDate.Value:dd-MMM-yyyy}",
                    "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
