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
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (isDeancheckBox.Checked)
            {
                SignUpDean signUpDean = new SignUpDean();
                signUpDean.Show();
            }
            else
            {
                SignUpStudent signUpStudent = new SignUpStudent();
                signUpStudent.Show();
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            connection.Close();
        }

        private void SignInDeanButton_Click(object sender, EventArgs e)
        {
            SignInDeanForn signInDean = new SignInDeanForn();
            signInDean.Show();
           
        }
    }
}
