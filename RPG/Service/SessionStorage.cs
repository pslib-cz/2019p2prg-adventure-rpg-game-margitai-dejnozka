using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Models;

namespace RPG.Service
{
    public class SessionStorage
    {
        readonly ISession _session;
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        public void SetHP(int HP)
        {
            _hp = HP;
        }
    }
}