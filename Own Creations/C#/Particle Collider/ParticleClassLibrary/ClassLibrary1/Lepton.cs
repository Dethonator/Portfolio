using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleCollider
{
    //Class for leptons
    public class Lepton : Particle
    {
        public Lepton()
        {

        }
        public Lepton(string name) {
            this.name = name;
            this.baryonNumber = 0;
            this.charm = 0;
            this.strangeness = 0;
            this.topness = 0;
            this.bottomness = 0;
        }
    }
}
