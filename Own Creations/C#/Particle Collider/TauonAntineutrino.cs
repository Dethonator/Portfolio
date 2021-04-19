using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class TauonAntineutrino : Lepton
    {
        public TauonAntineutrino()
        {
            name = "Tauon antineutrino";
            symbol = "@vt";
            mass = 0;
            charge = 0;
            leptonTauNumber = -1;
        }
    }
}
