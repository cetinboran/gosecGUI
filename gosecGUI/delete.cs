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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;

            process.StartInfo.Arguments = "/C gosec password delete -P " + loginPassword + " --all";
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            // Burayı sonra düzelt. Eğer usersecret gerekmiyorsa bile girmek zorundayım çünkü missin input for -s diyor. configten kontrol etmek lazm

            if (output == "missing input for: -P")
            {
                MessageBox.Show("Please Enter User Password");
            }
            else
            {
                MessageBox.Show(output);
            }
        }

        private void idDeleteBtn_Click(object sender, EventArgs e)
        {
            Process process = password.process;
            string loginPassword = password.loginPassword;
            string passwordId = pIdBox.Text;

            process.StartInfo.Arguments = "/C gosec password delete -P " + loginPassword + " -i " + passwordId;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output = output.Trim();

            // Burayı sonra düzelt. Eğer usersecret gerekmiyorsa bile girmek zorundayım çünkü missin input for -s diyor. configten kontrol etmek lazm

            if (output == "missing input for: -i" || output == "You have to enter an integer in -i/--id")
            {
                MessageBox.Show("Please Enter Valid Password Id");
            }
            else if (output == "missing input for: -P")
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
