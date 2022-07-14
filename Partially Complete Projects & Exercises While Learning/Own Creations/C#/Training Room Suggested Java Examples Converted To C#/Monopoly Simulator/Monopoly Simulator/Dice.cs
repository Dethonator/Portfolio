using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Dice
    {
        private readonly int _size;
        private readonly int _number;
        public Dice(int size, int number)
        {
            _size = size;
            _number = number;
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(_number, _size * _number + 1);
        }
    }
}
