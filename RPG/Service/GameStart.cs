using RPG.Models;
using RPG.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class GameStart
    {
        public List<Place> Places = new List<Place>();
        public Player player = new Player("player", 100, new Place("", ""));
        public GameStart()
        {


            player.SetPlace(Places[0]);
        }
    }
}
