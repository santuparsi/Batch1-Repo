using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
    public delegate int CubeDelegate(int k);
    internal class Demo7
    {
        public int Cube(int i)
        {
            return i * i * i;
        }
        static void Main()
        {
            Demo7 demo7 = new Demo7();
            CubeDelegate cubeDelegate = demo7.Cube;
            int result=cubeDelegate(4);
            CubeDelegate cubeDelegate1 = i => i * i * i; //lambda expression
            result=cubeDelegate1(5);
        }
    }
}
