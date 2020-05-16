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
    public partial class SignUpStudent : Form
    {
        public SignUpStudent()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        private void OkStudentButoon_Click(object sender, EventArgs e)
        {
            string _login = LoginStudenttextBox.Text;
            string _password = PasswordStudenttextBox.Text;
            string _name = NameStudentextBox.Text;
            string _surname = SurnameStudenttextBox.Text;
            string _university = UniversityStudenttextBox.Text;
            string _faculty = FacultyStudenttextBox.Text;
            string _course = CourseStudenttextBox.Text;
            bool passwordFlag = false;
            bool loginFlag = false;
            bool existAccountFlag = false;
            string sqlQuery1 = "select * from Students";
            connection.Open();
            command = new SqlCommand(sqlQuery1, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                object logindean = reader["login"];
                if (_login == logindean.ToString())
                {
                    existAccountFlag = true;
                    break;
                }
                else
                {
                    existAccountFlag = false;
                }
            }
            reader.Close();
            if (!existAccountFlag)
            {
                for (int i = 0; i < _login.Length; i++)
                {
                    if (_login[i] != '.' && _login[i] != '!' && _login[i] != '?' && _login[i] != '@' && _login[i] != '%' && _login[i] != '^' && _login[i] != '*' && _login[i] != '$' && _login[i] != '№')
                    {
                        loginFlag = true;
                    }
                    else
                    {
                        loginFlag = false;
                    }

                }
                if (_password.Length < 5)
                {
                    passwordFlag = false;
                }
                else
                {
                    passwordFlag = true;
                }

                if (loginFlag == true)
                {
                    if (passwordFlag == true)
                    {
                        command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandText = "insert into Students(login, password, name, surname, university, faculty, course) values(\'" + _login + "\', \'" + _password + "\',\'" + _name + "\', \'" + _surname + "\',\'" + _university + "\',\'" + _faculty + "\',\'" + _course + "\');";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Congratulations!\nYou was succesfully signed up!!!");
                        connection.Close();

                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Invalid password!\nPassword minimum length must be 5 symbols!");
                    }
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Invalid login!");
                }
            }
            else
            {
                connection.Close();
                MessageBox.Show("User with this login already exist!");
            }
        }

        private void SignUpStudent_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            connection.Close();
        }
    }
}
