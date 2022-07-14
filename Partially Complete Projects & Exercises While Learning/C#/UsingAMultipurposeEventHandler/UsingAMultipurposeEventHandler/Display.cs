using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UsingAMultipurposeEventHandler
{
    public class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            WriteLine($"Message arrived from: {((Connection)source).Name}");
            WriteLine($"Message Text: {e.Message}");
        }
    }
}
