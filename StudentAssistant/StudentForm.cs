using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAssistant
{
    public partial class StudentForm : Form
    {
        public User user;
        public void SetUser(User someUser)
        {
            user = someUser;
        }

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowSubjectsStudentButoon_Click(object sender, EventArgs e)
        {
            user.ShowSubjectsStudent();
        }

        private void SubjectIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowExamsButton_Click(object sender, EventArgs e)
        {
            user.ShowExams();
        }

        private void SortDifficultButton_Click(object sender, EventArgs e)
        {
            user.ShowExamsByDifficult();
        }

        private void AddExamButton_Click(object sender, EventArgs e)
        {
            user.AddSubject();
        }

        private void SortDateButton_Click(object sender, EventArgs e)
        {
            user.ShowExamsByDate();
        }

        private void DeleteExamButton_Click(object sender, EventArgs e)
        {
            user.DeleteExam();
        }

        private void PrepareTimeButton_Click(object sender, EventArgs e)
        {
            user.ShowPrepareTime();
        }
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
