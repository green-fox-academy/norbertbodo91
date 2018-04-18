using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Models;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    public class UserController : Controller
    {
        ICrudRepository<User> userRepo;

        public UserController(ICrudRepository<User> userRepository)
        {
            userRepo = userRepository;
        }

        [HttpGet]
        [Route("createuser")]
        public IActionResult CreateUser(string name)
        {
            userRepo.Create(new User { Name = name });
            return RedirectToAction("index");
        }
    }
}