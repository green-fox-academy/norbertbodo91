namespace ConsoleApp1
{
    class Program
    {
        public struct PostIt
            {
            public string backGroundColor, text, textColor;

                 public PostIt(string p1,string p2,string p3)
                 {
                    backGroundColor = p1;
                    text = p2;
                    textColor = p3;
                 }
            }
        static void Main(string[] args)
        {
            PostIt post1 = new PostIt("orange","Idea1","blue");
            PostIt post2 = new PostIt("pink", "Awesome", "black");
            PostIt post3 = new PostIt("yellow", "Superb!", "green");
        }
    }
}