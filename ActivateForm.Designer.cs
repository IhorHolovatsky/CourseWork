namespace WindowsFormsApplication2
{
    partial class ActivateForm
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
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.Label_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_organization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_getLicense = new System.Windows.Forms.Button();
            this.btn_Trial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_instal = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_info
            // 
            this.rtb_info.Location = new System.Drawing.Point(11, 114);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(267, 87);
            this.rtb_info.TabIndex = 0;
            this.rtb_info.Text = "";
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_name.Location = new System.Drawing.Point(315, 93);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(83, 18);
            this.Label_name.TabIndex = 1;
            this.Label_name.Text = "Your Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(318, 114);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(251, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_organization
            // 
            this.tb_organization.Location = new System.Drawing.Point(318, 181);
            this.tb_organization.Name = "tb_organization";
            this.tb_organization.Size = new System.Drawing.Size(251, 20);
            this.tb_organization.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(315, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Organization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specification";
            // 
            // btn_getLicense
            // 
            this.btn_getLicense.Enabled = false;
            this.btn_getLicense.Location = new System.Drawing.Point(494, 309);
            this.btn_getLicense.Name = "btn_getLicense";
            this.btn_getLicense.Size = new System.Drawing.Size(75, 23);
            this.btn_getLicense.TabIndex = 6;
            this.btn_getLicense.Text = "Get License";
            this.btn_getLicense.UseVisualStyleBackColor = true;
            this.btn_getLicense.Click += new System.EventHandler(this.btn_getLicense_Click);
            // 
            // btn_Trial
            // 
            this.btn_Trial.Location = new System.Drawing.Point(12, 309);
            this.btn_Trial.Name = "btn_Trial";
            this.btn_Trial.Size = new System.Drawing.Size(75, 23);
            this.btn_Trial.TabIndex = 7;
            this.btn_Trial.Text = "Trial Version";
            this.btn_Trial.UseVisualStyleBackColor = true;
            this.btn_Trial.Click += new System.EventHandler(this.btn_Trial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(85, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "You must activate this product or use Trial version!";
            // 
            // rtb_instal
            // 
            this.rtb_instal.Location = new System.Drawing.Point(11, 248);
            this.rtb_instal.Name = "rtb_instal";
            this.rtb_instal.ReadOnly = true;
            this.rtb_instal.Size = new System.Drawing.Size(267, 21);
            this.rtb_instal.TabIndex = 9;
            this.rtb_instal.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instaliation Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(392, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // ActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 344);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_instal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Trial);
            this.Controls.Add(this.btn_getLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_organization);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.Label_name);
            this.Controls.Add(this.rtb_info);
            this.Name = "ActivateForm";
            this.Text = "ActivateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_organization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getLicense;
        private System.Windows.Forms.Button btn_Trial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_instal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}