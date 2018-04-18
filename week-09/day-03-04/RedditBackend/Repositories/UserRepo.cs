using RedditBackend.Entities;
using RedditBackend.Models;
using RedditBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class UserRepo : ICrudRepository<User>
    {
        private RedditContex db;

        public UserRepo(RedditContex ctx)
        {
            db = ctx;
        }

        public void Create(User user)
        {
            db.Add(user);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = db.UserList.FirstOrDefault(x => x.Id == id);
            db.Remove(user);
            db.SaveChanges();
        }

        public List<User> Read()
        {
           return db.UserList.ToList();
        }

        public void DownVote(int id)
        {
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void UpVote(int id)
        {
            throw new NotImplementedException();
        }
    }
}
