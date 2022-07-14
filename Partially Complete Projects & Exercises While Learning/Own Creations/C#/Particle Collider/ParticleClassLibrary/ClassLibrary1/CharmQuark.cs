using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class CharmQuark : Quark
    {
        public CharmQuark()
        {
            name = "Charm quark";
            symbol = "c";
            mass = 1320;
            charge = 2 / 3;
            charm = 1;
        }
    }
}
