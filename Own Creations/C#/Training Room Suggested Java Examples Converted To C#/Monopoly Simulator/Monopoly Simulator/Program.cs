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
            WriteLine("\nGreetings " + player.Name);
            WriteLine("\nYou start the game from the GO square. You have £1500 and two six-sided dice.");
            
            while (true)
            {
                WriteLine("Money: " + player.Money.ToString());
                WriteLine("\nPlease press any key to roll the dice.\n");
                ReadKey();
                int move = dice.Roll();
                player.Location += move;
                Square currentSquare = GameBoard[player.Location];
                WriteLine("You have rolled " + move + " and landed on " + currentSquare._name + "\n");
                WriteLine(currentSquare.Action(player));
            }
        }
    }
}
