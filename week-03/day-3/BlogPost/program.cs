namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BlogPost JohnDoe = new BlogPost("Lorem Ipsum", "John Doe", "Lorem ipsum dolor sit amet.", "2000.05.04");

            BlogPost TimUrban = new BlogPost("Wait but why", "Tim Urban", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");

            BlogPost WilliamTurton = new BlogPost("One Engineer Is Trying to Get IBM to Reckon With Trump", "William Turton", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine(JohnDoe.title +"\n"+JohnDoe.AuthorName+"\n"+JohnDoe.text+"\n"+JohnDoe.pubDate);

            Console.Read();
        }
    }
}