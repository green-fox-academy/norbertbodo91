using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var trees = new List<Dictionary<string, object>>();

            var tree0 = new Dictionary<string, object>();
            tree0.Add("type","Rózsa");
            tree0.Add("leafColor", "vörös");
            tree0.Add("age", "15");
            tree0.Add("sex", "Fiú");
            trees.Add(tree0);

            var tree1 = new Dictionary<string, object>();
            tree1.Add("type", "Luc");
            tree1.Add("leafColor", "sárga");
            tree1.Add("age", "42");
            tree1.Add("sex", "Fiú");
            trees.Add(tree1);

            var tree2 = new Dictionary<string, object>();
            tree2.Add("type", "Fűzfa");
            tree2.Add("leafColor", "Zöldes-Srágás");
            tree2.Add("age", "38");
            tree2.Add("sex", "Lány");
            trees.Add(tree2);

            var tree3 = new Dictionary<string, object>();
            tree3.Add("type", "Cseresznye");
            tree3.Add("leafColor", "Zöld");
            tree3.Add("age", "21");
            tree3.Add("sex", "Fiú");
            trees.Add(tree3);

            var tree4 = new Dictionary<string, object>();
            tree4.Add("type", "Orchideafa");
            tree4.Add("leafColor", "Rózsaszín");
            tree4.Add("age", "13");
            tree4.Add("sex", "Lány");
            trees.Add(tree4);

            var tree5 = new Dictionary<string, object>();
            tree5.Add("type", "Ezüst Akácia");
            tree5.Add("leafColor", "Sárgás");
            tree5.Add("age", "31");
            tree5.Add("sex", "Lány");
            trees.Add(tree5);
        }
        
    }
}


