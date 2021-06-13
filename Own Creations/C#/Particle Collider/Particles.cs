using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleCollider
{
    public class Particles : IEnumerable<Particle>
    {
        private IList<Particle> _particleList;
        public Particles()
        {
            _particleList = new List<Particle>();
            
            //Instantiation of Particle objects
            #region
            //Quarks
            AddParticle(new UpQuark());
            AddParticle(new DownQuark());
            AddParticle(new CharmQuark());
            AddParticle(new StrangeQuark());
            AddParticle(new TopQuark());
            AddParticle(new BottomQuark());

            //Leptons
            AddParticle(new Electron());
            AddParticle(new ElectronNeutrino());
            AddParticle(new Muon());
            AddParticle(new MuonNeutrino());
            AddParticle(new Tauon());
            AddParticle(new TauonNeutrino());

            //Antiquarks
            AddParticle(new UpAntiquark());
            AddParticle(new DownAntiquark());
            AddParticle(new CharmAntiquark());
            AddParticle(new StrangeAntiquark());
            AddParticle(new TopAntiquark());
            AddParticle(new BottomAntiquark());

            //Antileptons
            AddParticle(new Positron());
            AddParticle(new ElectronAntineutrino());
            AddParticle(new Antimuon());
            AddParticle(new MuonAntineutrino());
            AddParticle(new Antitauon());
            AddParticle(new Tauon());
            #endregion
        }

        public void AddParticle(Particle particle)
        {
            _particleList.Add(particle);
        }

        public IEnumerator<Particle> GetEnumerator()
        {
            foreach(Particle particle in _particleList)
            {
                yield return particle;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }    
}
