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
            frmFilterTopics listView = new frmFilterTopics(btnStudent.Text);
            openListViewForm(listView);
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            // add code that passes the tutor role to a new List View Form
            frmFilterTopics listView = new frmFilterTopics(btnTutor.Text);
            openListViewForm(listView);
        }

        private void openListViewForm(frmFilterTopics form)
        {
            //add code that sets the behavior of the dialog exchange
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }
    }
}
