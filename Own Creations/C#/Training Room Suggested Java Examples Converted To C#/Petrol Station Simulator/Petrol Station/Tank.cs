using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station
{
    class Tank
    {
        private float _level;

        public float Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private float _capacity;
        public float Capacity
        {
            get { return _capacity;}
            set { _capacity = value; }
        }

        public Tank(float level, float capacity)
        {
            _level = level;
            _capacity = capacity;
        }
    }
}
