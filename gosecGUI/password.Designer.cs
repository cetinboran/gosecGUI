
namespace gosecGUI
{
    partial class password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.secret = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dumpBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginP
            // 
            this.loginP.Location = new System.Drawing.Point(12, 25);
            this.loginP.Name = "loginP";
            this.loginP.Size = new System.Drawing.Size(100, 20);
            this.loginP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Password";
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(12, 74);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(100, 23);
            this.readBtn.TabIndex = 5;
            this.readBtn.Text = "Read Mode";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Secret";
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(118, 25);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(100, 20);
            this.secret.TabIndex = 6;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(118, 74);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(100, 23);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create Mode";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 103);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(100, 23);
            this.loadBtn.TabIndex = 9;
            this.loadBtn.Text = "Load Mode";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // dumpBtn
            // 
            this.dumpBtn.Location = new System.Drawing.Point(118, 103);
            this.dumpBtn.Name = "dumpBtn";
            this.dumpBtn.Size = new System.Drawing.Size(100, 23);
            this.dumpBtn.TabIndex = 10;
            this.dumpBtn.Text = "Dump Mode";
            this.dumpBtn.UseVisualStyleBackColor = true;
            this.dumpBtn.Click += new System.EventHandler(this.dumpBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(64, 132);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 23);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete Mode";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 165);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dumpBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginP);
            this.Name = "password";
            this.Text = "password";
            this.Load += new System.EventHandler(this.password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secret;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button dumpBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}