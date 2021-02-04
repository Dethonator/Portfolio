using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ParticleCollider
{
    public class Menu
    {
        //Main menu method
        public static bool MainMenu(Particles particles)
        {
            Clear();
            WriteLine("\n" + "MAIN MENU" + "\n");
            WriteLine("1. New collision");
            WriteLine("2. View list of available fundamental particles");
            WriteLine("3. Exit" + "\n");
            WriteLine("Please choose an option: ");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                WriteLine("Invalid input. Please try again.");
                ReadKey();
            }
            
            switch (choice)
            {
                case 1:
                    CollisionMenu.Collision(particles);
                    return true;

                case 2:
                    //Display of particles to user
                    WriteLine("AVAILABLE PARTICLES" + "\n");
                    ParticleList(particles);
                    return true;

                case 3:
                    return false;

                default:
                    WriteLine("Invalid choice. Please try again.");
                    return true;
            }
        }
        
        //Particle list method
        public static void ParticleList(Particles particles)
        {
            Clear();
            foreach (Particle p in particles)
            {
                WriteLine(p.symbol + "   " + p.name);
            }
            WriteLine("\n" + "Press any key to return to the main menu");
            ReadKey();
        }
    }
}
