using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class CharmAntiquark : Quark
    {
        public CharmAntiquark()
        {
            name = "Charm antiquark";
            symbol = "@c";
            mass = 1320;
            charge = -2 / 3;
            baryonNumber = -1 / 3;
        }
    }
}
