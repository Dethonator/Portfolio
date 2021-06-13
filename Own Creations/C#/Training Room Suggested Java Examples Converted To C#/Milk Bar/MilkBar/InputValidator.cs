using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MilkBar
{
    class InputValidator
    {
        public static int GetInput()
        {
            int output;
            while (true)
            {
                try
                {
                    output = Convert.ToInt32(ReadLine());
                    break;
                }
                catch (Exception)
                {
                    WriteLine("That is not a valid choice. Please try again");
                }
            }
            return output;
        }
    }
}
