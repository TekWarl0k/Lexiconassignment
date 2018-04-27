using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testingapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string answer = (num > 2) ? "Value is above 2" : "Value is below 2";
            Console.WriteLine(answer);
            /*while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }*/
            Console.ReadKey();
        }
    }
}
