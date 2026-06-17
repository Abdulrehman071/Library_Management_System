namespace LibraryMS.App.Forms
{
    partial class MainForm
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
            this.panelSidebar  = new System.Windows.Forms.Panel();
            this.lblAppTitle   = new System.Windows.Forms.Label();
            this.btnDashboard  = new System.Windows.Forms.Button();
            this.btnBooks      = new System.Windows.Forms.Button();
            this.btnMembers    = new System.Windows.Forms.Button();
            this.panelSep      = new System.Windows.Forms.Panel();
            this.panelContent  = new System.Windows.Forms.Panel();
            this.btnBorrows    = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.panelSidebar.Controls.Add(this.btnBorrows);
            this.panelSidebar.Controls.Add(this.btnMembers);
            this.panelSidebar.Controls.Add(this.btnBooks);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblAppTitle);
            this.panelSidebar.Dock     = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Name     = "panelSidebar";
            this.panelSidebar.Width    = 210;
            this.panelSidebar.TabIndex = 0;

            // lblAppTitle
            this.lblAppTitle.BackColor  = System.Drawing.Color.FromArgb(244, 244, 246);
            this.lblAppTitle.Font       = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor  = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblAppTitle.Location   = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name       = "lblAppTitle";
            this.lblAppTitle.Padding    = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblAppTitle.Size       = new System.Drawing.Size(210, 56);
            this.lblAppTitle.TabIndex   = 0;
            this.lblAppTitle.Text       = "  LibraryMS";
            this.lblAppTitle.TextAlign  = System.Drawing.ContentAlignment.MiddleLeft;

            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnDashboard.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnDashboard.Location  = new System.Drawing.Point(0, 58);
            this.btnDashboard.Name      = "btnDashboard";
            this.btnDashboard.Padding   = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnDashboard.Size      = new System.Drawing.Size(210, 48);
            this.btnDashboard.TabIndex  = 1;
            this.btnDashboard.TabStop   = false;
            this.btnDashboard.Text      = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click    += new System.EventHandler(this.btnDashboard_Click);

            // btnBooks
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnBooks.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnBooks.Location  = new System.Drawing.Point(0, 108);
            this.btnBooks.Name      = "btnBooks";
            this.btnBooks.Padding   = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnBooks.Size      = new System.Drawing.Size(210, 48);
            this.btnBooks.TabIndex  = 2;
            this.btnBooks.TabStop   = false;
            this.btnBooks.Text      = "Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click    += new System.EventHandler(this.btnBooks_Click);

            // btnMembers
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnMembers.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnMembers.Location  = new System.Drawing.Point(0, 158);
            this.btnMembers.Name      = "btnMembers";
            this.btnMembers.Padding   = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnMembers.Size      = new System.Drawing.Size(210, 48);
            this.btnMembers.TabIndex  = 3;
            this.btnMembers.TabStop   = false;
            this.btnMembers.Text      = "Members";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = false;
            
            this.btnMembers.Click    += new System.EventHandler(this.btnMembers_Click);

            // btnBorrows
            this.btnBorrows.BackColor = System.Drawing.Color.FromArgb(244, 244, 246);
            this.btnBorrows.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBorrows.FlatAppearance.BorderSize = 0;
            this.btnBorrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrows.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBorrows.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnBorrows.Location  = new System.Drawing.Point(0, 208);
            this.btnBorrows.Name      = "btnBorrows";
            this.btnBorrows.Padding   = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnBorrows.Size      = new System.Drawing.Size(210, 48);
            this.btnBorrows.TabIndex  = 4;
            this.btnBorrows.TabStop   = false;
            this.btnBorrows.Text      = "Borrows";
            this.btnBorrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrows.UseVisualStyleBackColor = false;
            this.btnBorrows.Click    += new System.EventHandler(this.btnBorrows_Click);


            // panelSep
            this.panelSep.BackColor = System.Drawing.Color.FromArgb(210, 210, 215);
            this.panelSep.Dock      = System.Windows.Forms.DockStyle.Left;
            this.panelSep.Name      = "panelSep";
            this.panelSep.TabIndex  = 1;
            this.panelSep.Width     = 1;

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name      = "panelContent";
            this.panelContent.TabIndex  = 2;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSep);
            this.Controls.Add(this.panelSidebar);
            this.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize   = new System.Drawing.Size(860, 560);
            this.Name          = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Library Management System";
            this.WindowState   = System.Windows.Forms.FormWindowState.Maximized;
            this.Load         += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel  panelSidebar;
        private System.Windows.Forms.Panel  panelSep;
        private System.Windows.Forms.Panel  panelContent;
        private System.Windows.Forms.Label  lblAppTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBorrows;
    }
}
