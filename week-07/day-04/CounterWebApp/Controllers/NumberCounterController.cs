using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CounterWebApp.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterWebApp.Controllers
{
    
    public class NumberCounterController : Controller
    {
        private readonly ICountable Countable;

        public NumberCounterController(ICountable countable)
        {
            Countable = countable;
        }

        [HttpGet]
        [Route("Counter")]
        public IActionResult Counter()
        {
            return View(Countable);
        }
        [HttpPost]
        [Route("Increase")]
        public IActionResult Incease()
        {            
            Countable.IncreaseNumber();
            return RedirectToAction("Counter");;
        }
    }
}
