using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gosecGUI
{
    public partial class gosec : Form
    {
        public gosec()
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(gosec_FormClosed);
        }

        private void registerFormBtn_Click(object sender, EventArgs e)
        {
            register RegisterForm = new register();
            RegisterForm.Show();
        }

        private void PasswordFormBtn_Click(object sender, EventArgs e)
        {
            password PasswordForm = new password();
            PasswordForm.Show();
        }

        private void ConfigFormBtn_Click(object sender, EventArgs e)
        {
            config ConfigForm = new config();
            ConfigForm.Show();
        }

        private void KeyBtn_Click(object sender, EventArgs e)
        {
            key KeyForm = new key();
            KeyForm.Show();
        }

        private void DeleteFromBtn_Click(object sender, EventArgs e)
        {
            deleteuser DeleteUserForm = new deleteuser();
            DeleteUserForm.Show();
        }

        // Programın kapandığından emin olmak için ekledim.
        private void gosec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
