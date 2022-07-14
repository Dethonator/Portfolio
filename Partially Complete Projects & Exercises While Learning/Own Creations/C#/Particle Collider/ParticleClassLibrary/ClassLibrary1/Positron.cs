using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class Positron : Lepton
    {
        public Positron()
        {
            name = "Positron";
            symbol = "e+";
            mass = 0.511;
            charge = 1;
            leptonElNumber = -1;
        }
    }
}
