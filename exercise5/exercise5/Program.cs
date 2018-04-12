using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string VarArray;

            int indexOfString = Str.IndexOf("[");
            VarArray = Str.Remove(0, indexOfString);

            Console.WriteLine(indexOfString);
            Console.WriteLine(VarArray);
        }
    }
}
