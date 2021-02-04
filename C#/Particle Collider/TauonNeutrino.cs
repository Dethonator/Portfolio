using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class TauonNeutrino : Lepton
    {
        public TauonNeutrino()
        {
            name = "Tauon neutrino";
            symbol = "vt";
            mass = 0;
            charge = 0;
            leptonTauNumber = 1;
        }
    }
}
