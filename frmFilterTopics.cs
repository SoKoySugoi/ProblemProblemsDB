using System;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmFilterTopics : Form
    {
        public frmFilterTopics(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        string user = "";

        private void frmFilterTopics_Load(object sender, EventArgs e)
        {
            string[]subjects = new Filter().Subjects;
            foreach (string subject in subjects) {
                cboSubject.Items.Add(subject);
            }
            cboSubject.SelectedIndex = 0;
            cboCourseNo.Items.Add("All");
            cboCourseNo.Enabled = false;
            cboCourseNo.SelectedIndex = 0;
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCourseNo.Enabled = true;
            getCourseNumbers(cboSubject.Text);
            if(cboCourseNo.Items.Count != 0) {
                cboCourseNo.SelectedIndex = 0;
            }
        }

        private void getCourseNumbers(string subject)
        {
            switch (subject)
            {
                case "Math":
                    cboCourseNo.Items.Clear();
                    string[] mathCourseCodes = new Filter().MathCourseCodes;
                    foreach (string course in mathCourseCodes) {
                        cboCourseNo.Items.Add(course);
                    }
                    break;
                case "Biology":
                    cboCourseNo.Items.Clear();
                    string[] bioCourseCodes = new Filter().BioCourseCodes;
                    foreach (string course in bioCourseCodes) {
                        cboCourseNo.Items.Add(course);
                    }
                    break;
                case "Chemistry":
                    cboCourseNo.Items.Clear();
                    string[] chemCourseCodes = new Filter().ChemCourseCodes;
                    foreach (string course in chemCourseCodes) {
                        cboCourseNo.Items.Add(course);
                    }
                    break;
                case "Physics":
                    cboCourseNo.Items.Clear();
                    string[] physicsCourseCodes = new Filter().PhysicsCourseCodes;
                    foreach (string course in physicsCourseCodes) {
                        cboCourseNo.Items.Add(course);
                    }
                    break;
                case "Computer Science":
                    cboCourseNo.Items.Clear();
                    string[] compSciCourseCodes = new Filter().CompSciCourseCodes;
                    foreach (string course in compSciCourseCodes) {
                        cboCourseNo.Items.Add(course);
                    }
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmListQuestions listView = new frmListQuestions(user, cboCourseNo.Text, cboSubject.Text);
            listView.Owner = this;
            this.Hide();
            listView.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            this.Hide();
            welcome.ShowDialog();
        }
    }
}
