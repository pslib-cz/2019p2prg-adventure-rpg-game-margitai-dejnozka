using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Player
    {
        public string Name { get; }
        public int DeathCount { get; set; }
        public Place CurrentPlace { get; set; }

        public List<String> Inventory = new List<String>();
        public Player(string name, Place _currentPlace)
        {
            Name = name;
            DeathCount = 0;
            CurrentPlace = _currentPlace;
        }
    }
}
