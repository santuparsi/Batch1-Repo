using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    internal class Demo2
    {
        static void Main()
        {
            HashSet<int> hs1 = new HashSet<int>() { 12, 23, 34, 5, 66, 67, 45, 34, 34, 45 };
            HashSet<int> hs2 = new HashSet<int>() { 98,87,76,65,54,43,12,34 };
            //unionwith
            //hs1.UnionWith(hs2);
            //intersectwith
            //hs1.IntersectWith(hs2);
            hs1.ExceptWith(hs2);
            foreach (var item in hs1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
