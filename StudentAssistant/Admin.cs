using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StudentAssistant
{
    public class Admin
    {
        private Dean dean;
        private int ID;
        private string login;
        private string password;
        private string university;
        private string faculty;
        private string SubjectName;
        private string SubjectCourse;
        private string SubjectUniversity;
        private string SubjectFaculty;
        private int SubjectID;
        private int StudentID;
        private DeanForm deanForm;
        private Connection connection = Connection.GetInstance();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

        public Admin(DeanForm deanform, Dean dean)
        {
            this.dean = dean;
            this.ID = dean.ID;
            this.login = dean.Login;
            this.password = dean.Password;
            this.university = dean.University;
            this.faculty = dean.Faculty;
            this.deanForm = deanform;
        }
        public int Id
        {
            get => this.ID;
        }

        public void ShowSubjects()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Subjects where university = \'" + dean.University + "\' and faculty = \'" + dean.Faculty + "\';";    
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Subjects");
            deanForm.dataGridView1.DataSource = dataSet.Tables["Subjects"];
            connection.CloseConnection();
        }

        public void ShowStudents()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Students where university = \'" + dean.University + "\' and faculty = \'" + dean.Faculty + "\';";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Students");
            deanForm.dataGridView1.DataSource = dataSet.Tables["Students"];
            connection.CloseConnection();
        }

        public void AddSubject()
        {
         
                this.SubjectName = deanForm.SubjectNameTextBox.Text;
                this.SubjectCourse = deanForm.CourseTextBox.Text;
                this.SubjectUniversity = dean.University;
                this.SubjectFaculty = dean.Faculty;

                connection.OpenConnection();
                string sqlQuery = "insert into Subjects(subname, university, faculty, course)" +
                                   "values(@subjname, @university, @fac, @course);\n";
                command.Parameters.Add("@subjname", SqlDbType.VarChar).Value = this.SubjectName;
                command.Parameters.Add("@university", SqlDbType.VarChar).Value = this.SubjectUniversity;
                command.Parameters.Add("@fac", SqlDbType.VarChar).Value = this.SubjectFaculty;
                command.Parameters.Add("@course", SqlDbType.VarChar).Value = this.SubjectCourse;

                command.Connection = connection.GetConnection();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                MessageBox.Show("Subject was succesful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.Parameters.Clear();
                connection.CloseConnection();
            
        }

        public void DeleteSubject()
        {
            try
            {
             this.SubjectID = Convert.ToInt32(deanForm.SubjectIDtextBox.Text);
                try
                {
                    connection.OpenConnection();
                    string sqlQuery = "delete from Exam where subjectID = @ID;\n" +  
                                      "delete from Subjects where ID = @ID";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.SubjectID;
                    command.Connection = connection.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject was successfuly deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.Parameters.Clear();
                    connection.CloseConnection();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                }

            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }
        }
        public void DeleteStudent()
        {
            try
            {
                this.StudentID = Convert.ToInt32(deanForm.StudentIDtextBox.Text);
                try
                {
                    connection.OpenConnection();
                    string sqlQuery = "delete from Exam where studentID = @ID;\n" +
                                      "delete from Students where ID = @ID";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.StudentID;
                    command.Connection = connection.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student was successfuly deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.Parameters.Clear();
                    connection.CloseConnection();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                }

            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }

        }




    }
}
