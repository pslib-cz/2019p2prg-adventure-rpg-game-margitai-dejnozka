using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Place
    {
        public string Name { get; }
        public string Description { get; set; }
        public List<String> TravelPsb = new List<String>();
        public string Key { get; }

        public Place(string name, string description, string key)
        {
            Name = name;
            Description = description;
            Key = key;
        }
        public void AddTravelPsb(String placeName)
        {
            TravelPsb.Add(placeName);
        }
    }
}
