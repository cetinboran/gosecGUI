
namespace gosecGUI
{
    partial class delete
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
            this.pIdBox = new System.Windows.Forms.TextBox();
            this.idDeleteBtn = new System.Windows.Forms.Button();
            this.DeleteAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password ID";
            // 
            // pIdBox
            // 
            this.pIdBox.Location = new System.Drawing.Point(66, 34);
            this.pIdBox.Name = "pIdBox";
            this.pIdBox.Size = new System.Drawing.Size(100, 20);
            this.pIdBox.TabIndex = 1;
            // 
            // idDeleteBtn
            // 
            this.idDeleteBtn.Location = new System.Drawing.Point(120, 70);
            this.idDeleteBtn.Name = "idDeleteBtn";
            this.idDeleteBtn.Size = new System.Drawing.Size(105, 23);
            this.idDeleteBtn.TabIndex = 2;
            this.idDeleteBtn.Text = "Delete With ID";
            this.idDeleteBtn.UseVisualStyleBackColor = true;
            this.idDeleteBtn.Click += new System.EventHandler(this.idDeleteBtn_Click);
            // 
            // DeleteAllBtn
            // 
            this.DeleteAllBtn.Location = new System.Drawing.Point(9, 70);
            this.DeleteAllBtn.Name = "DeleteAllBtn";
            this.DeleteAllBtn.Size = new System.Drawing.Size(105, 23);
            this.DeleteAllBtn.TabIndex = 3;
            this.DeleteAllBtn.Text = "Delete All";
            this.DeleteAllBtn.UseVisualStyleBackColor = true;
            this.DeleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 109);
            this.Controls.Add(this.DeleteAllBtn);
            this.Controls.Add(this.idDeleteBtn);
            this.Controls.Add(this.pIdBox);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pIdBox;
        private System.Windows.Forms.Button idDeleteBtn;
        private System.Windows.Forms.Button DeleteAllBtn;
    }
}