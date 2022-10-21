using System.Collections;
namespace HandsOnDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            //store items in hashtable
            hashtable.Add(2345, "Rohan");
            hashtable.Add(2334, "Raj");
            hashtable.Add(2365, "Dimple");
            hashtable.Add(2385, "Deeksh");
            hashtable.Add(2395, "Dheeraj");
            if (hashtable.ContainsKey(2334))
            {
                string n = hashtable[2334] as string;
                Console.WriteLine(n);
            }
            //fetch all key-value pairs from hastable
            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine($"ID:{key} Name:{hashtable[key]}");
            }
            foreach(DictionaryEntry d in hashtable)
            {
                Console.WriteLine($"ID:{d.Key} Name:{d.Value}");
            }
        }
    }
}