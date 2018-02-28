using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var treelist = new TreeList();
            treelist.Add(new Tree("Luc", "Zöld", 13, "Fiú"));
            treelist.Add(new Tree("Cseresznye", "Piros", 28, "Lány"));
            treelist.Add(new Tree("Ezüst", "Füstös", 56, "Lány"));
            treelist.Add(new Tree("Nyár", "Sárga", 12, "Fiú"));
            treelist.Add(new Tree("Orchidea", "Rózsaszín", 38, "Fiú"));

            TreePrint(treelist.List());
            Console.Read();

        }
        public static void TreePrint(List<Tree> Treelist)
        {
            
            foreach (var tree in Treelist)
            {
                Console.WriteLine(tree.type +"fa" + " "+"Levélszín: " + tree.leafcolor +" "+"["+ tree.age +"]"+ "éves" +" " + tree.sex +"\n");
            }
        }
    }
}
