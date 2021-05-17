using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleCollider
{
    public class ElectronAntineutrino : Lepton
    {
        public ElectronAntineutrino()
        {
            name = "Electron antineutrino";
            symbol = "@ve";
            mass = 0;
            charge = 0;
            leptonElNumber = -1;
        }
    }
}
