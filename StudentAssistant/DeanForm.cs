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

        public Admin admin;
        public void SetAdmin(Admin someAdmim)
        {
            admin = someAdmim;
        }
        public DeanForm()
        {
            InitializeComponent();
        }
     
        private void DeanForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
        {
            admin.ShowStudents();
        }

        private void DeanAccForm_Click(object sender, EventArgs e)
        {

        }

        private void ShowSubjetcButton_Click(object sender, EventArgs e)
        {
            admin.ShowSubjects();
        }

        internal void Show(Admin admin)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignInlogindeantextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            admin.AddSubject();
        }

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            admin.DeleteSubject(); 
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            admin.DeleteStudent();
        }
        private void DeanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
