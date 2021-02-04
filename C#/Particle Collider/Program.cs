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
            //Particle instantiation and population of Particles object
            #region
            Particles particles = new Particles();

            //Quarks
            particles.AddParticle(new UpQuark());
            particles.AddParticle(new DownQuark());
            particles.AddParticle(new CharmQuark());
            particles.AddParticle(new StrangeQuark());
            particles.AddParticle(new TopQuark());
            particles.AddParticle(new BottomQuark());

            //Leptons
            particles.AddParticle(new Electron());
            particles.AddParticle(new ElectronNeutrino());
            particles.AddParticle(new Muon());
            particles.AddParticle(new MuonNeutrino());
            particles.AddParticle(new Tauon());
            particles.AddParticle(new TauonNeutrino());

            //Antiquarks
            particles.AddParticle(new UpAntiquark());
            particles.AddParticle(new DownAntiquark());
            particles.AddParticle(new CharmAntiquark());
            particles.AddParticle(new StrangeAntiquark());
            particles.AddParticle(new TopAntiquark());
            particles.AddParticle(new BottomAntiquark());

            //Antileptons
            particles.AddParticle(new Positron());
            particles.AddParticle(new ElectronAntineutrino());
            particles.AddParticle(new Antimuon());
            particles.AddParticle(new MuonAntineutrino());
            particles.AddParticle(new Antitauon());
            particles.AddParticle(new Tauon());
            #endregion

            //Introductory message
            WriteLine("WELCOME TO THE SUBATOMIC PARTICLE COLLISION SIMULATOR\n");
            Write("This program performs a simulation that calculates the possible outcomes of a collision between two fundamental subatomic particles by using the laws of conservation of relevant subatomic properties. Please press any key to access the main menu.");
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
