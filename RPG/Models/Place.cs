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
        public List<Place> TravelPsb = new List<Place>();

        public Place(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void AddTravelPsb(Place newPsb)
        {
            TravelPsb.Add(newPsb);
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
