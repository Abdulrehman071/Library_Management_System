namespace LibraryMS.App.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlCards = new Panel();
            cardBooks = new Panel();
            lblCardBooksValue = new Label();
            lblCardBooksLabel = new Label();
            cardAvail = new Panel();
            lblCardAvailValue = new Label();
            lblCardAvailLabel = new Label();
            cardBorrowed = new Panel();
            lblCardBorrowedValue = new Label();
            lblCardBorrowedLabel = new Label();
            cardMembers = new Panel();
            lblCardMembersValue = new Label();
            lblCardMembersLabel = new Label();
            cardActive = new Panel();
            cardOverdue = new Panel();
            lblCardActiveValue = new Label();
            lblCardActiveLabel = new Label();
            lblCardOverdueValue = new Label();
            lblCardOverdueLabel = new Label();
            pnlSepH = new Panel();
            lblRecentTitle = new Label();
            dgvRecent = new DataGridView();
            colRTitle = new DataGridViewTextBoxColumn();
            colRAuthor = new DataGridViewTextBoxColumn();
            colRStatus = new DataGridViewTextBoxColumn();
            colRCategory = new DataGridViewTextBoxColumn();
            pnlCards.SuspendLayout();
            cardBooks.SuspendLayout();
            cardAvail.SuspendLayout();
            cardBorrowed.SuspendLayout();
            cardMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // pnlCards
            // 
            pnlCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCards.Controls.Add(cardBooks);
            pnlCards.Controls.Add(cardAvail);
            pnlCards.Controls.Add(cardBorrowed);
            pnlCards.Controls.Add(cardMembers);
            pnlCards.Controls.Add(cardActive);
            pnlCards.Controls.Add(cardOverdue);
            pnlCards.Location = new Point(24, 58);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(1460, 96);
            pnlCards.TabIndex = 1;
            // 
            // cardBooks
            // 
            cardBooks.BackColor = Color.White;
            cardBooks.BorderStyle = BorderStyle.FixedSingle;
            cardBooks.Controls.Add(lblCardBooksValue);
            cardBooks.Controls.Add(lblCardBooksLabel);
            cardBooks.Location = new Point(0, 0);
            cardBooks.Name = "cardBooks";
            cardBooks.Size = new Size(200, 94);
            cardBooks.TabIndex = 0;
            // 
            // lblCardBooksValue
            // 
            lblCardBooksValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCardBooksValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCardBooksValue.Location = new Point(14, 10);
            lblCardBooksValue.Name = "lblCardBooksValue";
            lblCardBooksValue.Size = new Size(168, 54);
            lblCardBooksValue.TabIndex = 0;
            lblCardBooksValue.Text = "0";
            // 
            // lblCardBooksLabel
            // 
            lblCardBooksLabel.AutoSize = true;
            lblCardBooksLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardBooksLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardBooksLabel.Location = new Point(14, 64);
            lblCardBooksLabel.Name = "lblCardBooksLabel";
            lblCardBooksLabel.Size = new Size(88, 21);
            lblCardBooksLabel.TabIndex = 1;
            lblCardBooksLabel.Text = "Total Books";
            // 
            // cardAvail
            // 
            cardAvail.BackColor = Color.White;
            cardAvail.BorderStyle = BorderStyle.FixedSingle;
            cardAvail.Controls.Add(lblCardAvailValue);
            cardAvail.Controls.Add(lblCardAvailLabel);
            cardAvail.Location = new Point(210, 0);
            cardAvail.Name = "cardAvail";
            cardAvail.Size = new Size(200, 94);
            cardAvail.TabIndex = 1;
            // 
            // lblCardAvailValue
            // 
            lblCardAvailValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCardAvailValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCardAvailValue.Location = new Point(14, 10);
            lblCardAvailValue.Name = "lblCardAvailValue";
            lblCardAvailValue.Size = new Size(168, 54);
            lblCardAvailValue.TabIndex = 0;
            lblCardAvailValue.Text = "0";
            // 
            // lblCardAvailLabel
            // 
            lblCardAvailLabel.AutoSize = true;
            lblCardAvailLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardAvailLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardAvailLabel.Location = new Point(14, 64);
            lblCardAvailLabel.Name = "lblCardAvailLabel";
            lblCardAvailLabel.Size = new Size(73, 21);
            lblCardAvailLabel.TabIndex = 1;
            lblCardAvailLabel.Text = "Available";
            // 
            // cardBorrowed
            // 
            cardBorrowed.BackColor = Color.White;
            cardBorrowed.BorderStyle = BorderStyle.FixedSingle;
            cardBorrowed.Controls.Add(lblCardBorrowedValue);
            cardBorrowed.Controls.Add(lblCardBorrowedLabel);
            cardBorrowed.Location = new Point(420, 0);
            cardBorrowed.Name = "cardBorrowed";
            cardBorrowed.Size = new Size(200, 94);
            cardBorrowed.TabIndex = 2;
            // 
            // lblCardBorrowedValue
            // 
            lblCardBorrowedValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCardBorrowedValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCardBorrowedValue.Location = new Point(14, 10);
            lblCardBorrowedValue.Name = "lblCardBorrowedValue";
            lblCardBorrowedValue.Size = new Size(168, 54);
            lblCardBorrowedValue.TabIndex = 0;
            lblCardBorrowedValue.Text = "0";
            // 
            // lblCardBorrowedLabel
            // 
            lblCardBorrowedLabel.AutoSize = true;
            lblCardBorrowedLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardBorrowedLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardBorrowedLabel.Location = new Point(14, 64);
            lblCardBorrowedLabel.Name = "lblCardBorrowedLabel";
            lblCardBorrowedLabel.Size = new Size(78, 21);
            lblCardBorrowedLabel.TabIndex = 1;
            lblCardBorrowedLabel.Text = "Borrowed";
            // 
            // cardMembers
            // 
            cardMembers.BackColor = Color.White;
            cardMembers.BorderStyle = BorderStyle.FixedSingle;
            cardMembers.Controls.Add(lblCardMembersValue);
            cardMembers.Controls.Add(lblCardMembersLabel);
            cardMembers.Location = new Point(630, 0);
            cardMembers.Name = "cardMembers";
            cardMembers.Size = new Size(200, 94);
            cardMembers.TabIndex = 3;
            // 
            // lblCardMembersValue
            // 
            lblCardMembersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCardMembersValue.ForeColor = Color.FromArgb(30, 30, 30);
            lblCardMembersValue.Location = new Point(14, 10);
            lblCardMembersValue.Name = "lblCardMembersValue";
            lblCardMembersValue.Size = new Size(168, 54);
            lblCardMembersValue.TabIndex = 0;
            lblCardMembersValue.Text = "0";
            // 
            // lblCardMembersLabel
            // 
            lblCardMembersLabel.AutoSize = true;
            lblCardMembersLabel.Font = new Font("Segoe UI", 9.5F);
            lblCardMembersLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblCardMembersLabel.Location = new Point(14, 64);
            lblCardMembersLabel.Name = "lblCardMembersLabel";
            lblCardMembersLabel.Size = new Size(76, 21);
            lblCardMembersLabel.TabIndex = 1;
            lblCardMembersLabel.Text = "Members";
            // 
            // cardActive
            // 
            cardActive.Location = new Point(0, 0);
            cardActive.Name = "cardActive";
            cardActive.Size = new Size(200, 100);
            cardActive.TabIndex = 4;
            // 
            // cardOverdue
            // 
            cardOverdue.Location = new Point(0, 0);
            cardOverdue.Name = "cardOverdue";
            cardOverdue.Size = new Size(200, 100);
            cardOverdue.TabIndex = 5;
            // 
            // lblCardActiveValue
            // 
            lblCardActiveValue.Location = new Point(0, 0);
            lblCardActiveValue.Name = "lblCardActiveValue";
            lblCardActiveValue.Size = new Size(100, 23);
            lblCardActiveValue.TabIndex = 0;
            // 
            // lblCardActiveLabel
            // 
            lblCardActiveLabel.Location = new Point(0, 0);
            lblCardActiveLabel.Name = "lblCardActiveLabel";
            lblCardActiveLabel.Size = new Size(100, 23);
            lblCardActiveLabel.TabIndex = 0;
            // 
            // lblCardOverdueValue
            // 
            lblCardOverdueValue.Location = new Point(0, 0);
            lblCardOverdueValue.Name = "lblCardOverdueValue";
            lblCardOverdueValue.Size = new Size(100, 23);
            lblCardOverdueValue.TabIndex = 0;
            // 
            // lblCardOverdueLabel
            // 
            lblCardOverdueLabel.Location = new Point(0, 0);
            lblCardOverdueLabel.Name = "lblCardOverdueLabel";
            lblCardOverdueLabel.Size = new Size(100, 23);
            lblCardOverdueLabel.TabIndex = 0;
            // 
            // pnlSepH
            // 
            pnlSepH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSepH.BackColor = Color.FromArgb(210, 210, 215);
            pnlSepH.Location = new Point(24, 166);
            pnlSepH.Name = "pnlSepH";
            pnlSepH.Size = new Size(1366, 1);
            pnlSepH.TabIndex = 2;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblRecentTitle.Location = new Point(24, 176);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(94, 25);
            lblRecentTitle.TabIndex = 3;
            lblRecentTitle.Text = "Book List";
            // 
            // dgvRecent
            // 
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.ColumnHeadersHeight = 34;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecent.Columns.AddRange(new DataGridViewColumn[] { colRTitle, colRAuthor, colRStatus, colRCategory });
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.Font = new Font("Segoe UI", 9.5F);
            dgvRecent.GridColor = Color.FromArgb(225, 225, 228);
            dgvRecent.Location = new Point(0, 206);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.RowTemplate.Height = 30;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(1506, 588);
            dgvRecent.TabIndex = 4;
            // 
            // colRTitle
            // 
            colRTitle.HeaderText = "Title";
            colRTitle.MinimumWidth = 6;
            colRTitle.Name = "colRTitle";
            colRTitle.ReadOnly = true;
            // 
            // colRAuthor
            // 
            colRAuthor.HeaderText = "Author";
            colRAuthor.MinimumWidth = 6;
            colRAuthor.Name = "colRAuthor";
            colRAuthor.ReadOnly = true;
            // 
            // colRStatus
            // 
            colRStatus.HeaderText = "Status";
            colRStatus.MinimumWidth = 6;
            colRStatus.Name = "colRStatus";
            colRStatus.ReadOnly = true;
            // 
            // colRCategory
            // 
            colRCategory.HeaderText = "Category";
            colRCategory.MinimumWidth = 6;
            colRCategory.Name = "colRCategory";
            colRCategory.ReadOnly = true;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(pnlCards);
            Controls.Add(pnlSepH);
            Controls.Add(lblRecentTitle);
            Controls.Add(dgvRecent);
            Font = new Font("Segoe UI", 9.5F);
            Name = "DashboardView";
            Size = new Size(1506, 794);
            Load += DashboardView_Load;
            pnlCards.ResumeLayout(false);
            cardBooks.ResumeLayout(false);
            cardBooks.PerformLayout();
            cardAvail.ResumeLayout(false);
            cardAvail.PerformLayout();
            cardBorrowed.ResumeLayout(false);
            cardBorrowed.PerformLayout();
            cardMembers.ResumeLayout(false);
            cardMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label   lblTitle;
        private System.Windows.Forms.Label   lblRecentTitle;
        private System.Windows.Forms.Panel   pnlCards;
        private System.Windows.Forms.Panel   pnlSepH;
        private System.Windows.Forms.Panel   cardBooks;
        private System.Windows.Forms.Panel   cardAvail;
        private System.Windows.Forms.Panel   cardBorrowed;
        private System.Windows.Forms.Panel   cardMembers;
        private System.Windows.Forms.Label   lblCardBooksValue;
        private System.Windows.Forms.Label   lblCardBooksLabel;
        private System.Windows.Forms.Label   lblCardAvailValue;
        private System.Windows.Forms.Label   lblCardAvailLabel;
        private System.Windows.Forms.Label   lblCardBorrowedValue;
        private System.Windows.Forms.Label   lblCardBorrowedLabel;
        private System.Windows.Forms.Label   lblCardMembersValue;
        private System.Windows.Forms.Panel   cardActive;
        private System.Windows.Forms.Label   lblCardActiveValue;
        private System.Windows.Forms.Label   lblCardActiveLabel;
        private System.Windows.Forms.Panel   cardOverdue;
        private System.Windows.Forms.Label   lblCardOverdueValue;
        private System.Windows.Forms.Label   lblCardOverdueLabel;
        private System.Windows.Forms.Label   lblCardMembersLabel;
        private System.Windows.Forms.DataGridView              dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRCategory;
    }
}
