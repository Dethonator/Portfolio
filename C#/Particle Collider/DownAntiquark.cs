using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class DownAntiquark : Quark
    {
        public DownAntiquark()
        {
            name = "Down antiquark";
            symbol = "@d";
            mass = 4.4;
            charge = 1 / 3;
            baryonNumber = -1 / 3;
        }
    }
}
