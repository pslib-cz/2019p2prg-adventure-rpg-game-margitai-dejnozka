using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Room
    {
        public Room(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
