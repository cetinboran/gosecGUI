
namespace gosecGUI
{
    partial class dump
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.dumpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(100, 15);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(100, 20);
            this.pathBox.TabIndex = 1;
            // 
            // dumpBtn
            // 
            this.dumpBtn.Location = new System.Drawing.Point(206, 12);
            this.dumpBtn.Name = "dumpBtn";
            this.dumpBtn.Size = new System.Drawing.Size(75, 23);
            this.dumpBtn.TabIndex = 2;
            this.dumpBtn.Text = "Dump Passwords";
            this.dumpBtn.UseVisualStyleBackColor = true;
            this.dumpBtn.Click += new System.EventHandler(this.dumpBtn_Click);
            // 
            // dump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 44);
            this.Controls.Add(this.dumpBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "dump";
            this.Text = "dump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button dumpBtn;
    }
}