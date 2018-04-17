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
        IPostRepository<Post> postRepo;

        public HomeController(IPostRepository<Post> postRepository)
        {
            postRepo = postRepository;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return Json(postRepo.Read().OrderByDescending(x=>x.Vote));
        }

        [HttpGet]
        [Route("createpost")]
        public IActionResult CreatePost(string Title, string URL)
        {
            postRepo.Create(Title, URL);
            return RedirectToAction("index");
        }
        
        [HttpGet]
        [Route("{id}/upvote")]
        public IActionResult UpVotePost(int id)
        {
            postRepo.UpVote(id);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("{id}/downvote")]
        public IActionResult DownVotePost(int id)
        {
            postRepo.DownVote(id);
            return RedirectToAction("index");
        }

    }
}