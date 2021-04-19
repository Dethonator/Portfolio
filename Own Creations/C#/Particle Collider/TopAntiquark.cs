using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class TopAntiquark : Quark
    {
        public TopAntiquark()
        {
            name = "Top antiquark";
            symbol = "@t";
            mass = 172700;
            charge = -2 / 3;
            topness = -1;
            baryonNumber = -1 / 3;
        }
    }
}
