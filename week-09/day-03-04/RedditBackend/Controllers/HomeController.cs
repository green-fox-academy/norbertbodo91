using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Models;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    public class HomeController : Controller
    {
        ICrudRepository<Post> postRepo;

        public HomeController(ICrudRepository<Post> postRepository)
        {
            postRepo = postRepository;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return new OkObjectResult(postRepo.Read());
        }

        [HttpPost]
        [Route("post")]
        public IActionResult CreatePost([FromBody] Post post)
        {
            postRepo.Create(post);
            return new OkObjectResult(post);
        }
        
        [HttpPost]
        [Route("upvote")]
        public IActionResult UpVotePost([FromBody] int id)
        {
            postRepo.UpVote(id);
            return RedirectToAction("index");
        }

        [HttpPost]
        [Route("downvote")]
        public IActionResult DownVotePost([FromBody] int id)
        {
            postRepo.DownVote(id);
            return RedirectToAction("index");
        }

    }
}