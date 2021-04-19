using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class Antitauon : Lepton
    {
        public Antitauon()
        {
            name = "Antitauon";
            symbol = "t+";
            mass = 1780;
            charge = 1;
            leptonTauNumber = -1;
        }
    }
}
