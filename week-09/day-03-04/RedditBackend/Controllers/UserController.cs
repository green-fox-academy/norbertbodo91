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

        [HttpPost]
        [Route("createuser")]
        public IActionResult CreateUser([FromBody]User user)
        {
            userRepo.Create(user);
            return new OkObjectResult(user);
        }
    }
}