using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class Muon : Lepton
    {
        public Muon()
        {
            name = "Muon";
            symbol = "m-";
            mass = 105.7;
            charge = -1;
            leptonMuNumber = 1;
        }
    }
}
