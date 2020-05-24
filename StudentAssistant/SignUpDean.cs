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
using System.Text.RegularExpressions;

namespace StudentAssistant
{
    public partial class SignUpDean : Form
    {
        public SignUpDean()
        {
            InitializeComponent();
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpDean_Load(object sender, EventArgs e)
        {
         
        }

        private void OkDeanButoon_Click(object sender, EventArgs e)
        {
            Connection connection = Connection.GetInstance();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            SqlCommand checkCommand = new SqlCommand();
            SqlDataReader reader;
            bool isDeanexist = false;
            bool isDeanFacultyExist = false;
            string SqlQuery = "select * from Dean where login = \'@log\' and password = \'@pass\';";
            string pattern = @"[a-zA-Z0-9]";
            string sqlQuery1 = "select * from Dean";
            connection.OpenConnection();
            checkCommand.CommandText = sqlQuery1;
            checkCommand.Connection = connection.GetConnection();
            reader = checkCommand.ExecuteReader();
            while (reader.Read())
            {
                if (LoginDeantextBox.Text == reader["login"].ToString())
                {
                    isDeanexist = true;
                    reader.Close();
                    break;
                }
            }
            reader.Close();
            reader = checkCommand.ExecuteReader();
            while (reader.Read())
            {
                if (UniversityDeantextBox.Text == reader["university"].ToString() && FacultyDeantextBox.Text == reader["faculty"].ToString())
                {
                    isDeanFacultyExist = true;
                    reader.Close();
                    break;
                }
            }

            command.CommandText = SqlQuery;
            command.Connection = connection.GetConnection();
            if (Regex.IsMatch(LoginDeantextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                if (PasswordDeantextBox.Text.Length > 5)
                {
                    command.Parameters.Add("@log", SqlDbType.VarChar).Value = LoginDeantextBox.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = PasswordDeantextBox.Text;
                    command.Parameters.Add("@univer", SqlDbType.VarChar).Value = UniversityDeantextBox.Text;
                    command.Parameters.Add("@fac", SqlDbType.VarChar).Value = FacultyDeantextBox.Text;
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = NameDeantextBox.Text;
                    command.Parameters.Add("@surname", SqlDbType.VarChar).Value = SurnameDeantextBox.Text;
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataTable);
                    if (!isDeanexist)
                    {
                        if (!isDeanFacultyExist)
                        {
                            if (dataTable.Rows.Count == 0)
                            {
                                string sqlQuery2 = "insert into Dean(login, password, name, surname, university, faculty) values(@log, @pass, @name, @surname, @univer, @fac);";

                                command.Connection = connection.GetConnection();
                                command.CommandText = sqlQuery2;
                                command.ExecuteNonQuery();
                                connection.CloseConnection();
                                MessageBox.Show("Your account was signed up", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                DeanForm deanForm = new DeanForm();
                                deanForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("This faculty already has a Dean!", "Used faculty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dean with this login is already exist!", "Used login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }

                else
                {
                    MessageBox.Show("Password must be longer than 5 symbols!", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid login!", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SignUpDean_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
  
}
