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
    public partial class ShowStudentsForm : Form
    {
        public ShowStudentsForm()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommandBuilder commandBuilder;
         
        private void ShowStudentsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void showstudentsbutton_Click(object sender, EventArgs e)
        {
            string _university = chooseuniversitydeantextBox.Text;
            string _faculty = choosefacultydeantextBox.Text;
            string sqlConnectionString = @"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True";
            connect = new SqlConnection(sqlConnectionString);
            string sqlQuery = "select name, surname, login, course from Students where university = \'" + _university + "\' and faculty = \'" + _faculty + "\';";

            adapter = new SqlDataAdapter(sqlQuery, connect);
          
            ds = new DataSet();
        
            connect.Open();
            adapter.Fill(ds, "Students");
            dataGridViewStudents.DataSource = ds.Tables["Students"];
            connect.Close();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                dataGridViewStudents.Rows.Remove(row);
            }
        }

        private void SaveStudentsButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Students";
            connect.Open();
            adapter = new SqlDataAdapter(sql, connect);
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 15, "name"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.VarChar, 25, "surname"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.VarChar, 20, "login"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 20, "password"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@university", SqlDbType.VarChar, 10, "university"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@faculty", SqlDbType.VarChar, 10, "faculty"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@course", SqlDbType.VarChar, 5, "course"));

            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            parameter.Direction = ParameterDirection.Output;

            adapter.Update(ds);
        }
    }
}
