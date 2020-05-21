using RPG_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class Game
    {
        public List<Place> Places = new List<Place>();
        public Player player = new Player("player", 100, new Place("", ""));
        public void StartGame()
        {
            Places.Add(new Place("cesta", "Jsi na cestě, můžeš jít do blízkého města, nebo do temného lesa"));
            Places[0].AddTravelPsb(new Place("vesnice", ""));
            Places[0].AddTravelPsb(new Place("kraj temného lesu", ""));

            Places.Add(new Place("vesnice", "Jsi ve vesnici, můžeš jít k obchodníkovi, do hospody, nebo zpátky na cestu"));
            Places[1].AddTravelPsb(new Place("cesta", ""));
            Places[1].AddTravelPsb(new Place("obchodník", ""));
            Places[1].AddTravelPsb(new Place("hospoda", ""));

            Places.Add(new Place("kraj temného lesu", "Jsi na kraji temného lesa, je tu kámen s nápisem Xavier 1725-1749, můžeš pokračovat do lesa, nebo se vrátit na cestu"));
            Places[2].AddTravelPsb(new Place("temný les", ""));
            Places[2].AddTravelPsb(new Place("cesta", ""));

            player.SetPlace(Places[0]);
        }
    }
}
