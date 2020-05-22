using RPG.Models;
using RPG.Service;
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
        //private readonly SessionStorage sessionStorage;
        public Game(/*SessionStorage _sessionStorage*/)
        {
            //sessionStorage = _sessionStorage;

            Places.Add(new Place("cesta", "Jsi na cestě, můžeš jít do blízkého města, nebo do temného lesa"));
            Places[0].AddTravelPsb(new Place("vesnice", ""));
            Places[0].AddTravelPsb(new Place("temný les", ""));

            Places.Add(new Place("vesnice", "Jsi ve vesnici, můžeš jít k obchodníkovi, do hospody, nebo zpátky na cestu"));
            Places[1].AddTravelPsb(new Place("cesta", ""));
            Places[1].AddTravelPsb(new Place("obchodník", ""));
            Places[1].AddTravelPsb(new Place("hospoda", ""));

            Places.Add(new Place("temný les", "Jsi na kraji temného lesa, je tu kámen s nápisem Bhmil 1725-1749, můžeš pokračovat do lesa, nebo se vrátit na cestu"));
            Places[2].AddTravelPsb(new Place("temný les", ""));
            Places[2].AddTravelPsb(new Place("cesta", ""));

            Places.Add(new Place("rozcestník", "Došel si do temného lesa, cesta dále pokračuje ale je tu rozcestník, můžeš zvolit levou cestu, pravou, nebo se vrátik zpět"));
            Places[3].AddTravelPsb(new Place("temný les", ""));
            Places[3].AddTravelPsb(new Place("levá cesta", ""));
            Places[3].AddTravelPsb(new Place("pravá cesta", ""));

            player.SetPlace(Places[0]);
        }
    }
}
