using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class TopQuark : Quark
    {
        public TopQuark()
        {
            name = "Top quark";
            symbol = "t";
            mass = 172700;
            charge = 2 / 3;
            topness = 1;
        }
    }
}
