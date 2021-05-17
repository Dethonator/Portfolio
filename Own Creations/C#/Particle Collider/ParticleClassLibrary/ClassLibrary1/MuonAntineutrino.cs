using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class MuonAntineutrino : Lepton
    {
        public MuonAntineutrino()
        {
            name = "Muon antineutrino";
            symbol = "@vm";
            mass = 0;
            charge = 0;
            leptonMuNumber = -1;
        }
    }
}
