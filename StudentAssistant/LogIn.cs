using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StudentAssistant
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
      
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (isDeancheckBox.Checked)
            {
                SignUpDean signUpDean = new SignUpDean();
                signUpDean.Show();
                this.Hide();
            }
            else
            {
                SignUpStudent signUpStudent = new SignUpStudent();
                signUpStudent.Show();
                this.Hide();
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SignInDeanButton_Click(object sender, EventArgs e)
        {
            SignInDeanForn signInDean = new SignInDeanForn();
            signInDean.Show();
            this.Hide();
           
        }

        private void SignInStudentButton_Click(object sender, EventArgs e)
        {
            SignInStudent signInStudent = new SignInStudent();
            signInStudent.Show();
            this.Hide();
        }
    }
}
