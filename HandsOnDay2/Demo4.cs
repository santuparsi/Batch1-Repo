using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    public delegate void GreetDelegate();
    internal class Demo4
    {
        public void Greet()
        {
            Console.WriteLine("Hello Users");
        }
        public void Doit(GreetDelegate greetDelegate)
        {
            greetDelegate(); //invoking delegate
        }
        static void Main()
        {
            Demo4 demo = new Demo4();
            demo.Doit(demo.Greet);

        }
    }
}
