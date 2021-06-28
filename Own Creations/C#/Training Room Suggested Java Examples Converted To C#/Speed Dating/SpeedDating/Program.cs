using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SpeedDating
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation of groups
            #region
            Girls ladies = new Girls();
            Boys gents = new Boys();
            #endregion

            //Introduction and printing of names
            #region
            WriteLine("Welcome to Speed Dating!");
            WriteLine("\nToday we are joined by:\n");
            int gCount = 1;
            foreach (Girl g in ladies.girlGroup)
            {
                if (gCount < 4)
                {
                    Write(g.Name + ", ");
                }
                else if (gCount == 4)
                {
                    Write(g.Name + " and ");
                }
                else
                {
                    Write(g.Name + ".");
                }
                gCount++;
            }
            ReadKey();
            WriteLine("\n");
            WriteLine("What is your name please sir?");
            string userName = ReadLine();
            WriteLine("\nWelcome " + userName + ".\n");
            ReadKey();
            Boy[] boyGroup = gents.FormBoyGroup(userName);
            WriteLine("The gents taking part today are:\n");
            int bCount = 1;
            foreach (Boy b in boyGroup)
            {
                if (bCount < boyGroup.Length - 1)
                {
                    Write(b.Name + ", ");
                }
                else if (bCount == boyGroup.Length - 1)
                {
                    Write(b.Name + " and ");
                }
                else
                {
                    Write(b.Name + ".\n");
                }
                bCount++;
            }
            WriteLine();
            ReadKey();
            
            #endregion

            //Foreach loop for each girl to 'speed date' each boy
            foreach (Girl g in ladies.girlGroup)
            {
                foreach (Boy b in boyGroup)
                {
                    Clear();
                    g.Scores.Add(g.Encounter(b, userName), b);
                }
            }
            //Printing of results
            Clear();
            foreach (Girl g in ladies.girlGroup)
            {
                g.Scores.Sort();
                if (g.Scores[0].Item2.Name == userName)
                {
                    WriteLine("Congratulations " + userName + "! " + g.Name +
                              " would like to have another date with you!");
                }
                else
                {
                    WriteLine(g.Name + " would like to see " + g.Scores[0].Item2.Name + " for a second date.");
                }
                ReadKey();
            }

            //Farewell and end of program
            WriteLine("Thank you for taking part in Speed Dating! Have a lovely day!");
            ReadKey();
        }
    }
}
