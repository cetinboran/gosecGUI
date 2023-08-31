
namespace gosecGUI
{
    partial class read
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
            this.listBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(61, 54);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(95, 23);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "List Passwords";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(113, 83);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(95, 23);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.Text = "Copy Password";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 83);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(95, 23);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open Password";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Id:";
            // 
            // pIdBox
            // 
            this.pIdBox.Location = new System.Drawing.Point(108, 15);
            this.pIdBox.Name = "pIdBox";
            this.pIdBox.Size = new System.Drawing.Size(100, 20);
            this.pIdBox.TabIndex = 5;
            // 
            // read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 112);
            this.Controls.Add(this.pIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.listBtn);
            this.Name = "read";
            this.Text = "read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pIdBox;
    }
}