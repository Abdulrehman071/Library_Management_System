using LibraryMS.App.Forms;
using LibraryMS.Core.Contracts;
using LibraryMS.Core.Utilities;

namespace LibraryMS.App.Views
{
    public partial class BookView : UserControl
    {
        private IBookService? _svc;

        public BookView()
        {
            InitializeComponent();
            ApplyGridStyle();
        }

        public BookView(IBookService svc) : this()
        {
            _svc = svc;
        }

        private void BookView_Load(object? sender, EventArgs e)
        {
            if (_svc == null) return;

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            foreach (var c in Enum.GetValues<BookCategoryEnum>())
                cmbCategory.Items.Add(c.ToString());
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("--ALL--");
            foreach (var s in Enum.GetValues<BookStatusEnum>())
                cmbStatus.Items.Add(s.ToString());
            cmbStatus.SelectedIndex = 0;

            LoadGrid();
        }

        private void LoadGrid(string search = "", BookCategoryEnum? cat = null, BookStatusEnum? status = null)
        {
            if (_svc == null) return;
            try
            {
                var books = (string.IsNullOrWhiteSpace(search) && cat == null && status == null)
                    ? _svc.GetAll()
                    : _svc.Search(search, cat, status);

                dgvBooks.Rows.Clear();
                foreach (var b in books)
                    dgvBooks.Rows.Add(b.Id, b.Title, b.Author, b.ISBN,
                                      b.Category, b.Status, b.Copies, b.Year);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSearch_Click(object? sender, EventArgs e)
        {
            BookCategoryEnum? cat = cmbCategory.SelectedIndex > 0 && cmbCategory.SelectedItem != null
                ? Enum.Parse<BookCategoryEnum>(cmbCategory.SelectedItem.ToString()!) : null;
            BookStatusEnum? st = cmbStatus.SelectedIndex > 0 && cmbStatus.SelectedItem != null
                ? Enum.Parse<BookStatusEnum>(cmbStatus.SelectedItem.ToString()!) : null;
            LoadGrid(txtSearch.Text.Trim(), cat, st);
        }

        private void tsbRefresh_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0)   cmbStatus.SelectedIndex   = 0;
            LoadGrid();
        }

        private void tsbAdd_Click(object? sender, EventArgs e)
        {
            if (_svc == null) return;
            using var f = new BookForm(BookFormMode.Add, null, _svc);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbEdit_Click(object? sender, EventArgs e)
        {
            if (_svc == null || dgvBooks.CurrentRow == null) return;
            var book = _svc.GetById(dgvBooks.CurrentRow.Cells["colId"].Value?.ToString() ?? "");
            if (book == null) return;
            using var f = new BookForm(BookFormMode.Edit, book, _svc);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbDelete_Click(object? sender, EventArgs e)
        {
            if (_svc == null || dgvBooks.CurrentRow == null) return;
            string id    = dgvBooks.CurrentRow.Cells["colId"].Value?.ToString()    ?? "";
            string title = dgvBooks.CurrentRow.Cells["colTitle"].Value?.ToString() ?? "";
            if (MessageBox.Show($"Delete \"{title}\"?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try { _svc.Delete(id); LoadGrid(); }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvBooks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) tsbEdit_Click(sender, EventArgs.Empty);
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) tsbSearch_Click(sender, EventArgs.Empty); }

        private void ApplyGridStyle()
        {
            dgvBooks.DefaultCellStyle.SelectionBackColor           = SystemColors.Highlight;
            dgvBooks.DefaultCellStyle.SelectionForeColor           = SystemColors.HighlightText;
            dgvBooks.DefaultCellStyle.BackColor                    = Color.White;
            dgvBooks.DefaultCellStyle.ForeColor                    = Color.FromArgb(30, 30, 30);
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor     = Color.FromArgb(247, 247, 250);
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(244, 244, 246);
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(30, 30, 30);
            dgvBooks.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 244, 246);
            dgvBooks.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
        }
    }
}
