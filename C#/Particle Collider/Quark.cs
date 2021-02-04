using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleCollider
{
    //Class for quarks
    public class Quark : Particle
    {
        public Quark()
        {
            
        }
        public Quark(string name){
            this.name = name;
            this.baryonNumber = 1 / 3;
            this.leptonElNumber = 0;
            this.leptonMuNumber = 0;
            this.leptonTauNumber = 0;
        }
    }
}
