using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();
            book.AddGrade(65);
            book.AddGrade(12);

            Gradebook book2 = book;
            book2.AddGrade(10);
        }
    }
}
