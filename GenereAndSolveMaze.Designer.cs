namespace GenereMaze
{
    partial class GenereAndSolveMaze
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
            this.pb_Draw = new System.Windows.Forms.PictureBox();
            this.btn_genere = new System.Windows.Forms.Button();
            this.tb_M = new System.Windows.Forms.TrackBar();
            this.tb_N = new System.Windows.Forms.TrackBar();
            this.lb_N = new System.Windows.Forms.Label();
            this.lb_M = new System.Windows.Forms.Label();
            this.lb_speed = new System.Windows.Forms.Label();
            this.lb_memory = new System.Windows.Forms.Label();
            this.btn_solve = new System.Windows.Forms.Button();
            this.l_state = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_N)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Draw
            // 
            this.pb_Draw.Location = new System.Drawing.Point(12, 27);
            this.pb_Draw.Name = "pb_Draw";
            this.pb_Draw.Size = new System.Drawing.Size(1035, 606);
            this.pb_Draw.TabIndex = 0;
            this.pb_Draw.TabStop = false;
            this.pb_Draw.Click += new System.EventHandler(this.pb_Draw_Click);
            this.pb_Draw.MouseLeave += new System.EventHandler(this.pb_Draw_MouseLeave);
            this.pb_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Draw_MouseMove);
            // 
            // btn_genere
            // 
            this.btn_genere.Location = new System.Drawing.Point(1203, 197);
            this.btn_genere.Name = "btn_genere";
            this.btn_genere.Size = new System.Drawing.Size(96, 37);
            this.btn_genere.TabIndex = 2;
            this.btn_genere.Text = "Genere";
            this.btn_genere.UseVisualStyleBackColor = true;
            this.btn_genere.Click += new System.EventHandler(this.btn_genere_Click);
            // 
            // tb_M
            // 
            this.tb_M.Location = new System.Drawing.Point(1059, 134);
            this.tb_M.Maximum = 200;
            this.tb_M.Minimum = 1;
            this.tb_M.Name = "tb_M";
            this.tb_M.Size = new System.Drawing.Size(240, 45);
            this.tb_M.TabIndex = 3;
            this.tb_M.Value = 1;
            this.tb_M.ValueChanged += new System.EventHandler(this.tb_M_ValueChanged);
            // 
            // tb_N
            // 
            this.tb_N.Location = new System.Drawing.Point(1059, 55);
            this.tb_N.Maximum = 200;
            this.tb_N.Minimum = 1;
            this.tb_N.Name = "tb_N";
            this.tb_N.Size = new System.Drawing.Size(240, 45);
            this.tb_N.TabIndex = 4;
            this.tb_N.Value = 1;
            this.tb_N.ValueChanged += new System.EventHandler(this.tb_N_ValueChanged);
            // 
            // lb_N
            // 
            this.lb_N.AutoSize = true;
            this.lb_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_N.Location = new System.Drawing.Point(1056, 28);
            this.lb_N.Name = "lb_N";
            this.lb_N.Size = new System.Drawing.Size(27, 18);
            this.lb_N.TabIndex = 5;
            this.lb_N.Text = "N: ";
            // 
            // lb_M
            // 
            this.lb_M.AutoSize = true;
            this.lb_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_M.Location = new System.Drawing.Point(1056, 103);
            this.lb_M.Name = "lb_M";
            this.lb_M.Size = new System.Drawing.Size(29, 18);
            this.lb_M.TabIndex = 6;
            this.lb_M.Text = "M: ";
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_speed.Location = new System.Drawing.Point(1058, 368);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(138, 18);
            this.lb_speed.TabIndex = 7;
            this.lb_speed.Text = "Time of generating: ";
            // 
            // lb_memory
            // 
            this.lb_memory.AutoSize = true;
            this.lb_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_memory.Location = new System.Drawing.Point(1089, 419);
            this.lb_memory.Name = "lb_memory";
            this.lb_memory.Size = new System.Drawing.Size(107, 18);
            this.lb_memory.TabIndex = 8;
            this.lb_memory.Text = "Memory used: ";
            // 
            // btn_solve
            // 
            this.btn_solve.Location = new System.Drawing.Point(1203, 254);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(96, 37);
            this.btn_solve.TabIndex = 9;
            this.btn_solve.Text = "Solve maze";
            this.btn_solve.UseVisualStyleBackColor = true;
            this.btn_solve.Click += new System.EventHandler(this.btn_solve_Click);
            // 
            // l_state
            // 
            this.l_state.AutoSize = true;
            this.l_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_state.ForeColor = System.Drawing.Color.Turquoise;
            this.l_state.Location = new System.Drawing.Point(1188, 307);
            this.l_state.Name = "l_state";
            this.l_state.Size = new System.Drawing.Size(111, 22);
            this.l_state.TabIndex = 10;
            this.l_state.Text = "Computing...";
            this.l_state.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1084, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time of solving:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_state);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.lb_memory);
            this.Controls.Add(this.lb_speed);
            this.Controls.Add(this.lb_M);
            this.Controls.Add(this.lb_N);
            this.Controls.Add(this.tb_N);
            this.Controls.Add(this.tb_M);
            this.Controls.Add(this.btn_genere);
            this.Controls.Add(this.pb_Draw);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Genere And Solve Maze";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_N)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Draw;
        private System.Windows.Forms.Button btn_genere;
        private System.Windows.Forms.TrackBar tb_M;
        private System.Windows.Forms.TrackBar tb_N;
        private System.Windows.Forms.Label lb_N;
        private System.Windows.Forms.Label lb_M;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Label lb_memory;
        private System.Windows.Forms.Button btn_solve;
        private System.Windows.Forms.Label l_state;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;


    }
}

