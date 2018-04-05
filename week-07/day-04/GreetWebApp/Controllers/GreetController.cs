using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetWebApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetWebApp.Controllers
{
    public class GreetController : Controller
    {
        IGreet greet;

        public GreetController(IGreet _greet)
        {
            greet = _greet;
        }
        [Route("AskforName")]
        [HttpGet]
        public IActionResult AskforName()
        {
            return View();
        }
        [Route("Greet")]
        [HttpPost]
        public IActionResult Greet(string name)
        {
            return View((object)(greet.GreetSomeOne(name)));
        }
    }
}
