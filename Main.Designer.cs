namespace WindowsFormsApplication2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pb_Start = new System.Windows.Forms.PictureBox();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.getLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Start
            // 
            this.pb_Start.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Start.InitialImage")));
            this.pb_Start.Location = new System.Drawing.Point(12, 51);
            this.pb_Start.Name = "pb_Start";
            this.pb_Start.Size = new System.Drawing.Size(245, 269);
            this.pb_Start.TabIndex = 0;
            this.pb_Start.TabStop = false;
            this.pb_Start.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_help
            // 
            this.pb_help.InitialImage = null;
            this.pb_help.Location = new System.Drawing.Point(283, 51);
            this.pb_help.Name = "pb_help";
            this.pb_help.Size = new System.Drawing.Size(245, 269);
            this.pb_help.TabIndex = 1;
            this.pb_help.TabStop = false;
            this.pb_help.Click += new System.EventHandler(this.pb_help_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.Location = new System.Drawing.Point(554, 51);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(245, 269);
            this.pb_exit.TabIndex = 2;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getLicenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // getLicenseToolStripMenuItem
            // 
            this.getLicenseToolStripMenuItem.Name = "getLicenseToolStripMenuItem";
            this.getLicenseToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.getLicenseToolStripMenuItem.Text = "Get License";
            this.getLicenseToolStripMenuItem.Click += new System.EventHandler(this.getLicenseToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 332);
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.pb_Start);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Genere And Solve Maze";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Start;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getLicenseToolStripMenuItem;
    }
}