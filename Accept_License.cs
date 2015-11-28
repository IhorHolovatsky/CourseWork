using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Accept_License : Form
    {
        private string name;
        private string instal_key;


        public Accept_License(string name, string instal_key)
        {
            InitializeComponent();
            this.name = name;
            this.instal_key = instal_key;
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



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_licenseKey.Text != GenerateKey(instal_key + name))
            {
                MessageBox.Show("Invalid License Key! \n Write to author for solving this problem!", "Error!");
            }
            else
            {
                
                RegistryKey Kursova = Registry.CurrentUser.CreateSubKey("Kursova");

                Kursova.SetValue("User name", name);
                Kursova.SetValue("Activation code", tb_licenseKey.Text);

                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_licenseKey.Text.Length != 24)
                btn_Accept.Enabled = false;
            else
                btn_Accept.Enabled = true;
        }
    }
}
