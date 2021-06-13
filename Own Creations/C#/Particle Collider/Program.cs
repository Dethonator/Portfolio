using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ParticleCollider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Particles object instantiation
            Particles particles = new Particles();

            //Introductory message
            WriteLine("WELCOME TO THE SUBATOMIC PARTICLE COLLISION SIMULATOR\n");
            Write("This program performs a simulation that predicts the possible outcomes of a collision between two fundamental subatomic particles by using the laws of conservation of relevant subatomic properties. Please press any key to access the main menu.");
            ReadKey();
            //Main menu
            #region
            //Loop to contain menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.MainMenu(particles);
            }
            #endregion
        }
    }
}
