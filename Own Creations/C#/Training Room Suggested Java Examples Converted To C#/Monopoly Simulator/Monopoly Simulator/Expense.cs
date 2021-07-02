using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Expense : Square
    {
        //Properties
        private new readonly string _name;
        public string Name => _name;

        //Constructor
        public Expense(string name):base(name)
        {
            _name = name;
        }

        //Method for action when landed upon
        public override string Action(Player player)
        {
            switch (_name)
            {
                case "Income Tax":
                    player.Money -= 200;
                    break;
                case "Electric Company":
                    player.Money -= 150;
                    break;
                case "Water Works":
                    player.Money -= 150;
                    break;
                case "Super Tax":
                    player.Money -= 100;
                    break;
            }
            return "Holding;";
        }
    }
}
