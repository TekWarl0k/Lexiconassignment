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

            bool isRunning = true;
            while (isRunning)
            {

                Hero.strength = Stats.Next(3, 6);
                Hero.damage = Stats.Next(2, 3);
                Hero.health = Stats.Next(4, 7);
                Round newRound = new Round();
                newRound.CurrentRound(Hero, Enemy);


                Console.WriteLine("What is your name hero?");
                Hero.name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine(Hero.name);
                Console.WriteLine("Strength: " + Hero.strength);
                Console.WriteLine("Damage: " + Hero.damage);
                Console.WriteLine("Health: " + Hero.health);

                while (isRunning)
                {
                    Console.WriteLine("What to you want to do hero?");
                    Console.WriteLine("F - Fight a enemy");
                    Console.WriteLine("R - Retire");
                    string FightOrFlee = Convert.ToString(Console.ReadLine());
                    if (FightOrFlee == "F")
                    {
                        Console.Clear();
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

                        Console.WriteLine(Enemy.name);
                        Console.WriteLine("Strength " + Enemy.strength);
                        Console.WriteLine("Damage " + Enemy.damage);
                        Console.WriteLine("health " + Enemy.health);
                        
                    }
                    if (FightOrFlee == "R")
                    {

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
