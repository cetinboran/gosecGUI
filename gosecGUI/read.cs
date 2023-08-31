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
    public partial class read : Form
    {
        public read()
        {
            InitializeComponent();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;

            process.StartInfo.Arguments = "/C gosec password read -P " + loginPassword + " --list";
            process.Start();

            list ListForm = new list();

            // Yazacağım formun objesini oluşturdum ve onun içinteki textboxa listform. ile erişitm.
            // Bunun için list formundaki textboxu public yaptım propertysden.

            string output2;
            while ((output2 = process.StandardOutput.ReadLine()) != null)
            {
                output2 = output2.Trim(); // trim outoutları if ile kontrol etmek için.
                if (output2 == "missing input for: -P")
                {
                    ListForm.listBox.Clear();
                    ListForm.listBox.Text = "Wrong password. Try again";
                    break;
                }

                if(output2 != ""){
                    ListForm.listBox.AppendText(output2);
                    ListForm.listBox.AppendText(Environment.NewLine);
                }
            }

            ListForm.Show();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;
            string passwordId = pIdBox.Text;
            string userSecret = password.userSecret;

            string args = "/C gosec password read -P " + loginPassword;

            if(passwordId == "")
            {
                MessageBox.Show("Please Enter Password Id.");
                return;
            }
            else
            {
                args += " --copy -i " + passwordId;
            }

            if(userSecret != "")
            {
                args += " -s " + userSecret;
            }


            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            // Burayı sonra düzelt. Eğer usersecret gerekmiyorsa bile girmek zorundayım çünkü missin input for -s diyor. configten kontrol etmek lazm

            if (output == "To use --copy you must enter --secret. This is for extra security\nYou can disable it at config.")
            {
                MessageBox.Show("Extra Security is On.\nPlease Enter Your Secret.");
                return;

            } else if (output == "You have to enter an integer in -i/--id")
            {
                MessageBox.Show("Please Enter Password Id");
                return;
            }
            else if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
                return;
            }
            else
            {
                MessageBox.Show(output);
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            string loginPassword = password.loginPassword;
            string passwordId = pIdBox.Text;

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C gosec password read -P " + loginPassword + " --open -i " + passwordId,
            };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            // Burayı sonra düzelt. Eğer usersecret gerekmiyorsa bile girmek zorundayım çünkü missin input for -s diyor. configten kontrol etmek lazm

            if (output == "missing input for: -i" || output == "You have to enter an integer in -i/--id")
            {
                MessageBox.Show("Please Enter Password Id");
            }
            else if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
            }

            if(output == "Please enter a valid password id")
            {
                MessageBox.Show(output);
            }

        }
    }
}
