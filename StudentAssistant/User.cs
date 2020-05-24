using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentAssistant
{
    public class User
    {
        private Student student;
        private int ID;
        private string login;
        private string password;
        private string university;
        private string faculty;
        private string course;
        private int SubjectID;
        private string ExamDate;
        private string PrepareTime;
        private string Difficult;
        private string Material;
        private string AddMaterial;
        private int ExamID;
        private StudentForm studentForm;
        private Connection connection = Connection.GetInstance();
        private SqlCommand command = new SqlCommand();

        public User(StudentForm studentform, Student student)
        {
            this.student = student;
            this.ID = student.ID;
            this.login = student.Login;
            this.password = student.Password;
            this.university = student.University;
            this.faculty = student.Faculty;
            this.course = student.Course;
            this.studentForm = studentform;
        }

        public int Id
        {
            get => this.ID;
        }

        public void ShowSubjectsStudent()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Subjects where university = \'" + student.University + "\' and faculty = \'" + student.Faculty + "\' and course = \'" + student.Course + "\';";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Subjects");
            studentForm.dataGridViewSubjectsStudent.DataSource = dataSet.Tables["Subjects"];
            connection.CloseConnection();
        }

        public void AddSubject()
        {
            try
            {
                string datePattern = @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)";

                this.SubjectID = Convert.ToInt32(studentForm.SubjectIDtextBox.Text);
                this.Difficult = studentForm.DifficulttextBox.Text;
                this.PrepareTime = studentForm.PreparetimetextBox.Text;
                this.ExamDate = studentForm.ExamDatetextBox.Text;
                this.Material = studentForm.MaterialTextBox.Text;
                this.AddMaterial = studentForm.AddMaterialTextBox.Text;

                if (Regex.IsMatch(this.ExamDate, datePattern, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        connection.OpenConnection();
                        string sqlQuery = "insert into Exam(studentID, subjectID, examdate, preparetime, difficult, material, addmaterial)" +
                                           "values(@studentid, @subjectid, @examdate, @preparetime, @difficult, @material, @addmaterial);\n";
                        command.Parameters.Add("@studentid", SqlDbType.Int).Value = this.ID;
                        command.Parameters.Add("@subjectid", SqlDbType.Int).Value = this.SubjectID;
                        command.Parameters.Add("@examdate", SqlDbType.Date).Value = this.ExamDate;
                        command.Parameters.Add("@preparetime", SqlDbType.VarChar).Value = this.PrepareTime;
                        command.Parameters.Add("@difficult", SqlDbType.Int).Value = this.Difficult;
                        command.Parameters.Add("@material", SqlDbType.VarChar).Value = this.Material;
                        command.Parameters.Add("@addmaterial", SqlDbType.VarChar).Value = this.AddMaterial;
                        command.Connection = connection.GetConnection();
                        command.CommandText = sqlQuery;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Exam was succesful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        command.Parameters.Clear();
                        connection.CloseConnection();

                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("You enter the existing ID or incorrect typeId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        command.Parameters.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                }

            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }
        }
        public void ShowExams()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select Exam.ID, Subjects.subname, Exam.examdate, Exam.preparetime, Exam.difficult, Exam.material, Exam.addmaterial " +
                              "from Subjects inner join Exam on Subjects.ID = Exam.subjectID " +
                              "and Exam.studentID = " + student.ID + ";";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Exam");
            studentForm.dataGridViewExam.DataSource = dataSet.Tables["Exam"];
            connection.CloseConnection();
        }

        public void ShowExamsByDifficult()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select Exam.ID, Subjects.subname, Exam.examdate, Exam.preparetime, Exam.difficult, Exam.material, Exam.addmaterial " +
                              "from Subjects inner join Exam on Subjects.ID = Exam.subjectID " +
                              "and Exam.studentID = " + student.ID + " order by Exam.difficult desc;";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Exam");
            studentForm.dataGridViewExam.DataSource = dataSet.Tables["Exam"];
            connection.CloseConnection();
        }
        public void ShowExamsByDate()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select Exam.ID, Subjects.subname, Exam.examdate, Exam.preparetime, Exam.difficult, Exam.material, Exam.addmaterial " +
                              "from Subjects inner join Exam on Subjects.ID = Exam.subjectID " +
                              "and Exam.studentID = " + student.ID + " order by Exam.examdate asc;";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Exam");
            studentForm.dataGridViewExam.DataSource = dataSet.Tables["Exam"];
            connection.CloseConnection();
        }

        public void DeleteExam()
        {
            try
            {
                this.ExamID = Convert.ToInt32(studentForm.ExamIDtextBox.Text);
                try
                {
                    connection.OpenConnection();
                    string sqlQuery = "delete from Exam where ID = @ID;";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.ExamID;
                    command.Connection = connection.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Exam was successfuly deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void ShowPrepareTime()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select Exam.ID, Subjects.subname,  Exam.preparetime " +
                              "from Subjects inner join Exam on Subjects.ID = Exam.subjectID " +
                              "and Exam.studentID = " + student.ID + ";";
            adapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dataSet = new DataSet();
            connection.OpenConnection();
            adapter.Fill(dataSet, "Exam");
            studentForm.dataGridViewExam.DataSource = dataSet.Tables["Exam"];
            connection.CloseConnection();

        }
             
    }
}
