namespace WinFormsStudentApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(48, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WinForms Student App";
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentName.Location = new System.Drawing.Point(50, 105);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(101, 19);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(54, 130);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(320, 25);
            this.txtStudentName.TabIndex = 2;
            this.btnShow.Location = new System.Drawing.Point(54, 180);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 36);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Student";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnClear.Location = new System.Drawing.Point(229, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(50, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 320);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Student App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
