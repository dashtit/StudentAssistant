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
    public partial class SignUpStudent : Form
    {
        public SignUpStudent()
        {
            InitializeComponent();
        }
        private void SignUpStudent_Load(object sender, EventArgs e)
        {

        }
        private void SignUpStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void OkStudentButoon_Click(object sender, EventArgs e)
        {
            Connection connection = Connection.GetInstance();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            SqlCommand checkCommand = new SqlCommand();
            SqlDataReader reader;
            bool isStudentExist = false;
            string sqlQuery1 = "select * from Students";
            string SqlQuery = "select * from Students where login = \'@log\' and password = \'@pass\';";
            string pattern = @"[a-zA-Z0-9]";
            connection.OpenConnection();
            checkCommand.CommandText = sqlQuery1;
            checkCommand.Connection = connection.GetConnection();
            reader = checkCommand.ExecuteReader();
            while (reader.Read())
            {
                if (LoginStudenttextBox.Text == reader["login"].ToString())
                {
                    isStudentExist = true;
                    reader.Close();
                    break;
                }
            }
            command.CommandText = SqlQuery;
            command.Connection = connection.GetConnection();
          
            if (Regex.IsMatch(LoginStudenttextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                if (PasswordStudenttextBox.Text.Length > 5)
                {
                    Hashing hashing = new Hashing(PasswordStudenttextBox.Text);

                    command.Parameters.Add("@log", SqlDbType.VarChar).Value = LoginStudenttextBox.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashing.Hash;
                    command.Parameters.Add("@salt", SqlDbType.VarChar).Value = hashing.Salt;
                    command.Parameters.Add("@univer", SqlDbType.VarChar).Value = UniversityStudenttextBox.Text;
                    command.Parameters.Add("@fac", SqlDbType.VarChar).Value = FacultyStudenttextBox.Text;
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = NameStudentextBox.Text;
                    command.Parameters.Add("@surname", SqlDbType.VarChar).Value = SurnameStudenttextBox.Text;
                    command.Parameters.Add("@course", SqlDbType.VarChar).Value = CourseStudenttextBox.Text;
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dataTable);
                    if (!isStudentExist)
                    {
                        if (dataTable.Rows.Count == 0)
                        {
                            string sqlQuery2 = "insert into Students(login, name, surname, university, faculty, course, salt, password) values(@log, @name, @surname, @univer, @fac, @course, @salt, @pass);";

                            command.Connection = connection.GetConnection();
                            command.CommandText = sqlQuery2;
                            command.ExecuteNonQuery();
                            connection.CloseConnection();
                            MessageBox.Show("Your account was signed up", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            StudentForm studentForm = new StudentForm();
                            studentForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student with this login is already exist!", "Used login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }

}
