namespace LibraryMS.App.Views
{
    partial class MemberView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            lblTitle = new Label();
            toolStrip = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbSep1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvMembers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Members";
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(244, 244, 246);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsbSep1, tsbRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Padding = new Padding(4, 0, 4, 0);
            toolStrip.Size = new Size(1506, 28);
            toolStrip.TabIndex = 1;
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Font = new Font("Segoe UI", 9.5F);
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(42, 25);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Font = new Font("Segoe UI", 9.5F);
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(40, 25);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbView.Font = new Font("Segoe UI", 9.5F);
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(48, 25);
            tsbView.Text = "View";
            tsbView.Click += tsbEdit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Font = new Font("Segoe UI", 9.5F);
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(58, 25);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
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
            pnlFilter.Location = new Point(0, 78);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1506, 56);
            pnlFilter.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F);
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(8, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(8, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name, phone, email...";
            txtSearch.Size = new Size(220, 29);
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
            btnSearch.Location = new Point(236, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += tsbSearch_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.ColumnHeadersHeight = 34;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress });
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Font = new Font("Segoe UI", 9.5F);
            dgvMembers.GridColor = Color.FromArgb(225, 225, 228);
            dgvMembers.Location = new Point(0, 134);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 30;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1506, 560);
            dgvMembers.TabIndex = 4;
            dgvMembers.CellDoubleClick += dgvMembers_CellDoubleClick;
            // 
            // colId
            // 
            colId.FillWeight = 10F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 25F;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.FillWeight = 18F;
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.FillWeight = 27F;
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.FillWeight = 20F;
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // MemberView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(toolStrip);
            Controls.Add(pnlFilter);
            Controls.Add(dgvMembers);
            Font = new Font("Segoe UI", 9.5F);
            Name = "MemberView";
            Size = new Size(1506, 705);
            Load += MemberView_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label                    lblTitle;
        private System.Windows.Forms.ToolStrip                toolStrip;
        private System.Windows.Forms.ToolStripButton          tsbAdd;
        private System.Windows.Forms.ToolStripButton          tsbEdit;
        private System.Windows.Forms.ToolStripButton          tsbView;
        private System.Windows.Forms.ToolStripButton          tsbDelete;
        private System.Windows.Forms.ToolStripSeparator       tsbSep1;
        private System.Windows.Forms.ToolStripButton          tsbRefresh;
        private System.Windows.Forms.Panel                    pnlFilter;
        private System.Windows.Forms.Label                    lblSearch;
        private System.Windows.Forms.TextBox                  txtSearch;
        private System.Windows.Forms.Button                   btnSearch;
        private System.Windows.Forms.DataGridView              dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}
