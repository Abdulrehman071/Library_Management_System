namespace LibraryMS.App.Forms
{
    partial class BookForm
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
            this.lblTitleF    = new System.Windows.Forms.Label();
            this.txtTitle     = new System.Windows.Forms.TextBox();
            this.lblAuthor    = new System.Windows.Forms.Label();
            this.txtAuthor    = new System.Windows.Forms.TextBox();
            this.lblISBN      = new System.Windows.Forms.Label();
            this.txtISBN      = new System.Windows.Forms.TextBox();
            this.lblCategory  = new System.Windows.Forms.Label();
            this.cmbCategory  = new System.Windows.Forms.ComboBox();
            this.lblStatus    = new System.Windows.Forms.Label();
            this.cmbStatus    = new System.Windows.Forms.ComboBox();
            this.lblCopies    = new System.Windows.Forms.Label();
            this.numCopies    = new System.Windows.Forms.NumericUpDown();
            this.lblYear      = new System.Windows.Forms.Label();
            this.numYear      = new System.Windows.Forms.NumericUpDown();
            this.pnlButtons   = new System.Windows.Forms.Panel();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // lblFormTitle
            this.lblFormTitle.AutoSize  = true;
            this.lblFormTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblFormTitle.Location  = new System.Drawing.Point(24, 20);
            this.lblFormTitle.Name      = "lblFormTitle";
            this.lblFormTitle.TabIndex  = 0;
            this.lblFormTitle.Text      = "Add Book";

            // lblId
            this.lblId.AutoSize  = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblId.Location  = new System.Drawing.Point(26, 55);
            this.lblId.Name      = "lblId";
            this.lblId.TabIndex  = 1;
            this.lblId.Text      = "ID: (auto)";

            // lblTitleF
            this.lblTitleF.AutoSize  = true;
            this.lblTitleF.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTitleF.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblTitleF.Location  = new System.Drawing.Point(26, 80);
            this.lblTitleF.Name      = "lblTitleF";
            this.lblTitleF.TabIndex  = 2;
            this.lblTitleF.Text      = "Title *";

            // txtTitle
            this.txtTitle.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTitle.Location        = new System.Drawing.Point(26, 100);
            this.txtTitle.Name            = "txtTitle";
            this.txtTitle.PlaceholderText = "e.g. The Great Gatsby";
            this.txtTitle.Size            = new System.Drawing.Size(380, 25);
            this.txtTitle.TabIndex        = 3;

            // lblAuthor
            this.lblAuthor.AutoSize  = true;
            this.lblAuthor.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAuthor.Location  = new System.Drawing.Point(26, 140);
            this.lblAuthor.Name      = "lblAuthor";
            this.lblAuthor.TabIndex  = 4;
            this.lblAuthor.Text      = "Author *";

            // txtAuthor
            this.txtAuthor.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAuthor.Location        = new System.Drawing.Point(26, 160);
            this.txtAuthor.Name            = "txtAuthor";
            this.txtAuthor.PlaceholderText = "e.g. F. Scott Fitzgerald";
            this.txtAuthor.Size            = new System.Drawing.Size(380, 25);
            this.txtAuthor.TabIndex        = 5;

            // lblISBN
            this.lblISBN.AutoSize  = true;
            this.lblISBN.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblISBN.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblISBN.Location  = new System.Drawing.Point(26, 200);
            this.lblISBN.Name      = "lblISBN";
            this.lblISBN.TabIndex  = 6;
            this.lblISBN.Text      = "ISBN";

            // txtISBN
            this.txtISBN.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtISBN.Location        = new System.Drawing.Point(26, 220);
            this.txtISBN.Name            = "txtISBN";
            this.txtISBN.PlaceholderText = "e.g. 978-0-7432-7356-5";
            this.txtISBN.Size            = new System.Drawing.Size(380, 25);
            this.txtISBN.TabIndex        = 7;

            // lblCategory
            this.lblCategory.AutoSize  = true;
            this.lblCategory.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCategory.Location  = new System.Drawing.Point(26, 260);
            this.lblCategory.Name      = "lblCategory";
            this.lblCategory.TabIndex  = 8;
            this.lblCategory.Text      = "Category";

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategory.Location      = new System.Drawing.Point(26, 280);
            this.cmbCategory.Name          = "cmbCategory";
            this.cmbCategory.Size          = new System.Drawing.Size(380, 25);
            this.cmbCategory.TabIndex      = 9;

            // lblStatus
            this.lblStatus.AutoSize  = true;
            this.lblStatus.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblStatus.Location  = new System.Drawing.Point(26, 320);
            this.lblStatus.Name      = "lblStatus";
            this.lblStatus.TabIndex  = 10;
            this.lblStatus.Text      = "Status";

            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.Location      = new System.Drawing.Point(26, 340);
            this.cmbStatus.Name          = "cmbStatus";
            this.cmbStatus.Size          = new System.Drawing.Size(380, 25);
            this.cmbStatus.TabIndex      = 11;

            // lblCopies
            this.lblCopies.AutoSize  = true;
            this.lblCopies.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCopies.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCopies.Location  = new System.Drawing.Point(26, 380);
            this.lblCopies.Name      = "lblCopies";
            this.lblCopies.TabIndex  = 12;
            this.lblCopies.Text      = "Copies";

            // numCopies
            this.numCopies.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numCopies.Location = new System.Drawing.Point(26, 398);
            this.numCopies.Maximum  = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numCopies.Minimum  = new decimal(new int[] { 0, 0, 0, 0 });
            this.numCopies.Name     = "numCopies";
            this.numCopies.Size     = new System.Drawing.Size(100, 25);
            this.numCopies.TabIndex = 13;

            // lblYear
            this.lblYear.AutoSize  = true;
            this.lblYear.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblYear.Location  = new System.Drawing.Point(160, 380);
            this.lblYear.Name      = "lblYear";
            this.lblYear.TabIndex  = 14;
            this.lblYear.Text      = "Year";

            // numYear
            this.numYear.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numYear.Location = new System.Drawing.Point(160, 398);
            this.numYear.Maximum  = new decimal(new int[] { 2100, 0, 0, 0 });
            this.numYear.Minimum  = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numYear.Name     = "numYear";
            this.numYear.Size     = new System.Drawing.Size(100, 25);
            this.numYear.TabIndex = 15;
            this.numYear.Value    = new decimal(new int[] { 2024, 0, 0, 0 });

            // pnlButtons
            this.pnlButtons.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location  = new System.Drawing.Point(0, 440);
            this.pnlButtons.Name      = "pnlButtons";
            this.pnlButtons.Size      = new System.Drawing.Size(440, 52);
            this.pnlButtons.TabIndex  = 16;

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

            // BookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(440, 492);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitleF);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.pnlButtons);
            this.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "BookForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label          lblFormTitle;
        private System.Windows.Forms.Label          lblId;
        private System.Windows.Forms.Label          lblTitleF;
        private System.Windows.Forms.TextBox        txtTitle;
        private System.Windows.Forms.Label          lblAuthor;
        private System.Windows.Forms.TextBox        txtAuthor;
        private System.Windows.Forms.Label          lblISBN;
        private System.Windows.Forms.TextBox        txtISBN;
        private System.Windows.Forms.Label          lblCategory;
        private System.Windows.Forms.ComboBox       cmbCategory;
        private System.Windows.Forms.Label          lblStatus;
        private System.Windows.Forms.ComboBox       cmbStatus;
        private System.Windows.Forms.Label          lblCopies;
        private System.Windows.Forms.NumericUpDown  numCopies;
        private System.Windows.Forms.Label          lblYear;
        private System.Windows.Forms.NumericUpDown  numYear;
        private System.Windows.Forms.Panel          pnlButtons;
        private System.Windows.Forms.Button         btnSave;
        private System.Windows.Forms.Button         btnCancel;
    }
}
