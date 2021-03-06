﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Simulator
{
    public class CommunityChest : Square
    {
        //Properties
        private new readonly string _name;
        public string Name => _name;

        //Constructor
        public CommunityChest(string name):base(name)
        {
            _name = name;
        }

        //Method for action when landed upon
        public override string Action(Player player)
        {
            return "The Community Chest cards are waiting to be printed but please do enjoy the rest of the game!";
        }
    }
}
