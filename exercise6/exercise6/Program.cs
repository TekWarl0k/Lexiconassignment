using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple mathematics");
            Console.WriteLine("First number");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            int Addition = firstnum + secondnum;
            int Subtraction = firstnum - secondnum;
            int Multiplication = firstnum * secondnum;
            int Division = firstnum / secondnum;

            Console.WriteLine(firstnum + " + " + secondnum + " = " + Addition);
            Console.WriteLine(firstnum + " - " + secondnum + " = " + Subtraction);
            Console.WriteLine(firstnum + " * " + secondnum + " = " + Multiplication);
            Console.WriteLine(firstnum + " / " + secondnum + " = " + Division);

            Console.ReadKey();



        }
    }
}
