using Microsoft.AspNetCore.Http;
using rpg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Service
{
    public class Logic
    {
        readonly ISession _session;
        public List<Room> Rooms = new List<Room>();
        public Logic(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        public void StartGame()
        {
            Rooms.Add(new Room("Hlavní cesta"));
            Rooms[0].AddTravelPsbl("Obchod");
            Rooms[0].AddTravelPsbl("Hospoda");

            Rooms.Add(new Room("Obchod"));
            Rooms[1].AddTravelPsbl("Hlavní cesta");

            Rooms.Add(new Room("Hospoda"));
            Rooms[2].AddTravelPsbl("Hlavní cesta");
        }
    }
}
