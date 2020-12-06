using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
