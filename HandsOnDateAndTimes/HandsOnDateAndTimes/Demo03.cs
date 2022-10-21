using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDateAndTimes
{
    class Demo03
    {
        //TimeSpan
        //TimeSpan is a struct that is used to represent time in days, hour, minutes, seconds, and milliseconds.
        static void Main()
        {
            DateTime dt = new DateTime(2015, 12, 31);

            TimeSpan ts = new TimeSpan(25, 20, 55);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
           
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM

            //Subtract

            //DateTime dt1 = new DateTime(2015, 12, 31);
            //DateTime dt2 = new DateTime(2016, 2, 2);
            //TimeSpan result = dt2.Subtract(dt1);//33.00:00:00
            //result = dt2 - dt1;
            //Console.WriteLine($"days {result.Days} hours {result.Hours}");

            //Operators

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True
        }
    }
}
