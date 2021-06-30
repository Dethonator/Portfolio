using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class CommunityChest : Square
    {
        private new string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public CommunityChest(string name):base(name)
        {
            _name = name;
        }
    }
}
