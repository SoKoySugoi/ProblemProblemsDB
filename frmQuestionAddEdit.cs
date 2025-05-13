using System;
using static LSSEastProblemsDB.Validator;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmNewQuestion : Form
    {
        public frmNewQuestion(string user, string courseCode = "", string subject = "")
        {
            InitializeComponent();
            loadSettings(user, courseCode, subject);
        }

        // Add a statement here that declares the inventory item.
        private string subject = "";
        private Problem question = null;

        private void loadSettings(string user, string courseCode, string subject)
        {
            // loads the course number text box
            txtCourseCode.Text = courseCode;
            this.subject = subject;

            if (user == "Student")
            {
                // in student mode completed is assumed false
                // and the suggestions label is changed to comments
                chkCompleted.Visible = false;
                chkCompleted.Checked = false;
                lblSuggestions.Text = "Comments:";

                // shifts the suggestions label in line  
                var location = lblSuggestions.Location;
                location.X = 45;
                lblSuggestions.Location = location;
            }
        }

        // Returns a new question object to the previous form
        public Problem GetNewItem()
        {
            this.ShowDialog();
            return question;
        }

        private void saveQuestion()
        {
            // On save click, assigns the question property of the form the input data
            question = new Problem(this.subject, txtCourseCode.Text, txtTopic.Text, 
                txtPrompt.Text, txtSuggestions.Text, txtAnswer.Text, chkCompleted.Checked);
        }
        private void saveQuestion(Problem question)
        {
            // On save click, assigns the question property of the form the input data
            this.question = new Problem{
                ID = question.ID,
                Subject = question.Subject,
                CourseCode = txtCourseCode.Text, 
                Topic = txtTopic.Text,
                Prompt = txtPrompt.Text, 
                Suggestions = txtSuggestions.Text, 
                Answer = txtAnswer.Text, 
                Completed = chkCompleted.Checked };
        }

        // returns the question object passed from the previous form with updated data
        public Problem UpdateNewItem(Problem question)
        {
            this.Text = "Update Question";
            setData(question);
            this.ShowDialog();
            return this.question;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidQuestion() && IsValidData())
            {
                if(this.Text == "Update Question") {
                    saveQuestion(question);
                    MessageBox.Show(
                        "This question has been updated!", 
                        "Update Successful");
                }
                else {
                    // Add code here that creates a new item
                    saveQuestion();
                    MessageBox.Show(
                        "Your question has been successfully submitted for review!",
                        "Question Added");
                }

                // and closes the form.
                this.Close();
            }
        }

        private bool IsValidQuestion()
        {
            if(txtCourseCode.Text == "All" || subject == "All") {
                MessageBox.Show(
                    "Please log out and select a specific course.",
                    "Entry Error");
                return false;
            }
            return true;
        }

        private void setData(Problem question)
        {
            this.question = question;
            txtCourseCode.Text = question.CourseCode;
            txtTopic.Text = question.Topic;
            txtPrompt.Text = question.Prompt;
            txtSuggestions.Text = question.Suggestions;
            txtAnswer.Text = question.Answer;
            chkCompleted.Checked = question.Completed;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtTopic) &&
                   Validator.IsPresent(txtPrompt) &&
                   Validator.IsPresent(txtSuggestions) &&
                   Validator.IsPresent(txtAnswer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
