﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsingTheSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "henry";
            const string niceName = "rowan";
            const string sillyName = "awooble";
            string name;
            WriteLine("What is your name?");
            name = ReadLine();
            switch(name.ToLower())
            {
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a very silly name.");
                    break;
            }
            WriteLine($"Hello {name}!");
            ReadKey();
        }
    }
}
