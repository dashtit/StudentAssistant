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
     
        private void DeanForm_Load(object sender, EventArgs e)
        {
         
        }

        private void ShowStudentsButton_Click(object sender, EventArgs e)
        {
            ShowStudentsForm showStudentsForm = new ShowStudentsForm();
            showStudentsForm.Show();
        }

        private void DeanAccForm_Click(object sender, EventArgs e)
        {

        }

        private void ShowSubjetcButton_Click(object sender, EventArgs e)
        {

        }
    }
}
