using LibraryMS.App.Forms;
using LibraryMS.Core.Contracts;

namespace LibraryMS.App.Views
{
    public partial class MemberView : UserControl
    {
        private IMemberService? _svc;

        public MemberView()
        {
            InitializeComponent();
            ApplyGridStyle();
        }

        public MemberView(IMemberService svc) : this()
        {
            _svc = svc;
        }

        private void MemberView_Load(object? sender, EventArgs e)
        {
            if (_svc == null) return;
            LoadGrid();
        }

        private void LoadGrid(string search = "")
        {
            if (_svc == null) return;
            try
            {
                var members = string.IsNullOrWhiteSpace(search) ? _svc.GetAll() : _svc.Search(search);
                dgvMembers.Rows.Clear();
                foreach (var m in members)
                    dgvMembers.Rows.Add(m.Id, m.Name, m.Phone, m.Email, m.Address);
            }
            catch (Exception ex)
            { MessageBox.Show("Error loading members: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbSearch_Click(object? sender, EventArgs e) => LoadGrid(txtSearch.Text.Trim());

        private void tsbRefresh_Click(object? sender, EventArgs e) { txtSearch.Clear(); LoadGrid(); }

        private void tsbAdd_Click(object? sender, EventArgs e)
        {
            if (_svc == null) return;
            using var f = new MemberForm(MemberFormMode.Add, null, _svc);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbEdit_Click(object? sender, EventArgs e)
        {
            if (_svc == null || dgvMembers.CurrentRow == null) return;
            var m = _svc.GetById(dgvMembers.CurrentRow.Cells["colId"].Value?.ToString() ?? "");
            if (m == null) return;
            using var f = new MemberForm(MemberFormMode.Edit, m, _svc);
            if (f.ShowDialog() == DialogResult.OK) LoadGrid();
        }

        private void tsbDelete_Click(object? sender, EventArgs e)
        {
            if (_svc == null || dgvMembers.CurrentRow == null) return;
            string id   = dgvMembers.CurrentRow.Cells["colId"].Value?.ToString()   ?? "";
            string name = dgvMembers.CurrentRow.Cells["colName"].Value?.ToString() ?? "";
            if (MessageBox.Show($"Delete \"{name}\"?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try { _svc.Delete(id); LoadGrid(); }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvMembers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) tsbEdit_Click(sender, EventArgs.Empty);
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) tsbSearch_Click(sender, EventArgs.Empty); }

        private void ApplyGridStyle()
        {
            dgvMembers.DefaultCellStyle.SelectionBackColor           = SystemColors.Highlight;
            dgvMembers.DefaultCellStyle.SelectionForeColor           = SystemColors.HighlightText;
            dgvMembers.DefaultCellStyle.BackColor                    = Color.White;
            dgvMembers.DefaultCellStyle.ForeColor                    = Color.FromArgb(30, 30, 30);
            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor     = Color.FromArgb(247, 247, 250);
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(244, 244, 246);
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(30, 30, 30);
            dgvMembers.ColumnHeadersDefaultCellStyle.Font               = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvMembers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 244, 246);
            dgvMembers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
        }
    }
}
