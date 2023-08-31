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
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }
        public static Process process;


        private void config_Load(object sender, EventArgs e)
        {
            process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
            };
        }

        private void requiredBtn_Click(object sender, EventArgs e)
        {
            string loginPassword = loginP.Text;
            bool checkRequired = requiredCheck.Checked;
            string args = "/C gosec config -P "+ loginPassword + " -req ";

            if (checkRequired)
            {
                args += "true";
            }
            else
            {
                args += "false";
            }

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
                return;
            }
            else
            {
                MessageBox.Show(output);
            }
        }

        private void secretBtn_Click(object sender, EventArgs e)
        {
            string loginPassword = loginP.Text;
            string newSecret = secretBox.Text;
            string args = "/C gosec config -P " + loginPassword + " -k ";

            if(newSecret != "")
            {
                if(newSecret.Length != 16 && newSecret.Length != 24 && newSecret.Length != 32)
                {
                    MessageBox.Show("secret key must be 16, 24 or 32 characters long");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter New Secret!");
                return;
            }

            args += newSecret;

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
                return;
            }
            else
            {
                MessageBox.Show(output);
            }
        }
    }
}
