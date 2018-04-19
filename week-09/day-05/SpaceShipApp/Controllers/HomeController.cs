using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceShipApp.Entities;

namespace SpaceShipApp.Controllers
{
    public class HomeController : Controller
    {
        ISpaceship spaceRepo;

        public HomeController(ISpaceship spacer)
        {
            spaceRepo = spacer;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(spaceRepo.Read());
        }
        
        [HttpPost]
        [Route("/move/{id}")]
        public IActionResult Move(int id)
        {
            spaceRepo.Move(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("toplanet")]
        public IActionResult ToPlanet()
        {
            spaceRepo.GetOff();
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("toship")]
        public IActionResult  ToShip()
        {
            spaceRepo.GetOnBorad();
            return RedirectToAction("index");
        }
    }
}