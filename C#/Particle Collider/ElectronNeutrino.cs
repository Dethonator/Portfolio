using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class ElectronNeutrino : Lepton
    {
        public ElectronNeutrino()
        {
            name = "Electron neutrino";
            symbol = "ve";
            mass = 0;
            charge = 0;
            leptonElNumber = 1;
        }
    }
}
