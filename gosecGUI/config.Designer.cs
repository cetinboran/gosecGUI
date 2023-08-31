
namespace gosecGUI
{
    partial class config
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
            this.label1 = new System.Windows.Forms.Label();
            this.requiredCheck = new System.Windows.Forms.CheckBox();
            this.secretBox = new System.Windows.Forms.TextBox();
            this.secretBtn = new System.Windows.Forms.Button();
            this.requiredBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Secret Key";
            // 
            // requiredCheck
            // 
            this.requiredCheck.AutoSize = true;
            this.requiredCheck.Location = new System.Drawing.Point(67, 58);
            this.requiredCheck.Name = "requiredCheck";
            this.requiredCheck.Size = new System.Drawing.Size(103, 17);
            this.requiredCheck.TabIndex = 1;
            this.requiredCheck.Text = "Secret Required";
            this.requiredCheck.UseVisualStyleBackColor = true;
            // 
            // secretBox
            // 
            this.secretBox.Location = new System.Drawing.Point(118, 32);
            this.secretBox.Name = "secretBox";
            this.secretBox.Size = new System.Drawing.Size(100, 20);
            this.secretBox.TabIndex = 2;
            // 
            // secretBtn
            // 
            this.secretBtn.Location = new System.Drawing.Point(126, 92);
            this.secretBtn.Name = "secretBtn";
            this.secretBtn.Size = new System.Drawing.Size(101, 23);
            this.secretBtn.TabIndex = 3;
            this.secretBtn.Text = "Set Secret Key";
            this.secretBtn.UseVisualStyleBackColor = true;
            this.secretBtn.Click += new System.EventHandler(this.secretBtn_Click);
            // 
            // requiredBtn
            // 
            this.requiredBtn.Location = new System.Drawing.Point(7, 92);
            this.requiredBtn.Name = "requiredBtn";
            this.requiredBtn.Size = new System.Drawing.Size(115, 23);
            this.requiredBtn.TabIndex = 4;
            this.requiredBtn.Text = "Set Secret Required";
            this.requiredBtn.UseVisualStyleBackColor = true;
            this.requiredBtn.Click += new System.EventHandler(this.requiredBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login Password";
            // 
            // loginP
            // 
            this.loginP.Location = new System.Drawing.Point(12, 32);
            this.loginP.Name = "loginP";
            this.loginP.Size = new System.Drawing.Size(100, 20);
            this.loginP.TabIndex = 5;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginP);
            this.Controls.Add(this.requiredBtn);
            this.Controls.Add(this.secretBtn);
            this.Controls.Add(this.secretBox);
            this.Controls.Add(this.requiredCheck);
            this.Controls.Add(this.label1);
            this.Name = "config";
            this.Text = "config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox requiredCheck;
        private System.Windows.Forms.TextBox secretBox;
        private System.Windows.Forms.Button secretBtn;
        private System.Windows.Forms.Button requiredBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginP;
    }
}