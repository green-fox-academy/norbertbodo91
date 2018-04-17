using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnagramCheckWebApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagramCheckWebApp.Controllers
{
    public class AnagramController : Controller
    {
        IAnagram anagram;

        public AnagramController(IAnagram _anagram)
        {
            anagram = _anagram;
        }

        [Route("AskAnagram")]
        [HttpGet]
        public IActionResult AskAnagram()
        {
            return View();
        }

        [Route("CheckAnagram")]
        [HttpPost]
        public IActionResult CheckAnagram(string firstWord, string secondWord)
        {
            return View((object)anagram.CheckIfAnagramOrNot(firstWord, secondWord));
        }
    }
}
