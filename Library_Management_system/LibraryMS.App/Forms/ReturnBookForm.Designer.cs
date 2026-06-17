namespace LibraryMS.App.Forms
{
    partial class ReturnBookForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components    = new System.ComponentModel.Container();
            this.lblTitle      = new System.Windows.Forms.Label();
            this.lblBorrowId   = new System.Windows.Forms.Label();
            this.lblBook       = new System.Windows.Forms.Label();
            this.lblBookVal    = new System.Windows.Forms.Label();
            this.lblMember     = new System.Windows.Forms.Label();
            this.lblMemberVal  = new System.Windows.Forms.Label();
            this.lblIssued     = new System.Windows.Forms.Label();
            this.lblIssuedVal  = new System.Windows.Forms.Label();
            this.lblDue        = new System.Windows.Forms.Label();
            this.lblDueVal     = new System.Windows.Forms.Label();
            this.lblOverdue    = new System.Windows.Forms.Label();
            this.pnlSep        = new System.Windows.Forms.Panel();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons    = new System.Windows.Forms.Panel();
            this.btnReturn     = new System.Windows.Forms.Button();
            this.btnCancel     = new System.Windows.Forms.Button();

            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTitle.Location  = new System.Drawing.Point(24, 20);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Return Book";

            // lblBorrowId
            this.lblBorrowId.AutoSize  = true;
            this.lblBorrowId.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBorrowId.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblBorrowId.Location  = new System.Drawing.Point(26, 54);
            this.lblBorrowId.Name      = "lblBorrowId";
            this.lblBorrowId.TabIndex  = 1;
            this.lblBorrowId.Text      = "Borrow ID:";

            // lblBook (caption)
            this.lblBook.AutoSize  = true;
            this.lblBook.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBook.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblBook.Location  = new System.Drawing.Point(24, 86);
            this.lblBook.Name      = "lblBook";
            this.lblBook.TabIndex  = 2;
            this.lblBook.Text      = "Book";

            // lblBookVal
            this.lblBookVal.AutoSize  = true;
            this.lblBookVal.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblBookVal.Location  = new System.Drawing.Point(24, 106);
            this.lblBookVal.Name      = "lblBookVal";
            this.lblBookVal.Size      = new System.Drawing.Size(420, 20);
            this.lblBookVal.TabIndex  = 3;
            this.lblBookVal.Text      = "—";

            // lblMember (caption)
            this.lblMember.AutoSize  = true;
            this.lblMember.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblMember.Location  = new System.Drawing.Point(24, 136);
            this.lblMember.Name      = "lblMember";
            this.lblMember.TabIndex  = 4;
            this.lblMember.Text      = "Member";

            // lblMemberVal
            this.lblMemberVal.AutoSize  = true;
            this.lblMemberVal.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMemberVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblMemberVal.Location  = new System.Drawing.Point(24, 156);
            this.lblMemberVal.Name      = "lblMemberVal";
            this.lblMemberVal.TabIndex  = 5;
            this.lblMemberVal.Text      = "—";

            // lblIssued (caption)
            this.lblIssued.AutoSize  = true;
            this.lblIssued.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIssued.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblIssued.Location  = new System.Drawing.Point(24, 186);
            this.lblIssued.Name      = "lblIssued";
            this.lblIssued.TabIndex  = 6;
            this.lblIssued.Text      = "Issue Date";

            // lblIssuedVal
            this.lblIssuedVal.AutoSize  = true;
            this.lblIssuedVal.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIssuedVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblIssuedVal.Location  = new System.Drawing.Point(24, 206);
            this.lblIssuedVal.Name      = "lblIssuedVal";
            this.lblIssuedVal.TabIndex  = 7;
            this.lblIssuedVal.Text      = "—";

            // lblDue (caption)
            this.lblDue.AutoSize  = true;
            this.lblDue.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDue.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblDue.Location  = new System.Drawing.Point(220, 186);
            this.lblDue.Name      = "lblDue";
            this.lblDue.TabIndex  = 8;
            this.lblDue.Text      = "Due Date";

            // lblDueVal
            this.lblDueVal.AutoSize  = true;
            this.lblDueVal.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDueVal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblDueVal.Location  = new System.Drawing.Point(220, 206);
            this.lblDueVal.Name      = "lblDueVal";
            this.lblDueVal.TabIndex  = 9;
            this.lblDueVal.Text      = "—";

            // lblOverdue (hidden by default, shown if overdue)
            this.lblOverdue.AutoSize  = true;
            this.lblOverdue.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOverdue.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
            this.lblOverdue.Location  = new System.Drawing.Point(350, 206);
            this.lblOverdue.Name      = "lblOverdue";
            this.lblOverdue.TabIndex  = 10;
            this.lblOverdue.Text      = "OVERDUE";
            this.lblOverdue.Visible   = false;

            // pnlSep
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(210, 210, 215);
            this.pnlSep.Location  = new System.Drawing.Point(24, 234);
            this.pnlSep.Name      = "pnlSep";
            this.pnlSep.Size      = new System.Drawing.Size(420, 1);
            this.pnlSep.TabIndex  = 11;

            // lblReturnDate
            this.lblReturnDate.AutoSize  = true;
            this.lblReturnDate.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblReturnDate.Location  = new System.Drawing.Point(24, 246);
            this.lblReturnDate.Name      = "lblReturnDate";
            this.lblReturnDate.TabIndex  = 12;
            this.lblReturnDate.Text      = "Return Date";

            // dtpReturnDate
            this.dtpReturnDate.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpReturnDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(24, 266);
            this.dtpReturnDate.Name     = "dtpReturnDate";
            this.dtpReturnDate.Size     = new System.Drawing.Size(190, 25);
            this.dtpReturnDate.TabIndex = 13;

            // pnlButtons
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.pnlButtons.Controls.Add(this.btnReturn);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location  = new System.Drawing.Point(0, 312);
            this.pnlButtons.Name      = "pnlButtons";
            this.pnlButtons.Size      = new System.Drawing.Size(468, 52);
            this.pnlButtons.TabIndex  = 14;

            // btnReturn
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location  = new System.Drawing.Point(248, 10);
            this.btnReturn.Name      = "btnReturn";
            this.btnReturn.Size      = new System.Drawing.Size(100, 32);
            this.btnReturn.TabIndex  = 0;
            this.btnReturn.Text      = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click    += new System.EventHandler(this.btnReturn_Click);

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

            // ReturnBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(468, 364);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBorrowId);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblBookVal);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblMemberVal);
            this.Controls.Add(this.lblIssued);
            this.Controls.Add(this.lblIssuedVal);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblDueVal);
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.pnlButtons);
            this.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "ReturnBookForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Return Book";
            this.Load           += new System.EventHandler(this.ReturnBookForm_Load);

            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Label           lblBorrowId;
        private System.Windows.Forms.Label           lblBook;
        private System.Windows.Forms.Label           lblBookVal;
        private System.Windows.Forms.Label           lblMember;
        private System.Windows.Forms.Label           lblMemberVal;
        private System.Windows.Forms.Label           lblIssued;
        private System.Windows.Forms.Label           lblIssuedVal;
        private System.Windows.Forms.Label           lblDue;
        private System.Windows.Forms.Label           lblDueVal;
        private System.Windows.Forms.Label           lblOverdue;
        private System.Windows.Forms.Panel           pnlSep;
        private System.Windows.Forms.Label           lblReturnDate;
        private System.Windows.Forms.DateTimePicker  dtpReturnDate;
        private System.Windows.Forms.Panel           pnlButtons;
        private System.Windows.Forms.Button          btnReturn;
        private System.Windows.Forms.Button          btnCancel;
    }
}
