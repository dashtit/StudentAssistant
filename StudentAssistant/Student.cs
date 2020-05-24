using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistant
{
  public  class Student
    {
        private int id;
        private string login;
        private string password;
        private string university;
        private string faculty;
        private string course;

        private Connection connection = Connection.GetInstance();
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select * from Students where login = @log;";
        private SqlDataReader reader;

        public Student(SignInStudent signInStudent)
        {
            this.login = signInStudent.GetLogin();
            this.password = signInStudent.GetPassword();
            this.id = GetID();
            this.university = GetUnivetsity();
            this.faculty = GetFaculty();
            this.course = GetCourse();
            
        }

        public int ID
        {
            get => this.id;
        }
        public string Login
        {
            get => this.login;
        }
        public string Password
        {
            get => this.password;
        }
        public string University
        {
            get => this.university;
        }
        public string Faculty
        {
            get => this.faculty;
        }
        public string Course
        {
            get => this.course;
        }

        public string GetLogin() => this.login;
        public string GetPassword() => this.password;
        

        public int GetID()
        {
            int tempID;
            connection.OpenConnection();
            command.Connection = connection.GetConnection();
            command.Parameters.Add("@log", System.Data.SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar).Value = password;
            command.CommandText = sqlQuery;

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tempID = Convert.ToInt32(reader["ID"]);
                connection.CloseConnection();
                return tempID;
            }
            reader.Close();
            return 0;
        }
        public string GetUnivetsity()
        {
            string tempUniversity;
            connection.OpenConnection();
            command.Connection = connection.GetConnection();
            command.CommandText = sqlQuery;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tempUniversity = Convert.ToString(reader["university"]);
                connection.CloseConnection();
                return tempUniversity;
            }
            reader.Close();
            return "";  
        }
        public string GetFaculty()
        {
            string tempFaculty;
            connection.OpenConnection();
            command.Connection = connection.GetConnection();
            command.CommandText = sqlQuery;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tempFaculty = Convert.ToString(reader["faculty"]);
                connection.CloseConnection();
                return tempFaculty;
            }
            reader.Close();
            return "";
        }
        public string GetCourse()
        {
            string tempCourse;
            connection.OpenConnection();
            command.Connection = connection.GetConnection();
            command.CommandText = sqlQuery;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                tempCourse = Convert.ToString(reader["course"]);
                connection.CloseConnection();
                return tempCourse;
            }
            reader.Close();
            return "";
        }

    }
}
