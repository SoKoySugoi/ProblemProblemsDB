using System;
using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    public partial class frmNewQuestion : Form
    {
        public frmNewQuestion(string user, string courseCode = "")
        {
            InitializeComponent();
            loadSettings(user, courseCode);
        }

        // Add a statement here that declares the inventory item.
        private Problem question = null;

        private void loadSettings(string user, string courseCode)
        {
            // loads the course number text box
            txtCourseCode.Text = courseCode;

            // alters the form title if a topic exists
            if (txtTopic.Text == "") {
                this.Text = "Add New Question";
            }
            else {
                this.Text = "Update Question";
            }

            if (user == "Student")
            {
                // in student mode completed is assumed false and the suggestions label is changed to comments
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
            question = new Problem(txtCourseCode.Text, txtTopic.Text, 
                rtxPrompt.Text, rtxSuggetions.Text, rtxAnswer.Text, chkCompleted.Checked);
        }

        // returns the question object passed from the previous form with updated data
        public Problem UpdateNewItem(Problem question)
        {
            setData(question);
            saveQuestion();
            this.ShowDialog();
            return this.question;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (IsValidData())
            {
                // Add code here that creates a new item
                saveQuestion();
                // and closes the form.
                this.Close();
            }
        }

        private void setData(Problem question)
        {
            txtCourseCode.Text = question.CourseCode;
            txtTopic.Text = question.Topic;
            rtxPrompt.Text = question.Prompt;
            rtxSuggetions.Text = question.Suggestions;
            rtxAnswer.Text = question.Answer;
            chkCompleted.Checked = question.Completed;
        }

        //private bool IsValidData()
        //{
        //    return Validator.IsPresent(txtCourseCode) &&
        //           Validator.IsInt32(txtCourseCode) &&
        //           Validator.IsPresent(txtTopic) &&
        //           Validator.IsPresent(txtPrice) &&
        //           Validator.IsDecimal(txtPrice);
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
