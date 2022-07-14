using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDating
{
    class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }

        public Question(string questionText, string[] answers)
        {
            this.QuestionText = questionText;
            this.Answers = answers;
        }
    }
}
