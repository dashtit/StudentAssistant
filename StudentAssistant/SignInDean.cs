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
using System.Runtime.InteropServices;

namespace StudentAssistant
{
    public partial class SignInDeanForn : Form
    {

        public SignInDeanForn()
        {
            InitializeComponent();
        }
        
        private void SignIndeantextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInDeanForn_Load(object sender, EventArgs e)
        {
      
        }
        private void SugnInDean_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string GetLogin() => SignInlogindeantextBox.Text;
        public string GetPassword() => SignInPasswordDeantextBox.Text;
        private void SignInDeanButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            string sqlQuery = "select * from Dean where login = @log and password = @pass;";

            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = SignInlogindeantextBox.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = SignInPasswordDeantextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                Dean dean = new Dean(this);
                DeanForm deanForm = new DeanForm();
                Admin admin = new Admin(deanForm, dean);
                deanForm.SetAdmin(admin);
                deanForm.Show();
                this.Hide();
                connect.CloseConnection();
            }

            else
            {
                if (SignInlogindeantextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your login", "Email field is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SignInPasswordDeantextBox.Text.Trim().Equals(""))
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

