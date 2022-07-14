using System;
using static Monopoly_Simulator.Board;
using static System.Console;

namespace Monopoly_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation of player and dice
            Player player = new Player();
            Dice dice = new Dice(6, 2);

            //Game introduction and commencement
            WriteLine("Welcome to Monopoly!\n");
            WriteLine("Please enter your name: ");
            player.Name = ReadLine();
            WriteLine("\nGreetings " + player.Name + ".");
            WriteLine("\nYou start the game from the GO square. You have £1500 and two six-sided dice.");
            
            while (true)
            {
                int menuChoice;
                WriteLine("\nMoney: " + player.Money.ToString());
                WriteLine("\nPlease choose an option:\n");
                WriteLine("1 - Roll the dice\n2 - Build\n3 - Use a card\n4 - Exit Monopoly");
                try
                {
                    menuChoice = Convert.ToInt32(ReadLine());
                }
                catch (Exception)
                {
                    WriteLine("That is not a valid choice. Rolling the dice.");
                    menuChoice = 1;
                }

                switch (menuChoice)
                {
                    case 1:
                        int move = dice.Roll();
                        player.Location += move;
                        Square currentSquare = GameBoard[player.Location];
                        WriteLine("You have rolled " + move + " and landed on " + currentSquare._name + "\n");
                        WriteLine(currentSquare.Action(player));
                        break;
                    case 2:
                        WriteLine("Functionality awaiting completion");
                        break;
                    case 3:
                        WriteLine("Functionality awaiting completion");
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                        
                }
                WriteLine("\nPress any key to continue");
                ReadKey();
            }
        }
    }
}
