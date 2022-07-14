using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ManipulatingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            double firstNumber, secondNumber;
            WriteLine("Enter your name:");
            userName = ReadLine();
            WriteLine($"Welcome {userName}!");
            WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            WriteLine($"The result of subtracting {secondNumber} from " + $"{firstNumber} is {firstNumber - secondNumber}.");
            WriteLine($"The product of {firstNumber} and {secondNumber} " + $"is {firstNumber * secondNumber}.");
            WriteLine($"The result of dividing {firstNumber} by " + $"{secondNumber} is {firstNumber / secondNumber}.");
            WriteLine($"The remainder after dividing {firstNumber} by " + $"{secondNumber} is {firstNumber % secondNumber}.");
            ReadKey();
        }
    }
}
