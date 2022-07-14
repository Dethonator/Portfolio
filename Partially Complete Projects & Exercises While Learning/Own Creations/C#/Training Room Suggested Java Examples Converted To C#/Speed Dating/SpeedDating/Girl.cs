using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using static System.Console;

namespace SpeedDating
{
    class Girl
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        //Questions
        #region
        private static readonly string q1 = "What is your favourite sport?";
        private static readonly string[] a1 = { "Football", "Rugby", "Cricket", "Tennis" };
        private static readonly string q2 = "What is your favourite genre of tv/movie?";
        private static readonly string[] a2 = { "Sci-Fi/Fantasy", "Thriller", "Horror", "Romance" };
        private static readonly string q3 = "What do you like to drink?";
        private static readonly string[] a3 = { "Beer", "Cider", "Wine", "Spirits" };
        private static readonly string q4 = "Which is your favourite season?";
        private static readonly string[] a4 = { "Spring", "Summer", "Autumn", "Winter" };
        private static readonly string q5 = "Can you cook?";
        private static readonly string[] a5 = { "Yes", "No", "The books, yes", "It depends how sober I am" };
        private static readonly string q6 = "\"The needs of the many outweigh the needs of the few...?\"";
        private static readonly string[] a6 = { "Do they?", "...or the one", "As long as I'm in a good mood", "...and so frankly, my dear, I don't give a damn" };
        public static Question[] QuestionSet = {new Question(q1, a1), new Question(q2, a2), new Question(q3, a3), new Question(q4, a4), new Question(q5, a5), new Question(q6, a6)};
        #endregion
        //Questioning method - overridden by each girl (child) class
        public virtual int Encounter(Boy boy, string userName)
        {
            return new int();
        }
        //Method to score responses to questions 
        public int RateAnswer(int response, string name, Question q)
        {
            int score = 0;
            switch (name)
            {
                case "Sarah":
                    switch (q.QuestionText)
                    {
                        case "What is your favourite sport?":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                            }
                            break;
                        case "What is your favourite genre of tv/movie?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                                case 4:
                                    score--;
                                    break;
                            }
                            break;
                        case "What do you like to drink?":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                            }
                            break;
                        case "Which is your favourite season?":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                            }
                            break;
                        case "Can you cook?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                                case 2:
                                    score--;
                                    break;
                            }
                            break;
                        case "\"The needs of the many outweigh the needs of the few...?\"":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Petunia":
                    switch (q.QuestionText)
                    {
                        case "What is your favourite sport?":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                            }

                            break;
                        case "What is your favourite genre of tv/movie?":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                                case 3:
                                    score--;
                                    break;
                            }
                            break;
                        case "What do you like to drink?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                        case "Which is your favourite season?":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                                case 4:
                                    score--;
                                    break;
                            }
                            break;
                        case "Can you cook?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                                case 2:
                                    score--;
                                    break;
                            }
                            break;
                        case "\"The needs of the many outweigh the needs of the few...?\"":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Rosemary":
                    switch (q.QuestionText)
                    {
                        case "What is your favourite sport?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                            }
                            break;
                        case "What is your favourite genre of tv/movie?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                            }
                            break;
                        case "What do you like to drink?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                            }
                            break;
                        case "Which is your favourite season?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                            }
                            break;
                        case "Can you cook?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                                case 4:
                                    score++;
                                    break;
                            }
                            break;
                        case "\"The needs of the many outweigh the needs of the few...?\"":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                                case 3:
                                    score--;
                                    break;
                                case 4:
                                    score--;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Tabetha":
                    switch (q.QuestionText)
                    {
                        case "What is your favourite sport?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                                case 3:
                                    score--;
                                    break;
                                case 4:
                                    score--;
                                    break;
                            }
                            break;
                        case "What is your favourite genre of tv/movie?":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                                case 3:
                                    score--;
                                    break;
                            }
                            break;
                        case "What do you like to drink?":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                            }
                            break;
                        case "Which is your favourite season?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                        case "Can you cook?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                        case "\"The needs of the many outweigh the needs of the few...?\"":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                            }
                            break;
                    }
                    break;
                case "Fiona":
                    switch (q.QuestionText)
                    {
                        case "What is your favourite sport?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                        case "What is your favourite genre of tv/movie?":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                            }
                            break;
                        case "What do you like to drink?":
                            switch (response)
                            {
                                case 3:
                                    score++;
                                    break;
                            }
                            break;
                        case "Which is your favourite season?":
                            switch (response)
                            {
                                case 2:
                                    score++;
                                    break;
                                case 4:
                                    score--;
                                    break;
                            }
                            break;
                        case "Can you cook?":
                            switch (response)
                            {
                                case 1:
                                    score++;
                                    break;
                                case 2:
                                    score--;
                                    break;
                            }
                            break;
                        case "\"The needs of the many outweigh the needs of the few...?\"":
                            switch (response)
                            {
                                case 4:
                                    score++;
                                    break;
                                case 1:
                                    score--;
                                    break;
                            }
                            break;
                    }
                    break;
            }
            return score;
        }

        public CustomSortedList<int, Boy> Scores = new CustomSortedList<int, Boy>();
    }
}
