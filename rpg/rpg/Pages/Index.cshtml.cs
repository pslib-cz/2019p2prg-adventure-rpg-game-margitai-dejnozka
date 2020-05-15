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
        //private readonly ILogger<IndexModel> _logger;
        public readonly Logic logic { get; set; }

        public IndexModel(/*ILogger<IndexModel> logger,*/ SessionStorage session)
        {
            //    _logger = logger;
            _session = session;
        }

        public void OnGet()
        {
            _logic.StartGame();
        }
    }
}
