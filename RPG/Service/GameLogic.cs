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
            Player.Inventory.Add("none", true);
        }
        public void Travel(string placeName)
        {
            foreach(KeyValuePair<string, bool> Entry in Player.Inventory)
            {
                if(Entry.Key == Story.Places[placeName].Key)
                {
                    Player.CurrentPlace = Story.Places[placeName];
                    if(Player.CurrentPlace.Name == "dul vozik")
                    {
                        Player.Inventory.Add("helma", true);
                    }
                    else if(Player.CurrentPlace.Name == "dul tmava mistnost")
                    {
                        Player.Inventory.Add("zlata nugetka", true);
                    }
                    else if (Player.CurrentPlace.Name == "tovarna obesenec")
                    {
                        Player.Inventory.Add("klic", true);
                    }
                    else if (Player.CurrentPlace.Name == "hory chaloupka")
                    {
                        Player.Inventory.Add("kanystr", true);
                    }
                    else if (Player.CurrentPlace.Name == "hory jeskyne")
                    {
                        Player.Inventory.Add("svitilna", true);
                    }
                    break;
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
