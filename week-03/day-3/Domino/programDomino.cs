using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            
            foreach (var domino in DominoInLine(dominoes))
            {
                Console.WriteLine("["+domino.GetValues()[0]+","+domino.GetValues()[1]+"]");
            }
                Console.Read();
        }
        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static List<Domino> DominoInLine(List<Domino> Dominolist)
        {
            List<Domino> dominoResult = new List<Domino>();

            dominoResult.Add(Dominolist[0]);

            for (int i = 1; i < Dominolist.Count; i++)
            {
                for (int j = 0; j < Dominolist.Count; j++)
                {

                    if (dominoResult[i-1].GetValues()[1] == Dominolist[j].GetValues()[0])
                    {
                        dominoResult.Add(Dominolist[j]);
                    }
                }
            }
            return dominoResult;
        }

    }
}
