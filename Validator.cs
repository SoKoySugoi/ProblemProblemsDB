using System.Windows.Forms;

namespace LSSEastProblemsDB
{
    // this static class contains generic validation methods for the form
    public static class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get { return title; }
			set { title = value; }
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsPresent(RichTextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
	}
}
