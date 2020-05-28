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
        }
        public void Travel(string placeName)
        {
            if(Story.Places[placeName].Key == "none")
            {
                Player.CurrentPlace = Story.Places[placeName];
            }
            //else todo
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
