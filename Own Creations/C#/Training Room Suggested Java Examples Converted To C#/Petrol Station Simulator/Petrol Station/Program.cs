using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Petrol_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank reservoir = new Tank(300, 300);
            Tank car = new Tank(0, 50);
            WriteLine("Welcome to the petrol station. You currently have " + car.Level + " litres of fuel in your car.\n");
            WriteLine("Please press any key to fill up");
            ReadKey();
            Clear();
            WriteLine("Car fuel level: " + car.Level + " litres.");
            WriteLine("Reservoir level: " + reservoir.Level + " litres.");
            while (true)
            {
                ReadKey();
                Clear();
                car.Level += (float)0.5;
                reservoir.Level -= (float)0.5;
                WriteLine("Car fuel level: " + car.Level + " litres.");
                WriteLine("Reservoir level: " + reservoir.Level + " litres.");
                if (car.Level == car.Capacity || reservoir.Level == 0)
                {
                    break;
                }
            }
            WriteLine("\nYour car is full. Have a nice day!");
            ReadKey();
        }
    }
}
