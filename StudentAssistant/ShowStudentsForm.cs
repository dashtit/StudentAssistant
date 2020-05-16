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


    }
}
