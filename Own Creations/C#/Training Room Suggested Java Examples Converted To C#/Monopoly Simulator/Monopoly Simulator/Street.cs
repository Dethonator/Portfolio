using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Monopoly_Simulator
{
    public class Street : Square
    {
        //Properties
        #region
        private new readonly string _name;
        public string Name => _name;
        private Player _ownedBy = null;
        public Player OwnedBy
        {
            get { return _ownedBy; }
            set { _ownedBy = value; }
        }
        private int _noOfHouses = 0;
        public int NoOfHouses
        {
            get
            {
                return _noOfHouses;
            }
            set
            {
                _noOfHouses = value;
            }
        }

        private readonly string _colour;
        public string Colour => _colour;

        private readonly int _streetPrice;

        public int StreetPrice => _streetPrice;

        private readonly int _housePrice;
        public int HousePrice => _housePrice;
        #endregion

        //Constructor
        public Street(string name):base(name)
        {
            _name = name;
            switch (name)
            {
                case "Old Kent Road":
                    _colour = "Brown";
                    _streetPrice = 60;
                    _housePrice = 30;
                    break;
                case "Whitechapel Road":
                    _colour = "Brown";
                    _streetPrice = 60;
                    _housePrice = 30;
                    break;
                case "The Angel Islington":
                    _colour = "Light Blue";
                    _streetPrice = 100;
                    _housePrice = 50;
                    break;
                case "Euston Road":
                    _colour = "Light Blue";
                    _streetPrice = 100;
                    _housePrice = 50;
                    break;
                case "Pentonville Road":
                    _colour = "Light Blue";
                    _streetPrice = 120;
                    _housePrice = 60;
                    break;
                case "Pall Mall":
                    _colour = "Pink";
                    _streetPrice = 140;
                    _housePrice = 70;
                    break;
                case "Whitehall":
                    _colour = "Pink";
                    _streetPrice = 140;
                    _housePrice = 70;
                    break;
                case "Northumberland Avenue":
                    _colour = "Pink";
                    _streetPrice = 160;
                    _housePrice = 80;
                    break;
                case "Bow Street":
                    _colour = "Orange";
                    _streetPrice = 180;
                    _housePrice = 90;
                    break;
                case "Marlborough Street":
                    _colour = "Orange";
                    _streetPrice = 180;
                    _housePrice = 90;
                    break;
                case "Vine Street":
                    _colour = "Orange";
                    _streetPrice = 200;
                    _housePrice = 100;
                    break;
                case "The Strand":
                    _colour = "Red";
                    _streetPrice = 220;
                    _housePrice = 110;
                    break;
                case "Fleet Street":
                    _colour = "Red";
                    _streetPrice = 220;
                    _housePrice = 110;
                    break;
                case "Trafalgar Square":
                    _colour = "Red";
                    _streetPrice = 240;
                    _housePrice = 120;
                    break;
                case "Leicester Square":
                    _colour = "Yellow";
                    _streetPrice = 260;
                    _housePrice = 130;
                    break;
                case "Coventry Street":
                    _colour = "Yellow";
                    _streetPrice = 260;
                    _housePrice = 130;
                    break;
                case "Piccadilly":
                    _colour = "Yellow";
                    _streetPrice = 280;
                    _housePrice = 140;
                    break;
                case "Regent Street":
                    _colour = "Green";
                    _streetPrice = 300;
                    _housePrice = 150;
                    break;
                case "Oxford Street":
                    _colour = "Green";
                    _streetPrice = 300;
                    _housePrice = 150;
                    break;
                case "Bond Street":
                    _colour = "Green";
                    _streetPrice = 320;
                    _housePrice = 160;
                    break;
                case "Park Lane":
                    _colour = "Dark Blue";
                    _streetPrice = 350;
                    _housePrice = 175;
                    break;
                case "Mayfair":
                    _colour = "Dark Blue";
                    _streetPrice = 400;
                    _housePrice = 200;
                    break;
            }
        }

        //Method for action when landed upon
        public override string Action(Player player)
        {
            if (_ownedBy != player)
            {
                WriteLine("Would you like to buy " + _name + "? (Y/N)");
                string response = Convert.ToString(ReadLine());
                if (response == "Y" && player.Money >= _streetPrice)
                {
                    _ownedBy = player;
                    player.Money -= _streetPrice;
                    return "You now own " + _name.ToString();
                }
                else if (response == "Y" && player.Money < _streetPrice)
                {
                    WriteLine("Sorry but you don't have enough money at the moment.");
                }
            }
            return "";
        }
    }
}
