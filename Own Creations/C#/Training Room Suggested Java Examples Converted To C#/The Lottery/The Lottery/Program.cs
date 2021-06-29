using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace The_Lottery
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiation of balls and machine array
            Ball[] machine = new Ball[49];
            for (int i = 1; i <= 49; i++)
            {
                machine[i-1] = new Ball(i);
            }

            //Random number generator
            Random random = new Random();
            int RandomNumber(int min, int max)
            {
                return random.Next(min, max);
            }

            //Main program
            WriteLine("Welcome to the Lottery draw!\n");
            WriteLine("Please press any key to draw each number.\n");
            ReadKey();
            Ball ballOne = DrawNumber();
            Write(ballOne.Number + " ");
            ReadKey();
            Ball ballTwo = DrawNumber();
            Write(ballOne.Number + " " + ballTwo.Number + " ");
            ReadKey();
            Ball ballThree = DrawNumber();
            Write(ballOne.Number + " " + ballTwo.Number + " " + ballThree.Number + " ");
            ReadKey();
            Ball ballFour = DrawNumber();
            Write(ballOne.Number + " " + ballTwo.Number + " " + ballThree.Number + " " + ballFour.Number + " ");
            ReadKey();
            Ball ballFive = DrawNumber();
            Write(ballOne.Number + " " + ballTwo.Number + " " + ballThree.Number + " " + ballFour.Number + " " + ballFive.Number + " ");
            ReadKey();
            Ball ballSix = DrawNumber();
            Write(ballOne.Number + " " + ballTwo.Number + " " + ballThree.Number + " " + ballFour.Number + " " + ballFive.Number + " " + ballSix.Number + "\n\n");
            Write("The Bonus Ball is ");
            ReadKey();
            Ball bonusBall = DrawNumber();
            Write("The Bonus Ball is " + bonusBall.Number + "\n\n");
            WriteLine("Thank you for playing The Lottery! Have a lovely day.");
            ReadKey();
            //Draw number method
            Ball DrawNumber()
            {
                while (true)
                {
                    Ball thisBall = machine[RandomNumber(1, 49)];
                    if (thisBall.AlreadyPicked == false)
                    {
                        thisBall.AlreadyPicked = true;
                        return thisBall;
                    }
                }
            }
        }
    }
}
