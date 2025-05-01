using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmListQuestions : Form
	{
		private string user = "";
		public frmListQuestions(string user)
		{
			InitializeComponent();
			this.user = user;
		}

		// Add a statement here that declares the list of items.
		private List <Question> questions = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
		{
			// Add a statement here that gets the list of items.
			if (user != "Tutor")
				btnUpdate.Visible = false;
            questions = QuestionsDB.GetItems();
			FillItemListBox();			
		}

		private void FillItemListBox()
		{
			lstQuestions.Items.Clear();
			// Add code here that loads the list box with the items in the list.
			foreach (Question question in questions) 
			{
				lstQuestions.Items.Add(question.GetDisplayText());				
			}
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            // Add code here that creates an instance of the New Item form
			frmNewQuestion NewItemForm = new frmNewQuestion();
			this.Hide();
			Question question = NewItemForm.GetNewItem();
			this.Show();

            // and then gets a new item from that form.
			if (question != null)
			{
                questions.Add(question);
				QuestionsDB.SaveItems(questions);
				FillItemListBox();
			}
        }

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstQuestions.SelectedIndex;
			if (i != -1)
			{
				// Add code here that displays a dialog box to confirm
				// the deletion and then removes the item from the list,
				// saves the list of products, and refreshes the list box
				// if the deletion is confirmed.

				Question item = questions[i];
				string message = "Are you sure you want to delete this question?";

				DialogResult button = 
					MessageBox.Show(message, "Confirm Delete", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (button == DialogResult.Yes)
				{
                    questions.Remove(item);
					QuestionsDB.SaveItems(questions);
					FillItemListBox();
				}
			}
		}


        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            int selected = lstQuestions.SelectedIndex;
			Question selectedQuestion = questions[selected]; 
			MessageBox.Show($"Prompt: {selectedQuestion.Prompt}\n\n" +
				$"Suggestions: {selectedQuestion.Suggestions}\n\n" +
				$"Answer: {selectedQuestion.Answer}", "Details");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selected = lstQuestions.SelectedIndex;
			if (selected != -1)
			{
                Question selectedQuestion = questions[selected];
                frmNewQuestion updateForm = new frmNewQuestion();
                this.Hide();
                selectedQuestion = updateForm.UpdateNewItem(selectedQuestion);
                questions[selected] = selectedQuestion;
                QuestionsDB.SaveItems(questions);
                FillItemListBox();
                this.Show();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}