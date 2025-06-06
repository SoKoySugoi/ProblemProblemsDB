using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmListQuestions : Form
	{
		private string user = "";
        private string courseCode = "";
        private string subject = "";
        private int counter = 0;

        public frmListQuestions(string user, string courseCode, string subject) {
			InitializeComponent();
			this.user = user;
            this.courseCode = courseCode;
            this.subject = subject;
        }

		// Add a statement here that declares the list of items.
		private List<Problem> masterList = null;

        private void frmListQuestions_Load(object sender, EventArgs e)
		{
			// Add a statement here that gets the list of items.
			if (user != "Tutor") {
                btnUpdate.Visible = false;
				btnDelete.Visible = false;
                chkCompleted.Visible = false;
            }
            lvProblems.Items.Clear();

            masterList = ProblemsDB.GetItems(); 

            FillListView();
            if (lvProblems.Items.Count == 0)
            {
                MessageBox.Show(
                    "Submit any question and we'll happily answer\n" +
                    "as soon as possible.", "No Questions Found");
            }
        }

		private void FillListView()
		{
            List<Problem> filteredList = (List<Problem>)FilterList();
            lvProblems.Items.Clear();
            int index = 0;

            // Add code here that loads the list box with the questions in the list
            // and assigns the tag property of each item to the object.
            foreach (Problem question in filteredList) {
				lvProblems.Items.Add(question.Topic);
                lvProblems.Items[index].SubItems.Add(question.Answer);
                lvProblems.Items[index].Tag = question;
                index++;
            }
        }

        private IEnumerable<Problem> FilterList()
        {
            IEnumerable<Problem> list = null;

            if (user != "Tutor") {
                if (courseCode != "All") {
                    list = masterList.FindAll(
                        q => q.CourseCode == courseCode && 
                        q.Completed == true);
                }
                else if (subject != "All") {
                    list = masterList.FindAll(
                        q => q.Subject == subject && 
                        q.Completed == true);
                }
                else {
                    list = masterList.FindAll(
                        q => q.Completed == true);
                }
            }
            else
            {
                if (courseCode != "All") {
                    list = masterList.FindAll(
                        q => q.CourseCode == courseCode);
                }
                else if (subject != "All") {
                    list = masterList.FindAll(
                        q => q.Subject == subject);
                }
                else {
                    list = masterList;
                }
            }
            return list;
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
			frmNewQuestion NewItemForm = new frmNewQuestion(user, courseCode, subject);
			this.Hide();

			Problem question = NewItemForm.GetNewItem();
			this.Show();

            // and then gets a new item from that form.
			if (question != null) {
                masterList.Add(question);
				ProblemsDB.SaveProblems(masterList);
                FillListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Add code here that displays a dialog box to confirm
            // the deletion and then removes the item from the list,
            // saves the list of products, and refreshes the list box
            // if the deletion is confirmed.

            Problem question = (Problem)lvProblems.FocusedItem.Tag;
            string message = "Are you sure you want to delete this question?";
            if (question != null) {
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (button == DialogResult.Yes) {
                    masterList.Remove(question);
                    ProblemsDB.SaveProblems(masterList);
                    FillListView();
                }
            }
        }

        private int GetSelectedIndex()
        {
            int selected = -1;
            if (lvProblems.SelectedItems.Count > 0) {
                selected = lvProblems.SelectedIndices[0];
            }
            return selected;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selected = GetSelectedIndex();
            if (selected != -1) {
                Problem selectedQuestion = (Problem)lvProblems.FocusedItem.Tag;
                frmNewQuestion updateForm = new frmNewQuestion(
                    user, selectedQuestion.CourseCode, selectedQuestion.Subject);

                this.Hide();
                selectedQuestion = updateForm.UpdateNewItem(selectedQuestion);
                UpdateQuestion(selectedQuestion);

                ProblemsDB.SaveProblems(masterList);
                FillListView();

                this.Show();
            }
            else {
                MessageBox.Show("Please select a question.");
            }
        }

        private void UpdateQuestion(Problem selectedQuestion)
        {
            int selectedId = selectedQuestion.ID;
            Problem question = masterList.Find(q => q.ID == selectedId);

            masterList.Remove(question);
            masterList.Add(selectedQuestion);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
			this.Owner.Owner.Close();
        }

        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            this.Hide();
            welcome.ShowDialog();
        }

        private void lvProblems_DoubleClick(object sender, EventArgs e)
        {
            Problem selectedQuestion = lvProblems.FocusedItem.Tag as Problem;
            MessageBox.Show($"Prompt: {selectedQuestion.Prompt}\n\n" +
                $"Suggestions: {selectedQuestion.Suggestions}\n\n" +
                $"Answer: {selectedQuestion.Answer}", "Details");
        }

        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        { ToggleCompleted(chkCompleted.Checked); }

        private void ToggleCompleted(bool @checked)
        {
            IEnumerable<Problem> list = null;
            if (courseCode != "All") {
                list = masterList.FindAll(
                    q => q.CourseCode == courseCode && 
                    q.Completed != @checked);
            }
            else if (subject != "All") {
                list = masterList.FindAll(
                    q => q.Subject == subject && 
                    q.Completed != @checked);
            }
            else {
                list = masterList.FindAll(
                    q => q.Completed != @checked);
            }
            FillListView(list as List<Problem>);
        }

        // Overload the FillListView Method to handle a completion check/toggle behavior.
        private void FillListView(List<Problem> filteredList)
        {
            lvProblems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            int index = 0;
            foreach (Problem question in filteredList)
            {
                lvProblems.Items.Add(question.Topic);
                lvProblems.Items[index].SubItems.Add(question.Answer);
                lvProblems.Items[index].Tag = question;
                index++;
            }
        }

        private void lblTopic_Click(object sender, EventArgs e)
        {
            if(user != "Student") {
                counter++;
            }
            if (counter == 7) {
                MessageBox.Show("Admin Tools stand in", "Admin Tools");
                counter = 0;
            }
        }
    }
}