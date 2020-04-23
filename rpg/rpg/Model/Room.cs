using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Room
    {
        public string Name { get; }
        public List<Room> TravelPsbl = new List<Room>();
        public Room(string name)
        {
            Name = name;
        }
        public void AddTravelPsbl(string Name)
        {
            TravelPsbl.Add(new Room(Name));
        }
    }
}
