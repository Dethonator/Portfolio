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
                    return "You are charged £200";
                case "Electric Company":
                    player.Money -= 150;
                    return "You are charged £150";
                case "Water Works":
                    player.Money -= 150;
                    return "You are charged £150";
                case "Super Tax":
                    player.Money -= 100;
                    return "You are charged £100";
                default:
                    return null;
            }
        }
    }
}
