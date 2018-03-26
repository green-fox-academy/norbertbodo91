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

            var sortCity2 = cities.Where(x => x.StartsWith('A'))
                                  .Where(x => x.EndsWith('I'));

            foreach (var city in sortCity)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
            foreach (var city in sortCity2)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
