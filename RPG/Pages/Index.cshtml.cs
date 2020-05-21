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
        private readonly ILogger<IndexModel> logger;
        //private readonly SessionStorage sessionStorage;
        public IndexModel(ILogger<IndexModel> _logger /*, SessionStorage _sessionStorage*/)
        {
            logger = _logger;
            //sessionStorage = _sessionStorage;
        }

        public void OnGet()
        {

        }
    }
}
