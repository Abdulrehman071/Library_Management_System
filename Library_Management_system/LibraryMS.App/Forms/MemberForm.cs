using LibraryMS.Core.Contracts;
using LibraryMS.Core.Models;

namespace LibraryMS.App.Forms
{
    public partial class MemberForm : Form
    {
        private readonly MemberFormMode _mode;
        private readonly Member?        _member;
        private readonly IMemberService _svc;

        public MemberForm(MemberFormMode mode, Member? member, IMemberService svc)
        {
            _mode   = mode;
            _member = member;
            _svc    = svc;
            InitializeComponent();
            Load += MemberForm_Load;
        }

        private void MemberForm_Load(object? sender, EventArgs e)
        {
            Text = _mode == MemberFormMode.Add ? "Add Member" : "Edit Member";
            lblFormTitle.Text = Text;

            if (_mode == MemberFormMode.Edit && _member != null)
            {
                txtName.Text    = _member.Name;
                txtPhone.Text   = _member.Phone;
                txtEmail.Text   = _member.Email;
                txtAddress.Text = _member.Address;
                lblId.Text      = "ID: " + _member.Id;
            }
            else
            {
                lblId.Text = "ID: (auto)";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var member = new Member
                {
                    Id      = _mode == MemberFormMode.Edit ? _member!.Id : "",
                    Name    = txtName.Text.Trim(),
                    Phone   = txtPhone.Text.Trim(),
                    Email   = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                if (_mode == MemberFormMode.Add)
                    _svc.Add(member);
                else
                    _svc.Update(member);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving member: " + ex.Message, "Error",
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
