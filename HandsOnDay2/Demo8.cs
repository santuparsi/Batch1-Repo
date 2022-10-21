using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    internal class Demo8
    {
        static void Main()
        {
            int i = 10;
            string s = null;
            Console.WriteLine(i.IsEven()?"Even":"Odd");
            if(s.IsNull())
            {
                Console.WriteLine("S should not be null");
            }

        }
    }
    public static class ExtensionMethods
    {
        public static bool IsEven(this int k)
        {
            return k % 2 == 0 ? true : false;
        }
        public static bool IsNull(this string s)
        {
            if (s == null)
                return true;
            else
                return false;
        }
    }

}
