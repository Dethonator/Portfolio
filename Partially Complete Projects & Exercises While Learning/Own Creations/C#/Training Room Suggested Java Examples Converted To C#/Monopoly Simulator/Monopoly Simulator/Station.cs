using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Monopoly_Simulator
{
    public class Station : Square
    {
        //Properties
        #region
        private new readonly string _name;

        public string Name => _name;
        private Player _ownedBy;
        public Player OwnedBy
        {
            get { return _ownedBy; }
            set { _ownedBy = value; }
        }
        private readonly int _price;

        public int Price => _price;
        #endregion

        //Constructor
        public Station(string name):base(name)
        {
            _name = name;
            _price = 200;
        }

        //Method for action when landed upon
        public override string Action(Player player)
        {
            if (_ownedBy != player)
            {
                WriteLine("Would you like to buy " + _name + " for " + "£" + _price + "? (Y/N)");
                string response = ReadLine().ToUpper();
                if (response == "Y" && player.Money >= _price)
                {
                    _ownedBy = player;
                    player.Money -= _price;
                    return "You now own " + _name.ToString();
                }
                else if (response == "Y" && player.Money < _price)
                {
                    WriteLine("Sorry but you don't have enough money at the moment.");
                }
            }
            return "";
        }
    }
}
