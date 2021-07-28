using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ultima.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Main()
        {
            return Redirect("https://www.twitch.tv/n_Ultima");
        }
    }
}
