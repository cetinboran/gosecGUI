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
    public partial class key : Form
    {
        public key()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sixteen = sixteenCheck.Checked;
            bool twentyfour = twentfourCheck.Checked;
            bool thirtytwo = thirtytwoCheck.Checked;
            string args = "/C gosec key -gen ";

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
            };

            if (sixteen)
            {
                args += 16;
            }
            if (twentyfour)
            {
                args += 24;
            }
            if (thirtytwo)
            {
                args += 32;
            }

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            MessageBox.Show(output);
        }
    }
}
