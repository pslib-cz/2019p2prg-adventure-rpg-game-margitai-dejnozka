using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Models;
using RPG.Service;

namespace RPG.Service
{
    public class GameLogic
    {
        private readonly SessionStorage sessionStorage;
        public Story Story { get; set; }
        public Player Player { get; set; }
        public GameLogic(SessionStorage _sessionStorage)
        {
            sessionStorage = _sessionStorage;
            Travel("dul venku");
            AddToInv("none");
        }
        public void Travel(string placeName)
        {
            if (Player.Inventory == null)
            {
                Player.CurrentPlace = Story.Places[placeName];
            }
            else
            {
                foreach (KeyValuePair<string, bool> Entry in Player.Inventory)
                {
                    if (Entry.Key == Story.Places[placeName].Key)
                    {
                        Player.CurrentPlace = Story.Places[placeName];
                        if (Player.CurrentPlace.Name == "dul vozik")
                        {
                            AddToInv("helma");
                        }
                        else if (Player.CurrentPlace.Name == "dul tmava mistnost")
                        {
                            AddToInv("zlata nugetka");
                        }
                        else if (Player.CurrentPlace.Name == "tovarna obesenec")
                        {
                            AddToInv("klic");
                        }
                        else if (Player.CurrentPlace.Name == "hory chaloupka")
                        {
                            AddToInv("kanystr");
                        }
                        else if (Player.CurrentPlace.Name == "hory jeskyne")
                        {
                            AddToInv("svitilna");
                        }
                        break;
                    }
                }
            }
        }
        public void AddToInv(string item)
        {
            Player.Inventory.Add(item, true);
        }
        public void RmvFromInv(string item)
        {
            Player.Inventory.Remove(item);
        }
        public void ChangeDescription(string roomName,string description)
        {
            Story.Places[roomName].Description = description;
        }
    }
}
