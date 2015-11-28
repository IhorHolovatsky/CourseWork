namespace WindowsFormsApplication2
{
    partial class Accept_License
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_licenseKey = new System.Windows.Forms.TextBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inpute you license key";
            // 
            // tb_licenseKey
            // 
            this.tb_licenseKey.Location = new System.Drawing.Point(12, 79);
            this.tb_licenseKey.Name = "tb_licenseKey";
            this.tb_licenseKey.Size = new System.Drawing.Size(370, 20);
            this.tb_licenseKey.TabIndex = 1;
            this.tb_licenseKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Enabled = false;
            this.btn_Accept.Location = new System.Drawing.Point(307, 159);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Decline
            // 
            this.btn_Decline.Location = new System.Drawing.Point(12, 159);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(75, 23);
            this.btn_Decline.TabIndex = 3;
            this.btn_Decline.Text = "Decline";
            this.btn_Decline.UseVisualStyleBackColor = true;
            this.btn_Decline.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accept_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.btn_Decline);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.tb_licenseKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Accept_License";
            this.Text = "Accept_License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_licenseKey;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Decline;
    }
}