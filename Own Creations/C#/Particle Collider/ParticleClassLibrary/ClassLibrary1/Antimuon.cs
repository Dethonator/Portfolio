using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class Antimuon : Lepton
    {
        public Antimuon()
        {
            name = "Antimuon";
            symbol = "m+";
            mass = 105.7;
            charge = 1;
            leptonMuNumber = -1;
        }
    }
}
