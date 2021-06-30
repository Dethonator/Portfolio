using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Monopoly_Simulator.Board;

namespace Monopoly_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(6, 2);
            while (true)
            {
                WriteLine(dice.Roll());
                ReadKey();
            }
        }
    }
}
