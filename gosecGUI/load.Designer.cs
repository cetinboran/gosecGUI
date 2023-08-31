
namespace gosecGUI
{
    partial class load
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(20, 51);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(99, 23);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load Passwords";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(117, 24);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(100, 20);
            this.pathBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The Path:";
            // 
            // formatBtn
            // 
            this.formatBtn.Location = new System.Drawing.Point(127, 50);
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(90, 23);
            this.formatBtn.TabIndex = 6;
            this.formatBtn.Text = "Create Format";
            this.formatBtn.UseVisualStyleBackColor = true;
            this.formatBtn.Click += new System.EventHandler(this.formatBtn_Click);
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 87);
            this.Controls.Add(this.formatBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "load";
            this.Text = "load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button formatBtn;
    }
}