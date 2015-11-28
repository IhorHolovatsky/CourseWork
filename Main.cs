using Microsoft.Win32;
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
using GenereMaze;


namespace WindowsFormsApplication2
{
    public partial class Main : Form
    {
        private bool isActivated = false;

        public Main()
        {
            InitializeComponent();
        }

      

        private void CheckLicense()
        {
            RegistryKey Reg = Registry.CurrentUser.OpenSubKey("Kursova");

            if (Reg == null)
            {
                isActivated = false;
                return;
            }


            string activation_code = (string)Reg.GetValue("Activation code");
            string name = (string)Reg.GetValue("User name");
            string info = "";
            //Manufacturer, Product, SerialNumber

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            ManagementObjectCollection information = searcher.Get();

            foreach (ManagementObject obj in information)
                foreach (PropertyData data in obj.Properties)
                {
                    info += data.Value;
                }

            searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
            information = searcher.Get();

            foreach (ManagementObject obj in information)
                foreach (PropertyData data in obj.Properties)
                {
                    info += data.Value;
                }

            string instalKey = GenerateKey(info);

            string ActivationKey = GenerateKey(instalKey + name);

            if (ActivationKey != activation_code)
                isActivated = false;
            else
                isActivated = true;
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

        private void Main_Shown(object sender, EventArgs e)
        {
            CheckLicense();
            if (!isActivated)
            {
                ActivateForm Activation = new ActivateForm();
                Activation.Owner = this;
                Activation.ShowDialog();
                CheckLicense();
                
            }
        }

        private void getLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            CheckLicense();
            if (!isActivated)
            {
                ActivateForm Activation = new ActivateForm();
                Activation.Owner = this;
                Activation.ShowDialog();
                CheckLicense();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GenereAndSolveMaze newForm = new GenereAndSolveMaze(isActivated);
            this.Hide();
            newForm.ShowDialog();
      
            
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            pb_Start.Image = GenereMaze.Properties.Resources.Start;// new Bitmap(@"D:\User\Курсова\WindowsFormsApplication2\WindowsFormsApplication2\Genere Maze\images.jpg");
            pb_Start.SizeMode = PictureBoxSizeMode.StretchImage;

            pb_help.Image = GenereMaze.Properties.Resources.Help;
            pb_help.SizeMode = PictureBoxSizeMode.StretchImage;
           
            pb_exit.Image = GenereMaze.Properties.Resources.Exit;
            pb_exit.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@" 
            1. Choose a ranges of maze (N; M)
            2. Enter button ""Genere"" 
            3. In maze, by mouse, choose entry cell and exit cell
            4. Click on button ""Solve maze"" and have fun ;) 
      Producted by Ihor Holovatsky™", "Help!");
            
        }


    }
}
