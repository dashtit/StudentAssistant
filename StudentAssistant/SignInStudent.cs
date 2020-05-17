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
    public partial class SignInStudent : Form
    {
        public SignInStudent()
        {
            InitializeComponent();
        }

        private void SignInStudent_Load(object sender, EventArgs e)
        {

     
        }

        private void SignInStudentButton_Click(object sender, EventArgs e)
        {
            Connection connect = new Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            string sqlQuery = "select * from Students where login = @log and password = @pass;";

            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = SignInloginstudenttextBox.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = SignInPasswordstudenttextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();

                connect.CloseConnection();
            }

            else
            {
                if (SignInloginstudenttextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your login", "Email field is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SignInPasswordstudenttextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password", "Password field is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Wrong login or password", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
