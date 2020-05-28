using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Player
    {
        public string Name { get; }
        public Place CurrentPlace { get; set; }

        public Dictionary<string, bool> Inventory = new Dictionary<string, bool>();
        public Player(string name, Place _currentPlace)
        {
            Name = name;
            CurrentPlace = _currentPlace;
        }
    }
}
