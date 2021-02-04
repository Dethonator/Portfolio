using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ParticleCollider
{
    class CollisionMenu : Menu
    {
        //Particle choice method
        public static void Collision(Particles particles)
        {
            Clear();
            WriteLine("\n" + "PARTICLE COLLISION SIMULATION" + "\n");

            //Assignment of first particle
            #region
            WriteLine("Please specify a particle using its full name or symbol as shown in the particles list (on the main menu): ");
            Particle particleOne = userInput(particles);
            #endregion

            //Assignment of second particle
            #region
            WriteLine("Please specify a second particle using its full name or symbol as shown in the list (on the main menu): ");
            Particle particleTwo = userInput(particles);
            #endregion

            WriteLine("Press any key to simulate your chosen collision between " + particleOne.name + " and " + particleTwo.name);
            ReadKey();

            //CollideWith method call
            particleOne.CollideWith(particleTwo, particles);
        }

        //User particle input method
        public static Particle userInput(Particles particles)
        {
            Particle pChoice = CollisionInputValidation.InputValid(particles);
            WriteLine("You have successfully selected " + pChoice.name + "\n");
            return pChoice;
        }
    }
}
