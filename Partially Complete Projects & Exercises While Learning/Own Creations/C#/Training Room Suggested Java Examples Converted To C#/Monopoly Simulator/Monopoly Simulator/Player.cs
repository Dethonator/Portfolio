using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Player
    {
        //Name property
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        //Location property for position on game board
        private int _location = 0;
        public int Location
        {
            get => _location;
            set
            {
                _location = value;
                if (_location >= 40)
                {
                    _location -= 40;
                }
            }
        }

        //Jailed property
        private bool _inJail = false;
        public bool InJail
        {
            get => _inJail;
            set => _inJail = value;
        }

        //Money property
        private int _money = 1500;
        public int Money
        {
            get => _money;
            set
            {
                _money = value;
                if (_money < 0)
                {
                    _money = 0;
                }
            }
        }
    }
}
