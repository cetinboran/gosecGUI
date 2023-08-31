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
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;

            string title = titleBox.Text;
            string url = urlBox.Text;
            string username = usernameBox.Text;
            string passwordV = passwordBox.Text;
            bool checkGenerate = generateCheck.Checked;

            string args = "/C gosec password create -P " + loginPassword;
            if(title != "")
            {
                args += " -t " + title; 
            }

            if(url != "")
            {
                args += " --url " + url;
            }

            if(username != "")
            {
                args += " -u " + username;

            }

            if (checkGenerate)
            {
                args += " --generate";
            }
            else
            {
                if(passwordV == "")
                {
                    MessageBox.Show("Please Enter Password!");
                    return;
                }
                args += " -p " + passwordV;
            }

            process.StartInfo.Arguments = args;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            output = output.Trim();

            MessageBox.Show(output);

        }
    }
}
