using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Entities
{
    public class RedditContex : DbContext
    {
        public DbSet<Post> PostList { get; set; }

        public RedditContex(DbContextOptions<RedditContex>options ):base(options)
        {
        }
    }
}
