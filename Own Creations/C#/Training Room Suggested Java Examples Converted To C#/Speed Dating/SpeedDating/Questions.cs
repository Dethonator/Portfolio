using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDating
{
    class Questions
    {
        private static readonly string q1 = "What is your favourite sport?";
        private static readonly string[] a1 = { "Football", "Rugby", "Cricket", "Tennis" };
        private static readonly string q2 = "What is your favourite genre of tv/movie?";
        private static readonly string[] a2 = { "Sci-Fi/Fantasy", "Thriller", "Horror", "Romance" };
        private static readonly string q3 = "What do you like to drink?";
        private static readonly string[] a3 = { "Beer", "Cider", "Wine", "Spirits" };
        public Question[] questionSet = {new Question(q1, a1), new Question(q2, a2), new Question(q3, a3)};
    }
}
