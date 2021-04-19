using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class MuonNeutrino : Lepton
    {
        public MuonNeutrino()
        {
            name = "Muon neutrino";
            symbol = "vm";
            mass = 0;
            charge = 0;
            leptonMuNumber = 1;
        }
    }
}
