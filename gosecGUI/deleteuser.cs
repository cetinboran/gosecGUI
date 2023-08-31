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
    public partial class deleteuser : Form
    {
        public deleteuser()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string password = userP.Text;
            string args = "/C gosec deleteuser -p ";

            if(password == "")
            {
                MessageBox.Show("Enter the password of the user to be deleted.");
                return;
            }
            args += password;

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
            };

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            MessageBox.Show(output);
        }
    }
}
