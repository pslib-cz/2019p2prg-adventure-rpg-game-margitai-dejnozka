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

        public Place(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void AddTravelPsb(String placeName)
        {
            TravelPsb.Add(placeName);
        }
        public void RmvTravelPsb(Place delPsb)
        {
            for (int i = 0; i < TravelPsb.Count; i++)
            {
                if (TravelPsb[i].Name == delPsb.Name)
                {
                    TravelPsb.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
