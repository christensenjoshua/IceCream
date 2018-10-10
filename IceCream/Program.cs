using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream
{
    class Program
    {
        static void Main(string[] args)
        {
              List<int[]> icecreamStuff = IcecreamParlor(new int[] {3,2,5,6,5,7,5},10);
            icecreamStuff.ForEach(p =>
           {
               Console.WriteLine($"{p[0]} : {p[1]}");
           });
            Console.ReadLine();
        }
        private static List<int[]> IcecreamParlor(int[] menu, int cash)
        {
            Dictionary<int, List<int>> items = new Dictionary<int, List<int>>();
            //KeyValuePair<int, int> items = new KeyValuePair<int, int>();
            List<int[]> results = new List<int[]>();
            for (int i = 0; i < menu.Length; i++)
            {
                int thisNum = menu[i];
                int needNum = cash - thisNum;
                if (items.ContainsKey(needNum))
                {

                    for (int j = 0; j < items[needNum].Count; j++)
                    {
                        results.Add(new int[] { i, items[needNum][j] });
                    }
                }
                if (items.ContainsKey(thisNum))
                {
                    items[thisNum].Add(i);
                }
                else
                {
                    items.Add(thisNum, new List<int>() { i });
                }
            }
            return results;
        }
    }
}
