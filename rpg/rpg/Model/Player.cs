using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Player
    {
        public int HP { get; set; }
        public Room Location { get; set; }
        public List<Item> Inventory = new List<Item>();

        public Player(int hp, Room location)
        {
            HP = hp;
            Location = location;
        }
        public void AddItem(Item item)
        {
            Inventory.Add(item);
        }
        public Item TakeItem(string Name)
        {
            foreach(Item item in Inventory)
            {
                if(item.Name == Name)
                {
                    Inventory.Remove(item);
                    return item;
                }
            }
            return null;
        }
    }
}
