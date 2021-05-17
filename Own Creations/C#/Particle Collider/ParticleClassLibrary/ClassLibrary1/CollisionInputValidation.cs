using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ParticleCollider
{
    class CollisionInputValidation
    {
        //Collision input validation method
        public static Particle InputValid(Particles particles)
        {
            string userChoice = null;
            Particle result = new Particle();
            bool valid = false;
            while (valid == false)
            {
                try
                {
                    userChoice = Convert.ToString(ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    WriteLine("Invalid input. Please try again.");
                    valid = false;
                    continue;
                }
                //Check that input matches existing particle
                foreach (Particle p in particles)
                {
                    if (userChoice.ToLower() == p.name.ToLower() || userChoice.ToLower() == p.symbol.ToLower())
                    {
                        valid = true;
                        result = p;
                        goto success;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                WriteLine("No matching particle found. Please try again.");
            }
            success:
            return result;
        }
    }
}
