using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static golf.classes;

namespace golf
{
    class Program
    {
        static void Main(string[] args)
        {
            Score Score = new Score();
            Cup Cup = new Cup();
            Position Position = new Position();

            bool isRunning = true;

            Console.WriteLine("Welcome to Ball Smasher '86");
            Console.WriteLine();
            while (isRunning)
            {
                Console.WriteLine("Distance to cup is: " + Position.CurrentPos(Cup, Score) + " meters");
                Console.WriteLine();
                Console.WriteLine("Please input the angle to hit the ball with.");
                Ball.Angle = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please input the speed to hit the ball with.");
                Ball.Speed = Convert.ToInt16(Console.ReadLine());

                if (Cup.Distance == 0)
                {
                    isRunning = false;
                    Console.WriteLine("You have won!");
                    Console.WriteLine();
                    int count = 0;
                    foreach (string hit in Score.HitsDistance)
                    {
                        count += 1;
                        Console.WriteLine(count + " " + hit);
                    }
                    //Foreach for list.
                    Console.ReadKey();
                }
                /*else if (Score.Hits > 18)
                {
                    isRunning = false;
                    //Exception
                }
                else if (Cup.Distance > 200)
                {
                    isRunning = false;
                    //Exception
                }*/
                else
                {
                    Score.Hits++;
                    Console.WriteLine();
                    Console.WriteLine("You shot the ball " + Ball.Calculation() + " meters and have made " + Score.Hits + " swings.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
