using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Now;
            DateTime tomorrowsDate = todaysDate.AddDays(1);
            DateTime yesterdaysDate = todaysDate.AddDays(-1);

            Console.WriteLine("Todays date is " +todaysDate);
            Console.WriteLine("Tomorrows date is " + tomorrowsDate);
            Console.WriteLine("Yesterdays date was " + yesterdaysDate);
            Console.ReadKey();
        }
    }
}
