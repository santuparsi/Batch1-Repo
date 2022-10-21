using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HandsOnDay2
{
    internal class Demo6
    {
        public void Task1()
        {
           for(byte b=0;b<=255;b++)
            {
                Console.Write(b + " ");
                Thread.Sleep(1000);
            }
        }
        public void Task2()
        {
            for (byte b = 0; b <= 255; b++)
            {
                Console.WriteLine(Convert.ToChar(b) + " ");
                Thread.Sleep(1000);
            }
        }
        static void Main()
        {
            Demo6 demo6 = new Demo6();
            Thread t1 = new Thread(demo6.Task1);
            Thread t2 = new Thread(demo6.Task2);
            t1.Start();
            t2.Start();
        }
    }
}
