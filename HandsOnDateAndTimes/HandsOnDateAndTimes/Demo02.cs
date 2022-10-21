using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDateAndTimes
{
    class Demo02
    {
        static void Main()
        {
            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime
            Console.WriteLine(currentDateTime);
            Console.WriteLine(todaysDate);
            Console.WriteLine($"{maxDateTimeValue}-{minDateTimeValue}");
            DateTime dt = DateTime.Now;
            Console.WriteLine($"Year:{dt.Year} Month:{dt.Month} Day:{dt.Day}");

        }
    }
}
