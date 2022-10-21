using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    //delegate declaration
    public delegate void Delegate1();
    public delegate void Delegate2(string name);
    internal class Demo3
    {
        public void Task1()
        {
            Console.WriteLine("do some task");
        }
        public void Task2()
        {
            Console.WriteLine("do some more task");
        }
        public void Greet(string n)
        {
            Console.WriteLine("Hello " + n);
        }

        static void Main()
        {
            Demo3 demo3 = new Demo3();
            //instantiate delegate
            Delegate1 d1 = demo3.Task1; //refect task1 by delegate d1
            //invoking delegate
            d1();
           
            //refering multiple methods to delegate object
            Delegate1 d2 = demo3.Task1;
            d2+=demo3.Task2;
            d2();
            Delegate2 d3 = demo3.Greet;
            d3("Suren");
        }
    }
}
