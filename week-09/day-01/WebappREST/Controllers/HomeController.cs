using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebappREST.Models;

namespace WebappREST.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input , result = 2 * input });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if(title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new {appended = appendable + "a" });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult AppendA()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] UntilClass until)
        {
            if (what == "sum")
            {
                if (until.Until == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                return Json(new { result = until.Sum()});
            }
            if (what == "factor")
            {                
                return Json(new { result = until.Factor()});
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}