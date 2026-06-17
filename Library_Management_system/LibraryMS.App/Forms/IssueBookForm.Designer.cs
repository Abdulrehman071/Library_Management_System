namespace LibraryMS.App.Forms
{
    partial class IssueBookForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components   = new System.ComponentModel.Container();
            this.lblTitle     = new System.Windows.Forms.Label();
            this.lblBook      = new System.Windows.Forms.Label();
            this.cmbBook      = new System.Windows.Forms.ComboBox();
            this.lblMember    = new System.Windows.Forms.Label();
            this.cmbMember    = new System.Windows.Forms.ComboBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate   = new System.Windows.Forms.Label();
            this.dtpDueDate   = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons   = new System.Windows.Forms.Panel();
            this.btnIssue     = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();

            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTitle.Location  = new System.Drawing.Point(24, 20);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(130, 25);
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Issue Book";

            // lblBook
            this.lblBook.AutoSize  = true;
            this.lblBook.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBook.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblBook.Location  = new System.Drawing.Point(24, 70);
            this.lblBook.Name      = "lblBook";
            this.lblBook.Size      = new System.Drawing.Size(100, 17);
            this.lblBook.TabIndex  = 1;
            this.lblBook.Text      = "Select Book *";

            // cmbBook
            this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBook.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbBook.Location      = new System.Drawing.Point(24, 90);
            this.cmbBook.Name          = "cmbBook";
            this.cmbBook.Size          = new System.Drawing.Size(420, 25);
            this.cmbBook.TabIndex      = 2;

            // lblMember
            this.lblMember.AutoSize  = true;
            this.lblMember.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblMember.Location  = new System.Drawing.Point(24, 130);
            this.lblMember.Name      = "lblMember";
            this.lblMember.Size      = new System.Drawing.Size(110, 17);
            this.lblMember.TabIndex  = 3;
            this.lblMember.Text      = "Select Member *";

            // cmbMember
            this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbMember.Location      = new System.Drawing.Point(24, 150);
            this.cmbMember.Name          = "cmbMember";
            this.cmbMember.Size          = new System.Drawing.Size(420, 25);
            this.cmbMember.TabIndex      = 4;

            // lblIssueDate
            this.lblIssueDate.AutoSize  = true;
            this.lblIssueDate.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblIssueDate.Location  = new System.Drawing.Point(24, 192);
            this.lblIssueDate.Name      = "lblIssueDate";
            this.lblIssueDate.Size      = new System.Drawing.Size(75, 17);
            this.lblIssueDate.TabIndex  = 5;
            this.lblIssueDate.Text      = "Issue Date";

            // dtpIssueDate
            this.dtpIssueDate.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpIssueDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(24, 212);
            this.dtpIssueDate.Name     = "dtpIssueDate";
            this.dtpIssueDate.Size     = new System.Drawing.Size(190, 25);
            this.dtpIssueDate.TabIndex = 6;

            // lblDueDate
            this.lblDueDate.AutoSize  = true;
            this.lblDueDate.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblDueDate.Location  = new System.Drawing.Point(254, 192);
            this.lblDueDate.Name      = "lblDueDate";
            this.lblDueDate.Size      = new System.Drawing.Size(66, 17);
            this.lblDueDate.TabIndex  = 7;
            this.lblDueDate.Text      = "Due Date";

            // dtpDueDate
            this.dtpDueDate.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDueDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(254, 212);
            this.dtpDueDate.Name     = "dtpDueDate";
            this.dtpDueDate.Size     = new System.Drawing.Size(190, 25);
            this.dtpDueDate.TabIndex = 8;

            // pnlButtons
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.pnlButtons.Controls.Add(this.btnIssue);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location  = new System.Drawing.Point(0, 264);
            this.pnlButtons.Name      = "pnlButtons";
            this.pnlButtons.Size      = new System.Drawing.Size(468, 52);
            this.pnlButtons.TabIndex  = 9;

            // btnIssue
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location  = new System.Drawing.Point(248, 10);
            this.btnIssue.Name      = "btnIssue";
            this.btnIssue.Size      = new System.Drawing.Size(100, 32);
            this.btnIssue.TabIndex  = 0;
            this.btnIssue.Text      = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click    += new System.EventHandler(this.btnIssue_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnCancel.Location  = new System.Drawing.Point(356, 10);
            this.btnCancel.Name      = "btnCancel";
            this.btnCancel.Size      = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex  = 1;
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click    += new System.EventHandler(this.btnCancel_Click);

            // IssueBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.pnlButtons);
            this.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "IssueBookForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Issue Book";
            this.Load           += new System.EventHandler(this.IssueBookForm_Load);

            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Label           lblBook;
        private System.Windows.Forms.ComboBox        cmbBook;
        private System.Windows.Forms.Label           lblMember;
        private System.Windows.Forms.ComboBox        cmbMember;
        private System.Windows.Forms.Label           lblIssueDate;
        private System.Windows.Forms.DateTimePicker  dtpIssueDate;
        private System.Windows.Forms.Label           lblDueDate;
        private System.Windows.Forms.DateTimePicker  dtpDueDate;
        private System.Windows.Forms.Panel           pnlButtons;
        private System.Windows.Forms.Button          btnIssue;
        private System.Windows.Forms.Button          btnCancel;
    }
}
