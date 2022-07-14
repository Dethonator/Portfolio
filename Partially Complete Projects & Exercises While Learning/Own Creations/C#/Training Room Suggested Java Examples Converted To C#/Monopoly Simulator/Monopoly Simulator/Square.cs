using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Square
    {
        public readonly string _name;

        public Square(string name)
        {
            _name = name;
        }

        public virtual string Action(Player player)
        {
            return "Something's gone wrong!";
        }
    }
}
