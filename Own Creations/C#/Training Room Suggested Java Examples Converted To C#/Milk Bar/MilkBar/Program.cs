using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MilkBar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillGoing = true;
            double _1total = 0;
            WriteLine("Welcome to the Milk Bar!\n");
            while (stillGoing)
            {
                WriteLine($"Your bill is currently £" + _1total.ToString("N2") + "\n");
                WriteLine("Please choose a flavour of milkshake:\n");
                WriteLine("1 - Strawberry - £2.00");
                WriteLine("2 - Banana - £2.20");
                WriteLine("3 - Chocolate - £2.50 \n");
                WriteLine("0 - Pay the bill\n");
                WriteLine("Enter your choice here: ");
                int choice = InputValidator.GetInput();
                switch (choice)
                {
                    case 0:
                        stillGoing = false;
                        WriteLine($"\nThat'll be £" + _1total.ToString("N2") + " please. Press any key to settle up.");
                        ReadKey();
                        WriteLine("Thank you. Have a lovely day!");
                        ReadKey();
                        break;
                    case 1:
                        WriteLine("\nOne Strawberry milkshake coming up...\n");
                        _1total += 2;
                        break;
                    case 2:
                        WriteLine("\nOne Banana milkshake coming up...\n");
                        _1total += 2.2;
                        break;
                    case 3:
                        WriteLine(("\nOne Chocolate milkshake coming up...\n"));
                        _1total += 2.5;
                        break;
                    default:
                        WriteLine("That is not a number on our menu. Please try again.\n");
                        ReadKey();
                        break;
                }
            }
        }
    }
}
