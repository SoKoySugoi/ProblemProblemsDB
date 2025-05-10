using System;
using System.Collections.Generic;
using System.IO;

namespace LSSEastProblemsDB
{
    public static class ProblemsDB
    {
        // This code is meant to populate and update a text file to store data from the list of questions.
        private const string dir = @"..\..\Text_Files\";
        private const string path = dir + "Problems.txt";

        public static List<Problem> GetItems()
        {
            // create the list
            List<Problem> questions = new List<Problem>();

            // Add code here to read the text file into the List object.
            StreamReader txtFileReader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (!txtFileReader.EndOfStream)
            {
                string line = txtFileReader.ReadLine();
                string[] columns = line.Split('|');

                Problem question = new Problem();
                question.ID = Convert.ToInt32(columns[0]);
                question.CourseCode = columns[1];
                question.Topic = (columns[2]);
                question.Prompt = columns[3];
                question.Suggestions = columns[4];
                question.Answer = columns[5];
                question.Completed = Convert.ToBoolean(columns[6]);

                questions.Add(question);
            }                
            txtFileReader.Close();
            return questions;
        }

        public static void SaveItems(List<Problem> questions)
        {
            // Add code here to write the List object to the text file

            StreamWriter txtFileWriter = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Problem question in questions)
            {
                txtFileWriter.Write(question.ID + "|");
                txtFileWriter.Write(question.CourseCode + "|");
                txtFileWriter.Write(question.Topic + "|");
                txtFileWriter.Write(question.Prompt + "|");
                txtFileWriter.Write(question.Suggestions + "|");
                txtFileWriter.Write(question.Answer + "|");
                txtFileWriter.WriteLine(question.Completed);
            }
            txtFileWriter.Close();
        }
    }
}
