using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golf
{
    class classes
    {
        public static class Ball
        {
            public static int Angle = 0;
            public static int Speed = 0;

            public static double Calculation()
            {
                double AngleinRadians = (Math.PI / 180) * Angle;
                int Distance = Convert.ToInt16(Math.Pow(Speed, 2) / 9.8 * Math.Sin(2 * AngleinRadians));
                return Distance;
            }
        }

        public class Position
        {
            public bool isRunning = true;

            public int CurrentPos(Cup Cup, Score Score)
            {
                if (Score.Hits > 18)
                {
                    isRunning = false;
                    throw new ToManySwings();
                    //Exception
                }
                if (Cup.Distance > 200)
                {
                    isRunning = false;
                    throw new ToMuchDistance();
                    //Exception
                }
                if (Cup.Distance == Cup.Position)
                {
                    Cup.Distance = Math.Abs(Convert.ToInt16(Cup.Position - Ball.Calculation()));
                    return Cup.Distance;
                }
                else
                {
                    Cup.Distance = Math.Abs(Convert.ToInt16(Cup.Distance - Ball.Calculation()));
                    Score.HitsDistance.Add("Ball traveled " + Cup.Distance + "meters");
                    return Cup.Distance;
                }
            }
        }

        public class Cup
        {
            public int Position = 150;
            public int Distance = 150;
        }

        public class Score
        {
            public List<string> HitsDistance = new List<string>();
            public int Hits = 0;
        }
        public class ToManySwings : Exception
        {
            public ToManySwings()
            {
                Console.WriteLine("You shot to many times");
            }
        }
        public class ToMuchDistance : Exception
        {
            public ToMuchDistance()
            {
                Console.WriteLine("You are too far away from the cup");
            }
        }

    }
}