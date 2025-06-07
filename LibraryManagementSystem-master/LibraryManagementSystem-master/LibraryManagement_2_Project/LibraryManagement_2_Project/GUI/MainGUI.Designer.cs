namespace LibraryManagement_Group2_Project.GUI
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBook = new System.Windows.Forms.ToolStripButton();
            this.tsbMember = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsbReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1326, 756);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 1);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1326, 798);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBook,
            this.tsbMember,
            this.tsbBorrow,
            this.tsbReturn});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 42);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbBook
            // 
            this.tsbBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBook.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.tsbBook.ForeColor = System.Drawing.Color.Tomato;
            this.tsbBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbBook.Image")));
            this.tsbBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBook.Name = "tsbBook";
            this.tsbBook.Size = new System.Drawing.Size(78, 39);
            this.tsbBook.Text = "Book";
            this.tsbBook.Click += new System.EventHandler(this.tsbBook_Click);
            // 
            // tsbMember
            // 
            this.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMember.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.tsbMember.ForeColor = System.Drawing.Color.Tomato;
            this.tsbMember.Image = ((System.Drawing.Image)(resources.GetObject("tsbMember.Image")));
            this.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMember.Name = "tsbMember";
            this.tsbMember.Size = new System.Drawing.Size(119, 39);
            this.tsbMember.Text = "Member";
            this.tsbMember.Click += new System.EventHandler(this.tsbMember_Click);
            // 
            // tsbBorrow
            // 
            this.tsbBorrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBorrow.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.tsbBorrow.ForeColor = System.Drawing.Color.Tomato;
            this.tsbBorrow.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrow.Image")));
            this.tsbBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrow.Name = "tsbBorrow";
            this.tsbBorrow.Size = new System.Drawing.Size(106, 39);
            this.tsbBorrow.Text = "Borrow";
            this.tsbBorrow.Click += new System.EventHandler(this.tsbBorrow_Click);
            // 
            // tsbReturn
            // 
            this.tsbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReturn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.tsbReturn.ForeColor = System.Drawing.Color.Tomato;
            this.tsbReturn.Image = ((System.Drawing.Image)(resources.GetObject("tsbReturn.Image")));
            this.tsbReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReturn.Name = "tsbReturn";
            this.tsbReturn.Size = new System.Drawing.Size(99, 39);
            this.tsbReturn.Text = "Return";
            this.tsbReturn.Click += new System.EventHandler(this.tsbReturn_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 763);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainGUI";
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBook;
        private System.Windows.Forms.ToolStripButton tsbMember;
        private System.Windows.Forms.ToolStripButton tsbBorrow;
        private System.Windows.Forms.ToolStripButton tsbReturn;
    }
}