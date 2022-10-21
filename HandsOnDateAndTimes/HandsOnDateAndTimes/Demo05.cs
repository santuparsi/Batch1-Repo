using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDateAndTimes
{
    class Demo05
    {
        //Convert String to DateTime
        static void Main()
        {
            string str = "5/102/2020";
            DateTime dt;

            bool isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");
            var str1 = "23/05/2020";
            dt = DateTime.ParseExact(str1, "dd/MM/yyyy", null);
          
            Console.WriteLine(dt);
        }
    }
}
