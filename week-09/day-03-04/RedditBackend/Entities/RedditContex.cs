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
        public DbSet<User> UserList { get; set; }

        public RedditContex(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(p => p.User);
        }
    }
}
