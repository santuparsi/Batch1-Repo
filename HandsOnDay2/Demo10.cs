using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    internal class Demo10
    {
        static void Main()
        {
            int[] a = { 12, 23, 34, 32, 23, 45, 56, 67, 78 }; //datasource
            //retrun even values
            var result = from i in a
                         where i % 2 == 0
                         select i;
            List<int> list = a.Where(i => i % 2 == 0).ToList();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
