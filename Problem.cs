using System;

namespace LSSEastProblemsDB
{
    // Created a class object to contain data related to a prompt or question
    public class Problem
    {
        // This code is designed to contain data related to a prompt or question
        private int id;
        private string subject;
        private string courseCode;
        private string topic;
        private string prompt;
        private string suggestions;
        private string answer;
        private bool completed;

        public Problem() {}

        public Problem(
            string subject, string courseCode, string topic, string prompt, 
            string suggestions, string answer, bool completed) {
                // "G"enerate a "u"nique "ID" for the question
                id = Guid.NewGuid().GetHashCode();
                Subject = subject;
                Topic = topic;
                Prompt = prompt;
                Suggestions = suggestions;
                Answer = answer;
                CourseCode = courseCode;
                Completed = completed;
        }

        public int ID { 
            get { return id; } set { id = value; }
        }
        public string Subject {
            get { return subject; } set { subject = value; }
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

        // Add code that returns display string for the listview control
        public string GetDisplayText()
        {
            return $"{topic}";
        }
    }
}
