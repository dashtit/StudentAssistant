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
    public partial class SignInDeanForn : Form
    {
        public SignInDeanForn()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        private void SignIndeantextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInDeanForn_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            connection.Close();
        }

        private void SignInDeanButton_Click(object sender, EventArgs e)
        {
            string _login = SignInlogindeantextBox.Text;
            string _password = SignInPasswordDeantextBox.Text;
            bool flag = false;
            connection.Open();
            string sqlQuery = "select * from Dean";
            command = new SqlCommand(sqlQuery, connection);
            reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("In the data base has no users!\nPlease sign up", "Error");
            }
            else
            {
                while (reader.Read())
                {
                    object login = reader["login"];
                    object password = reader["password"];

                    if (_login == login.ToString() && _password == password.ToString())
                    {
                        flag = true;
                    }
                }

                if (flag)
                {

                    DeanForm deanForm = new DeanForm();
                    deanForm.Show();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login or password!", "Error");
                    reader.Close();
                }
            }

            connection.Close();
        }
    }
 }

