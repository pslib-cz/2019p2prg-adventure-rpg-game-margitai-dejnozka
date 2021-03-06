﻿using System;
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
        public readonly GameLogic Game;
        public GameModel(GameLogic game)
        {
            Game = game;
        }
        public void OnGetTravel(string placeName)
        {
            Game.Travel(placeName);
        }
    }
}