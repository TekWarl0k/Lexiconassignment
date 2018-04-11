using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            mathematics calculus = new mathematics(); //Gör en ny instans av mathematics klassen för att kunna kalla på den i programmet.
            double sum = 0; //Ett variabel objekt som designeras värdet noll.

            bool isRunning = true; //En loop som stänger av programmet om värdet ställs om till "false".
            while (isRunning)
            { 
                Console.WriteLine("Type the first number!");
                double firstnum = Convert.ToInt32(Console.ReadLine()); //Tar input och konverterar den till ett numeriskt värde som sparas som en double variabel.

                Console.WriteLine("type the second number!");
                double secondnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input the arithmetic operation you wish to use!"); //Mitt meny system.
                Console.WriteLine("\t[1] Addition");
                Console.WriteLine("\t[2] Subtraction");
                Console.WriteLine("\t[3] Multiplication");
                Console.WriteLine("\t[4] Division");
                Console.WriteLine("\t[5] Quit");
                int operation = Convert.ToInt32(Console.ReadLine()); //Tar emot värdet och konverterar det till ett int värde som sparas i operation objektet.

                switch (operation)
                {
                    case 1:
                        sum = calculus.Addition(firstnum, secondnum); //Tar datan ifrån objekten "firstnum" och "secondnum" och kör genom metoden "Addition" som finns public klassen "mathematics". Svaret sparas i objektet "sum".
                        Console.WriteLine(+firstnum + " +" + secondnum + " = " + sum);
                        Console.ReadKey();
                        break;
                    case 2:
                        sum = calculus.Subtraction(firstnum, secondnum);
                        Console.WriteLine(+firstnum + " -" + secondnum + " = " + sum);
                        Console.ReadKey();
                        break;
                    case 3:
                        sum = calculus.Multiplication(firstnum, secondnum);
                        Console.WriteLine(+firstnum + " *" + secondnum + " = " + sum);
                        Console.ReadKey();
                        break;
                    case 4:
                        sum = calculus.Division(firstnum, secondnum);
                        Console.WriteLine(+firstnum + " /" + secondnum + " = " + sum);
                        Console.ReadKey();
                        break;
                    case 5:
                        isRunning = false; //Ändrar värdet i boolean loopen till "false" vilket stänger av programmet.
                        break;
                }

                //Jens Andersson 880703.
                //Inlämningsuppgift "Calculator".
            }
        }
    }
}
