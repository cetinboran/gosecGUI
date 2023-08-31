
namespace gosecGUI
{
    partial class gosec
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
            this.registerFormBtn = new System.Windows.Forms.Button();
            this.DeleteFromBtn = new System.Windows.Forms.Button();
            this.PasswordFormBtn = new System.Windows.Forms.Button();
            this.KeyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigFormBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerFormBtn
            // 
            this.registerFormBtn.Location = new System.Drawing.Point(98, 77);
            this.registerFormBtn.Name = "registerFormBtn";
            this.registerFormBtn.Size = new System.Drawing.Size(75, 23);
            this.registerFormBtn.TabIndex = 0;
            this.registerFormBtn.Text = "Register";
            this.registerFormBtn.UseVisualStyleBackColor = true;
            this.registerFormBtn.Click += new System.EventHandler(this.registerFormBtn_Click);
            // 
            // DeleteFromBtn
            // 
            this.DeleteFromBtn.Location = new System.Drawing.Point(179, 77);
            this.DeleteFromBtn.Name = "DeleteFromBtn";
            this.DeleteFromBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteFromBtn.TabIndex = 1;
            this.DeleteFromBtn.Text = "Delete";
            this.DeleteFromBtn.UseVisualStyleBackColor = true;
            this.DeleteFromBtn.Click += new System.EventHandler(this.DeleteFromBtn_Click);
            // 
            // PasswordFormBtn
            // 
            this.PasswordFormBtn.Location = new System.Drawing.Point(260, 77);
            this.PasswordFormBtn.Name = "PasswordFormBtn";
            this.PasswordFormBtn.Size = new System.Drawing.Size(75, 23);
            this.PasswordFormBtn.TabIndex = 2;
            this.PasswordFormBtn.Text = "Password";
            this.PasswordFormBtn.UseVisualStyleBackColor = true;
            this.PasswordFormBtn.Click += new System.EventHandler(this.PasswordFormBtn_Click);
            // 
            // KeyBtn
            // 
            this.KeyBtn.Location = new System.Drawing.Point(341, 77);
            this.KeyBtn.Name = "KeyBtn";
            this.KeyBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyBtn.TabIndex = 3;
            this.KeyBtn.Text = "Key";
            this.KeyBtn.UseVisualStyleBackColor = true;
            this.KeyBtn.Click += new System.EventHandler(this.KeyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gosec GUI";
            // 
            // ConfigFormBtn
            // 
            this.ConfigFormBtn.Location = new System.Drawing.Point(422, 77);
            this.ConfigFormBtn.Name = "ConfigFormBtn";
            this.ConfigFormBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfigFormBtn.TabIndex = 5;
            this.ConfigFormBtn.Text = "Config";
            this.ConfigFormBtn.UseVisualStyleBackColor = true;
            this.ConfigFormBtn.Click += new System.EventHandler(this.ConfigFormBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discover the power of \"GoSec\": Your sleek, secure, and user-friendly password man" +
    "agement solution.";
            // 
            // gosec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfigFormBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBtn);
            this.Controls.Add(this.PasswordFormBtn);
            this.Controls.Add(this.DeleteFromBtn);
            this.Controls.Add(this.registerFormBtn);
            this.Name = "gosec";
            this.Text = "gosec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerFormBtn;
        private System.Windows.Forms.Button DeleteFromBtn;
        private System.Windows.Forms.Button PasswordFormBtn;
        private System.Windows.Forms.Button KeyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfigFormBtn;
        private System.Windows.Forms.Label label2;
    }
}