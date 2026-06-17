namespace LibraryMS.App.Forms
{
    partial class MemberForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblId        = new System.Windows.Forms.Label();
            this.lblName      = new System.Windows.Forms.Label();
            this.txtName      = new System.Windows.Forms.TextBox();
            this.lblPhone     = new System.Windows.Forms.Label();
            this.txtPhone     = new System.Windows.Forms.TextBox();
            this.lblEmail     = new System.Windows.Forms.Label();
            this.txtEmail     = new System.Windows.Forms.TextBox();
            this.lblAddress   = new System.Windows.Forms.Label();
            this.txtAddress   = new System.Windows.Forms.TextBox();
            this.pnlButtons   = new System.Windows.Forms.Panel();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // lblFormTitle
            this.lblFormTitle.AutoSize  = true;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblFormTitle.Location  = new System.Drawing.Point(24, 20);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Add Member";

            // lblId
            this.lblId.AutoSize  = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblId.Location  = new System.Drawing.Point(26, 55);
            this.lblId.Name      = "lblId";
            this.lblId.TabIndex  = 1;
            this.lblId.Text      = "ID: (auto)";

            // lblName
            this.lblName.AutoSize  = true;
            this.lblName.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblName.Location  = new System.Drawing.Point(26, 80);
            this.lblName.Name      = "lblName";
            this.lblName.TabIndex  = 2;
            this.lblName.Text      = "Full Name *";

            // txtName
            this.txtName.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.Location        = new System.Drawing.Point(26, 100);
            this.txtName.Name            = "txtName";
            this.txtName.PlaceholderText = "e.g. Ali Hassan";
            this.txtName.Size            = new System.Drawing.Size(380, 25);
            this.txtName.TabIndex        = 3;

            // lblPhone
            this.lblPhone.AutoSize  = true;
            this.lblPhone.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblPhone.Location  = new System.Drawing.Point(26, 140);
            this.lblPhone.Name      = "lblPhone";
            this.lblPhone.TabIndex  = 4;
            this.lblPhone.Text      = "Phone";

            // txtPhone
            this.txtPhone.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPhone.Location        = new System.Drawing.Point(26, 160);
            this.txtPhone.Name            = "txtPhone";
            this.txtPhone.PlaceholderText = "e.g. 0300-1234567";
            this.txtPhone.Size            = new System.Drawing.Size(380, 25);
            this.txtPhone.TabIndex        = 5;

            // lblEmail
            this.lblEmail.AutoSize  = true;
            this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblEmail.Location  = new System.Drawing.Point(26, 200);
            this.lblEmail.Name      = "lblEmail";
            this.lblEmail.TabIndex  = 6;
            this.lblEmail.Text      = "Email";

            // txtEmail
            this.txtEmail.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.Location        = new System.Drawing.Point(26, 220);
            this.txtEmail.Name            = "txtEmail";
            this.txtEmail.PlaceholderText = "e.g. ali@email.com";
            this.txtEmail.Size            = new System.Drawing.Size(380, 25);
            this.txtEmail.TabIndex        = 7;

            // lblAddress
            this.lblAddress.AutoSize  = true;
            this.lblAddress.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAddress.Location  = new System.Drawing.Point(26, 260);
            this.lblAddress.Name      = "lblAddress";
            this.lblAddress.TabIndex  = 8;
            this.lblAddress.Text      = "Address";

            // txtAddress
            this.txtAddress.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAddress.Location        = new System.Drawing.Point(26, 280);
            this.txtAddress.Name            = "txtAddress";
            this.txtAddress.PlaceholderText = "e.g. Lahore, Punjab";
            this.txtAddress.Size            = new System.Drawing.Size(380, 25);
            this.txtAddress.TabIndex        = 9;

            // pnlButtons
            this.pnlButtons.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location  = new System.Drawing.Point(0, 330);
            this.pnlButtons.Name      = "pnlButtons";
            this.pnlButtons.Size      = new System.Drawing.Size(440, 52);
            this.pnlButtons.TabIndex  = 10;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 185);
            this.btnSave.FlatAppearance.BorderSize  = 1;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnSave.Location  = new System.Drawing.Point(230, 10);
            this.btnSave.Name      = "btnSave";
            this.btnSave.Size      = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex  = 0;
            this.btnSave.Text      = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click    += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 185);
            this.btnCancel.FlatAppearance.BorderSize  = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnCancel.Location  = new System.Drawing.Point(330, 10);
            this.btnCancel.Name      = "btnCancel";
            this.btnCancel.Size      = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex  = 1;
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click    += new System.EventHandler(this.btnCancel_Click);

            // MemberForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pnlButtons);
            this.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "MemberForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Member";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblFormTitle;
        private System.Windows.Forms.Label   lblId;
        private System.Windows.Forms.Label   lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label   lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label   lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label   lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel   pnlButtons;
        private System.Windows.Forms.Button  btnSave;
        private System.Windows.Forms.Button  btnCancel;
    }
}
