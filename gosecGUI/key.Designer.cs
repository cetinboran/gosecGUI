
namespace gosecGUI
{
    partial class key
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
            this.sixteenCheck = new System.Windows.Forms.RadioButton();
            this.twentfourCheck = new System.Windows.Forms.RadioButton();
            this.thirtytwoCheck = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sixteenCheck
            // 
            this.sixteenCheck.AutoSize = true;
            this.sixteenCheck.Location = new System.Drawing.Point(14, 43);
            this.sixteenCheck.Name = "sixteenCheck";
            this.sixteenCheck.Size = new System.Drawing.Size(37, 17);
            this.sixteenCheck.TabIndex = 0;
            this.sixteenCheck.TabStop = true;
            this.sixteenCheck.Text = "16";
            this.sixteenCheck.UseVisualStyleBackColor = true;
            // 
            // twentfourCheck
            // 
            this.twentfourCheck.AutoSize = true;
            this.twentfourCheck.Location = new System.Drawing.Point(57, 43);
            this.twentfourCheck.Name = "twentfourCheck";
            this.twentfourCheck.Size = new System.Drawing.Size(37, 17);
            this.twentfourCheck.TabIndex = 1;
            this.twentfourCheck.TabStop = true;
            this.twentfourCheck.Text = "24";
            this.twentfourCheck.UseVisualStyleBackColor = true;
            // 
            // thirtytwoCheck
            // 
            this.thirtytwoCheck.AutoSize = true;
            this.thirtytwoCheck.Location = new System.Drawing.Point(100, 43);
            this.thirtytwoCheck.Name = "thirtytwoCheck";
            this.thirtytwoCheck.Size = new System.Drawing.Size(37, 17);
            this.thirtytwoCheck.TabIndex = 2;
            this.thirtytwoCheck.TabStop = true;
            this.thirtytwoCheck.Text = "32";
            this.thirtytwoCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key Length";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 109);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirtytwoCheck);
            this.Controls.Add(this.twentfourCheck);
            this.Controls.Add(this.sixteenCheck);
            this.Name = "key";
            this.Text = "key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sixteenCheck;
        private System.Windows.Forms.RadioButton twentfourCheck;
        private System.Windows.Forms.RadioButton thirtytwoCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}