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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        public static string loginPassword = "";
        public static string userSecret = "";
        public static Process process;

        private void readBtn_Click(object sender, EventArgs e)
        {
            loginPassword = loginP.Text;
            userSecret = secret.Text;
            read ReadForm = new read();
            ReadForm.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            loginPassword = loginP.Text;
            userSecret = secret.Text;
            delete DeleteForm = new delete();
            DeleteForm.Show();
        }

        private void dumpBtn_Click(object sender, EventArgs e)
        {
            loginPassword = loginP.Text;
            userSecret = secret.Text;
            dump DumpForm = new dump();
            DumpForm.Show();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loginPassword = loginP.Text;
            load LoadForm = new load();
            LoadForm.Show();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            loginPassword = loginP.Text;
            create CreateForm = new create();
            CreateForm.Show();

        }

        private void password_Load(object sender, EventArgs e)
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

       
    }
}
