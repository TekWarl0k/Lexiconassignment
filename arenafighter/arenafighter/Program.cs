using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static arenafighter.Classes;

namespace arenafighter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] EnemyName = {"Steve the Janitor", "Ivan the Lame", "Lisa the Picky", "Horrible Hank", "Non binary Brenda", "Booger eater Bob", "Charles Cow lover", "Jenny with the Axe"};

            Random Stats = new Random();
            Character Hero = new Character();
            Character Enemy = new Character();
            Battle Victory = new Battle();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("What is your name hero?");
                Hero.name = Console.ReadLine();
                Console.Clear();

                Hero.strength = Stats.Next(3, 6);
                Hero.damage = Stats.Next(2, 3);
                Hero.health = Stats.Next(4, 7);

                Console.WriteLine(Hero.name);
                Console.WriteLine("Strength: " + Hero.strength);
                Console.WriteLine("Damage: " + Hero.damage);
                Console.WriteLine("Health: " + Hero.health);
                Console.WriteLine();

                while (isRunning)
                {
                    Console.WriteLine("What to you want to do hero?");
                    Console.WriteLine("F - Fight a enemy");
                    Console.WriteLine("R - Retire");
                    string FightOrFlee = Convert.ToString(Console.ReadLine());
                    if (FightOrFlee == "F")
                    {
                        Console.Clear();
                        Console.WriteLine("Player:");
                        Console.WriteLine(Hero.name);
                        Console.WriteLine("Strength: " + Hero.strength);
                        Console.WriteLine("Damage: " + Hero.damage);
                        Console.WriteLine("Health: " + Hero.health);
                        Console.WriteLine();

                        int NameCaller = Stats.Next(0, EnemyName.Length);
                        Enemy.name = EnemyName[NameCaller];
                        Enemy.strength = Stats.Next(3, 6);
                        Enemy.damage = Stats.Next(2, 3);
                        Enemy.health = Stats.Next(4, 7);

                        Console.WriteLine("Opponent:");
                        Console.WriteLine(Enemy.name);
                        Console.WriteLine("Strength " + Enemy.strength);
                        Console.WriteLine("Damage " + Enemy.damage);
                        Console.WriteLine("Health " + Enemy.health);
                        Console.WriteLine();
                        Console.ReadKey();

                        Round newRound = new Round();
                        newRound.CurrentRound(Hero, Enemy, Victory);

                    }
                    if (FightOrFlee == "R")
                    {
                        Console.Clear();
                        Console.WriteLine(Hero.name);
                        Console.WriteLine("Strength: " + Hero.strength);
                        Console.WriteLine("Damage: " + Hero.damage);
                        Console.WriteLine("Health: " + Hero.health);
                        Console.WriteLine();
                        foreach (string win in Victory.ListOfWins)
                        {
                            Console.WriteLine(win);
                        }
                        Console.WriteLine();
                        Console.WriteLine(Victory.points);
                        Console.ReadKey();

                        isRunning = false;
                    }
                    /*Console.ReadKey();
                    Console.Clear();*/
                }

            }
            
            
            
            
            
            /*Console.WriteLine("Testing");
            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();*/
        }
    }
}
