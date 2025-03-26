using System.Collections.Generic;

namespace ASMI.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }

        public List<int> depOptions { get; set; }

        public QuizQuestion()
        {
            Question = "intrebare";
            Options = new List<string> { "1", "2", "3", "4" };
        }

        public QuizQuestion(string question, List<string> options, List<int> depOptions)
        {
            Question = question;
            Options = options;
            this.depOptions = depOptions;
        }
    }
}
