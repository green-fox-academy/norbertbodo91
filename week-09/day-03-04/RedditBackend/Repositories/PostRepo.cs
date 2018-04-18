using Microsoft.EntityFrameworkCore;
using RedditBackend.Entities;
using RedditBackend.Models;
using RedditBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class PostRepo : ICrudRepository<Post>
    {
        private RedditContex db;

        public PostRepo(RedditContex ctx)
        {
            db = ctx;
        }

        public void Create(Post post)
        {
            db.Add(post);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Post post = db.PostList.FirstOrDefault(x => x.Id == id);
            db.Remove(post);
            db.SaveChanges();
        }

        public List<Post> Read()
        {
            db.UserList.Load();
            return db.PostList.ToList();
        }

        public void DownVote(int id)
        {
            Post post = db.PostList.FirstOrDefault(x => x.Id == id);
            post.Vote--;
            db.SaveChanges();
        }

        public void UpVote(int id)
        {
            Post post = db.PostList.FirstOrDefault(x => x.Id == id);
            post.Vote++;
            db.SaveChanges();
        }

        public void Update()
        {
        }
    }
}
