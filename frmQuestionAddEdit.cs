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
        private Question question = null;

        private void loadSettings(string user, string courseCode)
        {
            txtCourseCode.Text = courseCode;
            if (courseCode == "")
            {
                this.Text = "Add New Question";
            }
            else
            {
                this.Text = "Update Question";
            }
            if (user == "Student")
            {
                chkCompleted.Visible = false;
                chkCompleted.Checked = false;
            }
        }

        // Add a method here that gets and returns a new item.
        public Question GetNewItem()
        {
            this.ShowDialog();
            return question;
        }

        private void saveQuestion()
        {
            question = new Question(txtCourseCode.Text, txtTopic.Text, rtxPrompt.Text, rtxSuggetions.Text, rtxAnswer.Text, chkCompleted.Checked);
        }

        public Question UpdateNewItem(Question question)
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
        private void setData(Question question)
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
