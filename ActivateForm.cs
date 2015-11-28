using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ActivateForm : Form
    {
        public ActivateForm()
        {
            InitializeComponent();
                        rtb_info.Clear();

                 
            string info = "";
            //Manufacturer, Product, SerialNumber

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                        ManagementObjectCollection information = searcher.Get();

            foreach (ManagementObject obj in information)
                foreach (PropertyData data in obj.Properties)
                {
                    rtb_info.AppendText(String.Format("{0}: {1}", data.Name, data.Value) + "\n");
                    info += data.Value;
                }

            searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            information = searcher.Get();

            foreach (ManagementObject obj in information)
                foreach (PropertyData data in obj.Properties)
                {
                    rtb_info.AppendText(String.Format("{0}: {1}", data.Name, data.Value) + "\n");
                    info += data.Value; 
                }

            rtb_instal.Text = GenerateKey(info);
          
        }

        private static string GenerateKey(string str)
        {
            byte[] hash;
            byte[] UniqueData = Encoding.UTF8.GetBytes(str + "IhorHolovatsky :)");

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                hash = md5.ComputeHash(UniqueData);
            }

            return Convert.ToBase64String(hash);
        }


        private void btn_Trial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getLicense_Click(object sender, EventArgs e)
        {
            Accept_License acceptLicense = new Accept_License(tb_name.Text, rtb_instal.Text);
            acceptLicense.Owner = this;
            acceptLicense.ShowDialog();

            this.Close();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text != "")
                btn_getLicense.Enabled = true;
            else
                btn_getLicense.Enabled = false;
        }
            }
}
