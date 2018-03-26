using System;
using System.Linq;


namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var sortCity = from city in cities
                           where city.StartsWith('A')
                           where city.EndsWith('I')
                           select city;

            foreach (var city in sortCity)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
