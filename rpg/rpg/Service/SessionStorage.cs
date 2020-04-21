using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace rpg.Service
{
    public class SessionStorage
    {
        readonly ISession _session;
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        /* Použije se => konstruktor v jiné třídě => 
            Konstruktor(SessionStorage session)
            { 
                ss = session;
            }
            public void OnGet()
            {
                session.number = 420;
            }
        */
    }
}
