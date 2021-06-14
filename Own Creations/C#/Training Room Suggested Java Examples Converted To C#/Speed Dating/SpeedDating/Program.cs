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
            Girls ladies = new Girls();
            Boys gents = new Boys();

            //Introduction and printing of names
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
            WriteLine("Four gents other than yourself are taking part today:\n");
            int bCount = 1;
            foreach (Boy b in gents.boyGroup)
            {
                if (bCount < 3)
                {
                    Write(b.Name + ", ");
                }
                else if (bCount == 3)
                {
                    Write(b.Name + " and ");
                }
                else
                {
                    Write(b.Name + ".\n");
                }
                bCount++;
            }
            ReadKey();
            WriteLine("\nWhat is your name please sir?");
            string userName = ReadLine();
            WriteLine("\nWelcome " + userName + ".");
            ReadKey();
        }
    }
}
