using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleCollider
{
    public class ParticleEnum:IEnumerator
    {
        public Particle[] particles;
        
        int position = -1;

        public ParticleEnum(Particle[] list)
        {
            particles = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < particles.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

    public Particle Current
        {
            get
            {
                try
                {
                    return particles[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
