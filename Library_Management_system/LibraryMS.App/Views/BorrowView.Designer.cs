namespace LibraryMS.App.Views
{
    partial class BorrowView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            toolStrip = new ToolStrip();
            tsbIssue = new ToolStripButton();
            tsbReturn = new ToolStripButton();
            tsbSep1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            dgvBorrows = new DataGridView();
            colBId = new DataGridViewTextBoxColumn();
            colBBook = new DataGridViewTextBoxColumn();
            colBMember = new DataGridViewTextBoxColumn();
            colBIssue = new DataGridViewTextBoxColumn();
            colBDue = new DataGridViewTextBoxColumn();
            colBReturn = new DataGridViewTextBoxColumn();
            colBStatus = new DataGridViewTextBoxColumn();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Borrow Records";
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(244, 244, 246);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbIssue, tsbReturn, tsbSep1, tsbRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(4, 0, 4, 0);
            toolStrip.Size = new Size(1506, 28);
            toolStrip.TabIndex = 1;
            // 
            // tsbIssue
            // 
            tsbIssue.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbIssue.Font = new Font("Segoe UI", 9.5F);
            tsbIssue.Name = "tsbIssue";
            tsbIssue.Size = new Size(103, 25);
            tsbIssue.Text = "+ Issue Book";
            tsbIssue.ToolTipText = "Issue Book";
            tsbIssue.Click += tsbIssue_Click;
            // 
            // tsbReturn
            // 
            tsbReturn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbReturn.Font = new Font("Segoe UI", 9.5F);
            tsbReturn.Name = "tsbReturn";
            tsbReturn.Size = new Size(100, 25);
            tsbReturn.Text = "Return Book";
            tsbReturn.Click += tsbReturn_Click;
            // 
            // tsbSep1
            // 
            tsbSep1.Name = "tsbSep1";
            tsbSep1.Size = new Size(6, 28);
            // 
            // tsbRefresh
            // 
            tsbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbRefresh.Font = new Font("Segoe UI", 9.5F);
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(67, 25);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Controls.Add(lblStatus);
            pnlFilter.Controls.Add(cmbStatus);
            pnlFilter.Location = new Point(0, 78);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1506, 60);
            pnlFilter.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(8, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(8, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Book title, member name...";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(244, 244, 246);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F);
            btnSearch.ForeColor = Color.FromArgb(30, 30, 30);
            btnSearch.Location = new Point(215, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += tsbSearch_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(440, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 21);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "--ALL--", "Active", "Returned", "Overdue" });
            cmbStatus.Location = new Point(440, 26);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 29);
            cmbStatus.TabIndex = 4;
            // 
            // dgvBorrows
            // 
            dgvBorrows.AllowUserToAddRows = false;
            dgvBorrows.AllowUserToDeleteRows = false;
            dgvBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrows.BackgroundColor = Color.White;
            dgvBorrows.BorderStyle = BorderStyle.None;
            dgvBorrows.ColumnHeadersHeight = 34;
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBorrows.Columns.AddRange(new DataGridViewColumn[] { colBId, colBBook, colBMember, colBIssue, colBDue, colBReturn, colBStatus });
            dgvBorrows.EnableHeadersVisualStyles = false;
            dgvBorrows.Font = new Font("Segoe UI", 9.5F);
            dgvBorrows.GridColor = Color.FromArgb(225, 225, 228);
            dgvBorrows.Location = new Point(0, 140);
            dgvBorrows.MultiSelect = false;
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.ReadOnly = true;
            dgvBorrows.RowHeadersVisible = false;
            dgvBorrows.RowHeadersWidth = 51;
            dgvBorrows.RowTemplate.Height = 30;
            dgvBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrows.Size = new Size(1506, 560);
            dgvBorrows.TabIndex = 4;
            dgvBorrows.CellDoubleClick += dgvBorrows_CellDoubleClick;
            // 
            // colBId
            // 
            colBId.FillWeight = 10F;
            colBId.HeaderText = "Borrow ID";
            colBId.MinimumWidth = 6;
            colBId.Name = "colBId";
            colBId.ReadOnly = true;
            // 
            // colBBook
            // 
            colBBook.FillWeight = 26F;
            colBBook.HeaderText = "Book Title";
            colBBook.MinimumWidth = 6;
            colBBook.Name = "colBBook";
            colBBook.ReadOnly = true;
            // 
            // colBMember
            // 
            colBMember.FillWeight = 18F;
            colBMember.HeaderText = "Member";
            colBMember.MinimumWidth = 6;
            colBMember.Name = "colBMember";
            colBMember.ReadOnly = true;
            // 
            // colBIssue
            // 
            colBIssue.FillWeight = 13F;
            colBIssue.HeaderText = "Issue Date";
            colBIssue.MinimumWidth = 6;
            colBIssue.Name = "colBIssue";
            colBIssue.ReadOnly = true;
            // 
            // colBDue
            // 
            colBDue.FillWeight = 13F;
            colBDue.HeaderText = "Due Date";
            colBDue.MinimumWidth = 6;
            colBDue.Name = "colBDue";
            colBDue.ReadOnly = true;
            // 
            // colBReturn
            // 
            colBReturn.FillWeight = 13F;
            colBReturn.HeaderText = "Return Date";
            colBReturn.MinimumWidth = 6;
            colBReturn.Name = "colBReturn";
            colBReturn.ReadOnly = true;
            // 
            // colBStatus
            // 
            colBStatus.FillWeight = 10F;
            colBStatus.HeaderText = "Status";
            colBStatus.MinimumWidth = 6;
            colBStatus.Name = "colBStatus";
            colBStatus.ReadOnly = true;
            // 
            // BorrowView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(toolStrip);
            Controls.Add(pnlFilter);
            Controls.Add(dgvBorrows);
            Font = new Font("Segoe UI", 9.5F);
            Name = "BorrowView";
            Size = new Size(1506, 705);
            Load += BorrowView_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label                    lblTitle;
        private System.Windows.Forms.ToolStrip                toolStrip;
        private System.Windows.Forms.ToolStripButton          tsbIssue;
        private System.Windows.Forms.ToolStripButton          tsbReturn;
        private System.Windows.Forms.ToolStripSeparator       tsbSep1;
        private System.Windows.Forms.ToolStripButton          tsbRefresh;
        private System.Windows.Forms.Panel                    pnlFilter;
        private System.Windows.Forms.Label                    lblSearch;
        private System.Windows.Forms.TextBox                  txtSearch;
        private System.Windows.Forms.Button                   btnSearch;
        private System.Windows.Forms.Label                    lblStatus;
        private System.Windows.Forms.ComboBox                 cmbStatus;
        private System.Windows.Forms.DataGridView              dgvBorrows;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBStatus;
    }
}
