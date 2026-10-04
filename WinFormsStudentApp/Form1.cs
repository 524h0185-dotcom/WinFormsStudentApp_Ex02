using System;
using System.Windows.Forms;

namespace WinFormsStudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.IsNullOrWhiteSpace(txtStudentName.Text)
                ? "Please enter a student name."
                : "Student: " + txtStudentName.Text.Trim();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            lblResult.Text = string.Empty;
            txtStudentName.Focus();
        }
    }
}
