using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class Tauon : Lepton
    {
        public Tauon()
        {
            name = "Tauon";
            symbol = "t-";
            mass = 1780;
            charge = -1;
            leptonTauNumber = 1;
        }
    }
}
