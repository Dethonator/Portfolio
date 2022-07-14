using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class UpAntiquark : Quark
    {
        public UpAntiquark()
        {
            name = "Up antiquark";
            symbol = "@u";
            mass = 1.9;
            charge = -2 / 3;
            baryonNumber = -1 / 3;
        }
    }
}
