using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DefiningEvents
{
    public class Display
    {
        public void DisplayMessage(string message) => WriteLine($"Message arrived: {message}");
    }
}
