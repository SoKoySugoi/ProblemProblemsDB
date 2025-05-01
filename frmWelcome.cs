using System;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            // add code that passes the student role to a new List View Form
            frmListQuestions listView = new frmListQuestions(btnStudent.Text);
            this.Hide();
            listView.ShowDialog();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            // add code that passes the tutor role to a new List View Form
            frmListQuestions listView = new frmListQuestions(btnTutor.Text);
            this.Hide();
            listView.ShowDialog();
        }
    }
}
