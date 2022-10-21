using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDateAndTimes
{
    // Set Date & Time
    class Demo01
    {
        static void Main()
        {
            //assigns default value 01/01/0001 12:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

          //  DateTime dt = new DateTime(2015, 100, 3); //throws exception: day out of range
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            DateTime d = DateTime.Parse("12.2.2020");
            d = Convert.ToDateTime("12.3.2020");
        }
    }
}
