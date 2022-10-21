using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    internal class Demo1
    {
        static void Main()
        {
            Dictionary<string, List<string>> obj = new Dictionary<string, List<string>>();
            obj.Add("India", new List<string> { "Delhi", "Mumbai", "Chennai" });
            obj.Add("US", new List<string> { "Newyork", "Chicago", "Huston" });
            foreach (KeyValuePair<string, List<string>> pair in obj)
            {
                Console.WriteLine($"Cities in {pair.Key}");
                foreach (string key in pair.Value)
                {
                    Console.Write(key+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
