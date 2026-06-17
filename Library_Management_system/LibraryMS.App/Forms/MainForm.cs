using LibraryMS.Core.Contracts;
using LibraryMS.Core.Services;
using LibraryMS.App.Views;
using System.Configuration;

namespace LibraryMS.App.Forms
{
    public partial class MainForm : Form
    {
        private IBookService?   _bookService;
        private IMemberService? _memberService;
        private IBorrowService? _borrowService;
        private Button?         _activeNav;

        private static readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);
        private static readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private static readonly Color NavActiveText = Color.White;
        private static readonly Color NavNormalText = Color.FromArgb(30, 30, 30);

        public MainForm()
        {
            InitializeComponent();

            string? connStr = ConfigurationManager.ConnectionStrings["LibraryDB"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connStr))
            {
                MessageBox.Show("Connection string 'LibraryDB' is missing in App.config.",
                    "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load += (_, _) => Close();
                return;
            }

            // Book service
            var bookSvc = new DbBookService(connStr);
            string? bookErr = bookSvc.EnsureDatabaseReady();
            if (bookErr != null)
            {
                MessageBox.Show("Database error:\n\n" + bookErr + "\n\nConnection:\n" + connStr,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load += (_, _) => Close();
                return;
            }
            _bookService = bookSvc;

            // Member service
            var memberSvc = new DbMemberService(connStr);
            string? memberErr = memberSvc.EnsureDatabaseReady();
            if (memberErr != null)
            {
                MessageBox.Show("Member table error:\n\n" + memberErr,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load += (_, _) => Close();
                return;
            }
            _memberService = memberSvc;

            // Borrow service
            var borrowSvc = new DbBorrowService(connStr);
            string? borrowErr = borrowSvc.EnsureDatabaseReady();
            if (borrowErr != null)
            {
                MessageBox.Show("Borrow table error:\n\n" + borrowErr,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Load += (_, _) => Close();
                return;
            }
            _borrowService = borrowSvc;
        }

        private void SetActiveNav(Button btn)
        {
            if (_activeNav != null)
            {
                _activeNav.BackColor = NavNormalBack;
                _activeNav.ForeColor = NavNormalText;
                _activeNav.Font      = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
            _activeNav           = btn;
            _activeNav.BackColor = NavActiveBack;
            _activeNav.ForeColor = NavActiveText;
            _activeNav.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void ShowView(UserControl view)
        {
            panelContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelContent.Controls.Add(view);
            view.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (_bookService == null || _memberService == null || _borrowService == null) return;
            SetActiveNav(btnDashboard);
            ShowView(new DashboardView(_bookService, _memberService, _borrowService));
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (_bookService == null) return;
            SetActiveNav(btnBooks);
            ShowView(new BookView(_bookService));
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (_memberService == null) return;
            SetActiveNav(btnMembers);
            ShowView(new MemberView(_memberService));
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            if (_borrowService == null || _bookService == null || _memberService == null) return;
            SetActiveNav(btnBorrows);
            ShowView(new BorrowView(_borrowService, _bookService, _memberService));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_bookService != null && _memberService != null && _borrowService != null)
                btnDashboard_Click(this, EventArgs.Empty);
        }
    }
}
