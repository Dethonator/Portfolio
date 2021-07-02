using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Monopoly_Simulator
{
    public class Corner : Square
    {
        //Properties
        private new readonly string _name;
        public string Name => _name;

        //Constructor
        public Corner(string name):base(name)
        {
            _name = name;
        }

        //Method for action when landed upon
        public override string Action(Player player)
        {
            switch (_name)
            {
                case "Go":
                    player.Money += 200;
                    break;
                case "Jail":
                    WriteLine("Just visiting");
                    break;
                case "Free Parking":
                    break;
                case "Go To Jail":
                    player.Location = 10;
                    player.InJail = true;
                    break;
            }
            return "Holding;";
        }
    }
}
