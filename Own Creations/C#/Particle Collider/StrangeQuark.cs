using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class StrangeQuark : Quark
    {
        public StrangeQuark()
        {
            name = "Strange quark";
            symbol = "s";
            mass = 87;
            charge = -1 / 3;
            strangeness = -1;
        }
    }
}
