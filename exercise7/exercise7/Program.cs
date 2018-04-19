using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle area and Sphere volume calculator");
            Console.WriteLine("Input the radius you want to use");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double volume = 3 * Math.PI * Math.Pow(radius, 3) / 3;

            Console.WriteLine("The area of the circle is " + area);
            Console.WriteLine("The volume of the sphere is " + volume);
        }
    }
}
