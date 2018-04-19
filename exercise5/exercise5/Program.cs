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

            VarArray = VarArray.Remove(3,4);
            indexOfString = VarArray.IndexOf("]");
            VarArray = VarArray.Insert(indexOfString, ",6,7,8,9,10");




            /*VarArray = VarArray.Replace("4","9");
            indexOfString = VarArray.IndexOf("5");
            VarArray = VarArray.Remove(indexOfString, 1);
            VarArray = VarArray.Insert(indexOfString,"10");*/

            Console.WriteLine(VarArray);
        }
    }
}
