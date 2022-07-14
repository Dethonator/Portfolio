using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SpeedDating
{
    class Fiona : Girl
    {
        public Fiona()
        {
            this.Name = "Fiona";
            this.Description = "The girl before you is a well-made-up, long-haired brunette wearing a long blue dress";
        }
        public override int Encounter(Boy boy, string userName)
        {
            Random _random = new Random();
            int score = 0;
            List<int> QuestionNos = new List<int>(){1, 2, 3, 4, 5, 6};
            for(int i = 0; i < 3; i++)
            {
                Question q;
                while (true)
                {
                    int qNo = _random.Next(0, 5);
                    if (QuestionNos.Contains(qNo))
                    {
                        q = QuestionSet[qNo];
                        QuestionNos.Remove(qNo);
                        break;
                    }
                }
                int response;
                if (boy.Name == userName)
                {
                    if (i == 0)
                    {
                        WriteLine(Description + "\n");
                        WriteLine("Hi " + userName + ". I'm " + Name + " and I have some questions for you.\n");
                    }
                    WriteLine(q.QuestionText + "\n");
                    WriteLine("Please choose a response: ");
                    WriteLine("1. "+ q.Answers[0]);
                    WriteLine("2. "+ q.Answers[1]);
                    WriteLine("3. "+ q.Answers[2]);
                    WriteLine("4. "+ q.Answers[3] + "\n");
                    while (true)
                    {
                        try
                        {
                            response = Convert.ToInt32(ReadLine());
                            if (response >= 1 && response <= 4)
                                break;
                            else
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception)
                        {
                            WriteLine("That's not an answer! Pick one of the four I gave you!");
                        }
                    }
                }
                else
                {
                    response = boy.Answer();
                }

                score += RateAnswer(response, Name, q);
            }
            return score;
        }
    }
}
