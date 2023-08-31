using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gosecGUI
{
    public partial class dump : Form
    {
        public dump()
        {
            InitializeComponent();
        }

        private void dumpBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;
            string userSecret = password.userSecret;
            string path = pathBox.Text;

            string args = "/C gosec password dump -P " + loginPassword;

            if(loginPassword == "")
            {
                MessageBox.Show("Please Enter Login Password.");
                return;
            }

            if (path == "")
            {
                MessageBox.Show("Please Enter Path");
                return;
            }
            else
            {
                args += " -p " + path;
            }

            // Böyle yapıyorum ki iserse girsin istemez ise girmesin userSecret'ı ona göre uyarı alıcak zaten.
            if(userSecret != "")
            {
                args += " -s " + userSecret;
            }

            args += " --out";

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            // Burayı sonra düzelt. Eğer usersecret gerekmiyorsa bile girmek zorundayım çünkü missin input for -s diyor. configten kontrol etmek lazm
            
            if (output == "missing input for: -s")
            {
                MessageBox.Show("Please Enter User Secret.");
            }
            else if (output == "--secret input is required for --out option. Extra security.\nYou can disable it at config.")
            {
                MessageBox.Show("Extra Security is On.\nPlease Enter Your Secret.");
                return;
            }
            else
            {
                MessageBox.Show(output);
            }
        }
    }
}
