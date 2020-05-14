using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using rpg.Model;
using rpg.Service;

namespace rpg.Pages
{
    public class IndexModel : PageModel
    {
        public readonly SessionStorage _session;
        private readonly ILogger<IndexModel> _logger;
        public readonly Logic _logic;

        public IndexModel(ILogger<IndexModel> logger, Logic logic)
        {
            _logger = logger;
            _logic = logic;
        }

        public void OnGet()
        {
            _logic.StartGame();
        }
        public IndexModel(SessionStorage ss)
        {
            _session = ss;
        }
    }
}
