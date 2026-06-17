using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;
using LibraryMS.Core.Utilities;

namespace LibraryMS.App.Forms
{
    public partial class BookForm : Form
    {
        private readonly BookFormMode _mode;
        private readonly Book?        _book;
        private readonly IBookService _svc;

        public BookForm(BookFormMode mode, Book? book, IBookService svc)
        {
            _mode = mode;
            _book = book;
            _svc  = svc;
            InitializeComponent();
            Load += BookForm_Load;
        }

        private void BookForm_Load(object? sender, EventArgs e)
        {
            Text = _mode == BookFormMode.Add ? "Add Book" : "Edit Book";
            lblFormTitle.Text = Text;

            // Fill combos
            cmbCategory.Items.Clear();
            foreach (var c in Enum.GetValues<BookCategoryEnum>())
                cmbCategory.Items.Add(c.ToString());

            cmbStatus.Items.Clear();
            foreach (var s in Enum.GetValues<BookStatusEnum>())
                cmbStatus.Items.Add(s.ToString());

            if (_mode == BookFormMode.Edit && _book != null)
            {
                txtTitle.Text          = _book.Title;
                txtAuthor.Text         = _book.Author;
                txtISBN.Text           = _book.ISBN;
                cmbCategory.SelectedItem = _book.Category.ToString();
                cmbStatus.SelectedItem   = _book.Status.ToString();
                numCopies.Value          = _book.Copies;
                numYear.Value            = _book.Year;
                lblId.Text               = "ID: " + _book.Id;
            }
            else
            {
                cmbCategory.SelectedIndex = 0;
                cmbStatus.SelectedIndex   = 0;
                numCopies.Value           = 1;
                numYear.Value             = DateTime.Now.Year;
                lblId.Text                = "ID: (auto)";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            { MessageBox.Show("Title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            { MessageBox.Show("Author is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var book = new Book
                {
                    Id       = _mode == BookFormMode.Edit ? _book!.Id : "",
                    Title    = txtTitle.Text.Trim(),
                    Author   = txtAuthor.Text.Trim(),
                    ISBN     = txtISBN.Text.Trim(),
                    Category = Enum.Parse<BookCategoryEnum>(cmbCategory.SelectedItem!.ToString()!),
                    Status   = Enum.Parse<BookStatusEnum>(cmbStatus.SelectedItem!.ToString()!),
                    Copies   = (int)numCopies.Value,
                    Year     = (int)numYear.Value
                };

                if (_mode == BookFormMode.Add)
                    _svc.Add(book);
                else
                    _svc.Update(book);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
