namespace LSSEastProblemsDB
{
    public class Question
    {
        // This code is designed to contain data related to a prompt or question
        private string courseCode;
        private string topic;
        private string prompt;
        private string suggestions;
        private string answer;
        private bool completed;

        public Question() {}

        public Question(string courseCode, string topic, string prompt, string suggestions, string answer, bool completed)
        {
            Topic = topic;
            Prompt = prompt;
            Suggestions = suggestions;
            Answer = answer;
            CourseCode = courseCode;
            Completed = completed;
        }

        public string CourseCode {
            get { return courseCode; } set { courseCode = value; }
        }
        public string Topic {
            get { return topic; } set { topic = value; }
        }
        public string Prompt {
            get { return prompt; } set { prompt = value; }
        }
        public string Suggestions {
            get { return suggestions; } set { suggestions = value; }
        }
        public string Answer {
            get { return answer; } set { answer = value; }
        }
        public bool Completed {
            get { return completed; } set { completed = value; }
        }


        // Add code that constructs the display string for the listview control
        public string GetDisplayText()
        {
            return $"{topic}: {prompt}";
        }
    }
}
