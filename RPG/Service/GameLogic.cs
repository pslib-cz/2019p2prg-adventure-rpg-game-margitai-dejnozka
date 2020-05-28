using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class GameLogic
    {
        public GameStart game = new GameStart();
        private readonly SessionStorage sessionStorage;
        public GameLogic(SessionStorage _sessionStorage)
        {
            sessionStorage = _sessionStorage;
        }
    }
}
