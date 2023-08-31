using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gosecGUI
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string path = pathBox.Text;
            string loginPassword = password.loginPassword;

            Process process = password.process;
            process.StartInfo.Arguments = "/C gosec password load -P " + loginPassword + " -p " + path;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
            }
            else if (output == "missing input for: -p")
            {
                MessageBox.Show("Please Enter File Path.");
            }
            else if (output == "")
            {
                MessageBox.Show("Please Enter file path with file extention like .txt");
            }
            else
            {
                MessageBox.Show(output);
            }
        }

        private void formatBtn_Click(object sender, EventArgs e)
        {
            string loginPassword = password.loginPassword;

            Process process = password.process;
            process.StartInfo.Arguments = "/C gosec password load -P " + loginPassword+ " --format";
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
            }
            else
            {
                MessageBox.Show(output);
            }
        }
    }
}
