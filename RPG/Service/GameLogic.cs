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
        public Story story = new Story();
        public Player player;
        public GameLogic(SessionStorage _sessionStorage)
        {
            sessionStorage = _sessionStorage;
        }
        public void Travel()
        {
         
        }
    }
}
