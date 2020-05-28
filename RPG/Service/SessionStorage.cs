using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Models;
using RPG.Helpers;

namespace RPG.Service
{
    public class SessionStorage
    {
        readonly ISession _session;
        public Player Player { get; set; }
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            Player = _session.Get<Player>("player");
        }
        public void SavePlayer(Player player)
        {
            _session.Set("player", player);
        }
    }
}