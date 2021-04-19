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
