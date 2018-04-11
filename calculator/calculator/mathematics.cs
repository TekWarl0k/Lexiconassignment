using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
   public class mathematics
    {
        //Mina fyra metoder som utför fyra olika matematiska uträkningar där de tar in datan och returnerar summan.
        public double Addition(double firstnum, double secondnum)
        {
            return firstnum + secondnum;
        }
        public double Subtraction(double firstnum, double secondnum)
        {
            return firstnum - secondnum;
        }
        public double Multiplication(double firstnum, double secondnum)
        {
            return firstnum * secondnum;
        }
        public double Division(double firstnum, double secondnum)
        {
            return firstnum / secondnum;
        }
    }
}
