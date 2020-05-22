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

            //pouze jak má hra začít, neukládat nic do Game.cs

            var cesta = new Place("cesta", "Jsi na cestě, můžeš jít do blízké vesnice, nebo do temného lesa");
            var vesnice = new Place("vesnice", "Jsi ve vesnici, můžeš jít k obchodníkovi, do hospody, nebo zpátky na cestu");
            var temny_les = new Place("temný les", "Jsi na kraji temného lesa, je tu kámen s nápisem Bhmil 1725-1749, můžeš pokračovat do lesa, nebo se vrátit na cestu");
            var rozcestnik = new Place("rozcestník", "Došel si do temného lesa, cesta dále pokračuje ale je tu rozcestník, můžeš zvolit levou cestu, pravou, nebo se vrátik zpět");
            cesta.AddTravelPsb(vesnice);
            cesta.AddTravelPsb(temny_les);

            vesnice.AddTravelPsb(new Place("cesta", ""));
            vesnice.AddTravelPsb(new Place("obchodník", ""));
            vesnice.AddTravelPsb(new Place("hospoda", ""));

            Places[2].AddTravelPsb(new Place("temný les", ""));
            Places[2].AddTravelPsb(new Place("cesta", ""));

            rozcestnik.AddTravelPsb(new Place("temný les", ""));
            rozcestnik.AddTravelPsb(new Place("levá cesta", ""));
            rozcestnik.AddTravelPsb(new Place("pravá cesta", ""));

            Places.Add(cesta);
            Places.Add(vesnice);
            Places.Add(temny_les);
            Places.Add(rozcestnik);

            player.SetPlace(cesta);
        }
    }
}
