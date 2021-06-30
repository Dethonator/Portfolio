using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Player
    {
        private int location = 0;
        public int Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
    }
}
