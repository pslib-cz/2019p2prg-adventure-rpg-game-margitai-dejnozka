using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Models;
using RPG.Service;

namespace RPG.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SessionStorage sessionStorage;
        public Player player;
        public IndexModel(SessionStorage _sessionStorage)
        {
            sessionStorage = _sessionStorage;
        }

        public void OnGet()
        {

        }
    }
}
