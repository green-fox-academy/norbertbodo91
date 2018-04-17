using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Models;

namespace RedditBackend.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiHomeController : Controller
    {
        [HttpGet]
        [Route("hello")]
        public string GetList()
        {
            return "HEllo Mark";
        }
    }
}