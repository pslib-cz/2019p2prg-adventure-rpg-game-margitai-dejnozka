using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Player
    {
        public int HP { get; set; }
        public int Gold { get; set; }
        public Room CurrentRoom { get; set; }
        public List<Item> Inventory = new List<Item>();

        public Player(int hp, Room currentRoom, int gold = 0)
        {
            HP = hp;
            CurrentRoom = currentRoom;
            Gold = gold;
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
        public void Travel(Room travelTo)
        {
            foreach(Room room in CurrentRoom.TravelPsbl)
            {
                if(travelTo.Name == room.Name)
                {
                    CurrentRoom = room;
                    break;
                }
            }
        }
    }
}
