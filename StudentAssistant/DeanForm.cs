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
    public partial class DeanForm : Form
    {
        public DeanForm()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;
        private void DeanForm_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True");
            connect.Open();
            connect.Close();
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
        {
            ShowStudentsForm showStudentsForm = new ShowStudentsForm();
            showStudentsForm.Show();
        }
    }
}
