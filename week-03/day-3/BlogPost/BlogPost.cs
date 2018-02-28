using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BlogPost
    {
        public string AuthorName, title, text, pubDate;
        
        
        public BlogPost(string name, string title, string text, string pubDate)
        {
            this.AuthorName = name;
            this.title = title;
            this.text = text;
            this.pubDate = pubDate;

        }
    }
}
