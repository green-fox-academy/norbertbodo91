using System;
using GreetWebApp.Services;

namespace GreetWebApp.Models
{
    public class Greet : IGreet
    {
        public string GreetSomeOne(string name)
        {
            return "HELLO " + name;
        }
    }
}
