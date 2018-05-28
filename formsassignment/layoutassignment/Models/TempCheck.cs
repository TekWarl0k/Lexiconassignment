using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace layoutassignment.Models
{
    public static class TempCheck
    {
        public static string CheckTemp(double input)
        {
            string result;
            if (input > 37.8)
            {
                result = "You have a fever.";
            }
            else
            {
                result = "You don't have a fever.";
            }
            return result;
        }
    }
}