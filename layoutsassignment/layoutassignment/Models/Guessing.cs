using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace layoutassignment.Models
{
    public class Guessing
    {
        public string NumberCheck(double input, int diceRoll)
        {
            string result = null;
            if (input > diceRoll)
            {
                result = "You guessed to high";
                return result;
            }
            else if (input < diceRoll)
            {
                result = "You guessed to low";
                return result;
            }
            else if(input == diceRoll)
            {
                result = "You guess right";
                return result;
            }
            else
            {
                return result;
            }
                    
        }
    }
    
}