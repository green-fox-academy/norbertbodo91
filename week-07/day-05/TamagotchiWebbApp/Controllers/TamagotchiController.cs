using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TamagotchiWebbApp.Controllers
{
    public class TamagotchiController : Controller
    {
        ITamagochi tamagotchi;
        public TamagotchiController(ITamagochi _tamagotchi)
        {
            tamagotchi = _tamagotchi;
        }
        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View(tamagotchi);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string givenName)
        {
            tamagotchi.SetName(givenName);
            return RedirectToAction("index");
        }
        [HttpPost]
        [Route("trick")]
        public IActionResult Trick(int numberOfTrick)
        {
            tamagotchi.DoTrick(numberOfTrick);
            return RedirectToAction("index");
        }
    }
}
