using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Player
    {
        public int HP { get; set; }
        public List<Item> Inventory = new List<Item>();

        public Player(int hP)
        {
            HP = hP;
        }
    }
}
