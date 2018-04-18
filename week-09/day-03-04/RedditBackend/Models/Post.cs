using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class Post
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public int Vote { get; set; }
        public DateTime TimeStamp { get; set; }
        public User User { get; set; }

    }
}
