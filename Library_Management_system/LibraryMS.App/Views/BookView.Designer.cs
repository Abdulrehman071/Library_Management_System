namespace LibraryMS.App.Views
{
    partial class BookView
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
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCopies = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Location = new Point(0, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Books";
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
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Controls.Add(cmbCategory);
            pnlFilter.Controls.Add(lblStatus);
            pnlFilter.Controls.Add(cmbStatus);
            pnlFilter.Controls.Add(btnSearch);
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
            txtSearch.PlaceholderText = "Title, author,...";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F);
            lblCategory.ForeColor = Color.FromArgb(60, 60, 60);
            lblCategory.Location = new Point(440, 4);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 21);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9.5F);
            cmbCategory.Location = new Point(440, 26);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 29);
            cmbCategory.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(870, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(93, 21);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Stock Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Location = new Point(870, 26);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 29);
            cmbStatus.TabIndex = 5;
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
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += tsbSearch_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeight = 34;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colAuthor, colISBN, colCategory, colStatus, colCopies, colYear });
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Font = new Font("Segoe UI", 9.5F);
            dgvBooks.GridColor = Color.FromArgb(225, 225, 228);
            dgvBooks.Location = new Point(0, 140);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 30;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1506, 560);
            dgvBooks.TabIndex = 4;
            dgvBooks.CellDoubleClick += dgvBooks_CellDoubleClick;
            // 
            // colId
            // 
            colId.FillWeight = 8F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.FillWeight = 28F;
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.FillWeight = 20F;
            colAuthor.HeaderText = "Author";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colISBN
            // 
            colISBN.FillWeight = 14F;
            colISBN.HeaderText = "ISBN";
            colISBN.MinimumWidth = 6;
            colISBN.Name = "colISBN";
            colISBN.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.FillWeight = 12F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 10F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCopies
            // 
            colCopies.FillWeight = 7F;
            colCopies.HeaderText = "Copies";
            colCopies.MinimumWidth = 6;
            colCopies.Name = "colCopies";
            colCopies.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.FillWeight = 7F;
            colYear.HeaderText = "Year";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTitle);
            Controls.Add(toolStrip);
            Controls.Add(pnlFilter);
            Controls.Add(dgvBooks);
            Font = new Font("Segoe UI", 9.5F);
            Name = "BookView";
            Size = new Size(1506, 705);
            Load += BookView_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
        private System.Windows.Forms.Label                    lblCategory;
        private System.Windows.Forms.ComboBox                 cmbCategory;
        private System.Windows.Forms.Label                    lblStatus;
        private System.Windows.Forms.ComboBox                 cmbStatus;
        private System.Windows.Forms.Button                   btnSearch;
        private System.Windows.Forms.DataGridView              dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
    }
}
