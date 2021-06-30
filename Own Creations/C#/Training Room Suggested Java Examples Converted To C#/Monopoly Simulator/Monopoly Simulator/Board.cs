using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class Board
    {
        public static Square[] GameBoard = {new Corner("Go"), 
                                            new Street("Old Kent Road"),
                                            new CommunityChest("Community Chest"),
                                            new Street("Whitechapel Road"),
                                            new Expense("Income Tax"),
                                            new Station("Kings Cross Station"),
                                            new Street("The Angel Islington"),
                                            new Chance("Chance"),
                                            new Street("Euston Road"),
                                            new Street("Pentonville Road"),
                                            new Corner("Jail"),
                                            new Street("Pall Mall"),
                                            new Expense("Electric Company"),
                                            new Street("Whitehall"),
                                            new Street("Northumberland Avenue"),
                                            new Station("Marylebone Station"),
                                            new Street("Bow Street"),
                                            new CommunityChest("Community Chest"),
                                            new Street("Marlborough Street"),
                                            new Street("Vine Street"),
                                            new Corner("Free Parking"),
                                            new Street("The Strand"),
                                            new Chance("Community Chest"),
                                            new Street("Fleet Street"),
                                            new Street("Trafalgar Square"),
                                            new Station("Fenchurch St Station"),
                                            new Street("Leicester Square"),
                                            new Street("Coventry Street"),
                                            new Expense("Water Works"),
                                            new Street("Piccadilly"),
                                            new Corner("Go To Jail"),
                                            new Street("Regent Street"),
                                            new Street("Oxford Street"),
                                            new CommunityChest("Community Chest"),
                                            new Street("Bond Street"),
                                            new Station("Liverpool St Station"),
                                            new Chance("Chance"),
                                            new Street("Park Lane"),
                                            new Expense("Super Tax"),
                                            new Street("Mayfair")
                                            };
    }
}
