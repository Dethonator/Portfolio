using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class StrangeAntiquark : Quark
    {
        public StrangeAntiquark()
        {
            name = "Strange antiquark";
            symbol = "@s";
            mass = 87;
            charge = 1 / 3;
            strangeness = 1;
            baryonNumber = -1 / 3;
        }
    }
}
