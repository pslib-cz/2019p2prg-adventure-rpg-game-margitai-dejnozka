using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Service;
using RPG.Models;

namespace RPG.Pages
{
    public class GameModel : PageModel
    {
        public Game game = new Game();
        public void OnGetTravel(string placeName)
        {
            game.player.currentPlace = placeName;
        }
    }
}