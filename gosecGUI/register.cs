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

   

    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterClass r = new RegisterClass(username.Text, password.Text, cpassword.Text, secret.Text);
            string error = r.checkInputs();

            if(error != "")
            {
                errorLbl.Text = error;
            }
            else
            {
                r.run();
                errorLbl.Text = "Succsessful.";
            }
        }
    }

    // Bu üstte olunca çalışmadı
    class RegisterClass
    {
        public string usernameVal;
        public string passwordVal;
        public string cpasswordVal;
        public string secretVal;

        public RegisterClass(string user, string pass, string cpass, string secret)
        {
            this.usernameVal = user;
            this.passwordVal = pass;
            this.cpasswordVal = cpass;
            this.secretVal = secret;
        }

        public string checkInputs()
        {
            if (this.usernameVal.Length < 3)
            {
                return "Username must be at least 3 characters";
            }

            if(this.passwordVal != this.cpasswordVal)
            {
                return "Password and the confirm password are not match.";
            }

            if (this.passwordVal.Length < 4)
            {
                return "Password must be at least 4 characters";
            }

            if (this.secretVal.Length != 16 && this.secretVal.Length != 24 && this.secretVal.Length != 32)
            {
                return "secret key must be 16, 24 or 32 characters long";
            }


            // Buraya gelirse error yok.
            return "";
        }

        public void run()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                // Argument /C ile başlamalı
                Arguments = "/C gosec register -u " + this.usernameVal + " -p " + this.passwordVal + " -cp " + this.cpasswordVal + " -s " + this.secretVal
            };
            process.Start();

        }
    }
}
