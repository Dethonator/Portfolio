using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class BottomQuark : Quark
    {
        public BottomQuark()
        {
            name = "Bottom quark";
            symbol = "b";
            mass = 4240;
            charge = -1 / 3;
            bottomness = -1;
        }
    }
}
