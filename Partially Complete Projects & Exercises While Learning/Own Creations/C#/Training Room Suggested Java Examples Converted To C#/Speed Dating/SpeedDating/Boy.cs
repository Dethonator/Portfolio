using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDating
{
    class Boy
    {
        public string Name { get; set; }

        public Boy(string name)
        {
            this.Name = name;
        }

        private readonly Random _random = new Random();

        public int Answer()
        {
            return _random.Next(1, 4);
        }
    }
}
