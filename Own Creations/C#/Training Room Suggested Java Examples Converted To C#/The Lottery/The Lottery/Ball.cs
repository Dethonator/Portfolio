using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lottery
{
    public class Ball
    {
        public Ball(int number)
        {
            this.number = number;
        }
        private int number;
        public int Number
        {
            get { return number;}
            set { number = value; }
        }

        private bool alreadyPicked = false;

        public bool AlreadyPicked
        {
            get { return alreadyPicked; }
            set { alreadyPicked = value; }
        }
    }
}
