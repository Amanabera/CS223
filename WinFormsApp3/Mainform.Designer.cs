namespace LAB_Project_GUI
{
    partial class Mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProducttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogouttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProducttoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProducttoolStripMenuItem
            // 
            this.ProducttoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddtoolStripMenuItem,
            this.SearchtoolStripMenuItem,
            this.ViewtoolStripMenuItem,
            this.LogouttoolStripMenuItem});
            this.ProducttoolStripMenuItem.Name = "ProducttoolStripMenuItem";
            this.ProducttoolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ProducttoolStripMenuItem.Text = "\"Product\"";
            // 
            // AddtoolStripMenuItem
            // 
            this.AddtoolStripMenuItem.Name = "AddtoolStripMenuItem";
            this.AddtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddtoolStripMenuItem.Text = "\"Add product\"";
            // 
            // SearchtoolStripMenuItem
            // 
            this.SearchtoolStripMenuItem.Name = "SearchtoolStripMenuItem";
            this.SearchtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchtoolStripMenuItem.Text = "\"Search for poduct\"";
            // 
            // ViewtoolStripMenuItem
            // 
            this.ViewtoolStripMenuItem.Name = "ViewtoolStripMenuItem";
            this.ViewtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ViewtoolStripMenuItem.Text = "\"View product\"";
            // 
            // LogouttoolStripMenuItem
            // 
            this.LogouttoolStripMenuItem.Name = "LogouttoolStripMenuItem";
            this.LogouttoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LogouttoolStripMenuItem.Text = "\"Log out\"";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ProducttoolStripMenuItem;
        private ToolStripMenuItem AddtoolStripMenuItem;
        private ToolStripMenuItem SearchtoolStripMenuItem;
        private ToolStripMenuItem ViewtoolStripMenuItem;
        private ToolStripMenuItem LogouttoolStripMenuItem;
    }
}