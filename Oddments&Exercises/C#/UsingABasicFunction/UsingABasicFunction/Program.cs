using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsingABasicFunction
{
    class Program
    {
        static void Write()
        {
            WriteLine("Text output from function.");
        }
        static void Main(string[] args)
        {
            Write();
            ReadKey();
        }
    }
}
