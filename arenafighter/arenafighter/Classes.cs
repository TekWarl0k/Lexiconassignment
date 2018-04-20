using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenafighter
{
    public class Classes
    {
        public bool Alive = true;

        public class Character
        {
            public string name;
            public int strength;
            public int damage;
            public int health;
        }

        public class Battle
        {
            public List<string> ListOfWins = new List<string>();
            public int points;
        }

        public class Round
        {
            //Character Hero = new Character();
            Random Dice = new Random();
            private bool Alive = true;

            public void CurrentRound(Character Hero, Character Enemy, Battle Victory)
            {
              while (Alive)
                {
                    int HeroDice = Hero.strength + Dice.Next(1, 6);
                    int EnemyDice = Enemy.strength + Dice.Next(1, 6);
                    if (HeroDice > EnemyDice)
                    {
                        Console.WriteLine("Rolls: " + Hero.name + " " + HeroDice + " vs " + Enemy.name + " " + EnemyDice);
                        Console.WriteLine(Hero.name + " attacks " + Enemy.name + "! " + Enemy.name + " takes " + Hero.damage + " damage.");
                        Enemy.health = Enemy.health - Hero.damage;
                        Console.WriteLine("Remaining Health " + Hero.name + " " + Hero.health + " " + Enemy.name + " " + Enemy.health);
                        Console.WriteLine();
                    }
                    else if (HeroDice < EnemyDice)
                    {

                        Console.WriteLine("Rolls: " + Hero.name + " " + HeroDice + " vs " + Enemy.name + " " + EnemyDice);
                        Console.WriteLine(Enemy.name + " attacks " + Hero.name + "! " + Hero.name + " takes " + Enemy.damage + " damage.");
                        Hero.health = Hero.health - Enemy.damage;
                        Console.WriteLine("Remaining Health " + Hero.name + " " + Hero.health + " " + Enemy.name + " " + Enemy.health);
                        Console.WriteLine();
                    }
                    else if (HeroDice == EnemyDice)
                    {
                        Console.WriteLine("Rolls: " + Hero.name + " " + HeroDice + " vs " + Enemy.name + " " + EnemyDice);
                        Console.WriteLine("Neither finds any opening to attack and circle eachother searching.");
                        Console.WriteLine();
                    }
                    if (Hero.health <= 0 || Enemy.health <= 0)
                    {
                        if (Hero.health <= 0)
                        {
                            Console.WriteLine(Enemy.name + " attacks " + Hero.name + "! " + Hero.name + " takes " + Enemy.damage + " damage and falls to the ground dead.");
                            Alive = false;
                            Victory.points = Victory.points + 1;
                            Victory.ListOfWins.Add(Hero.name + " lost against " + Enemy.name);
                            Console.WriteLine();
                        }
                        else if (Enemy.health <= 0)
                        {
                            Console.WriteLine(Hero.name + " attacks " + Enemy.name + "! " + Enemy.name + " takes " + Hero.damage + " damage and falls to the ground dead.");
                            Alive = false;
                            Victory.points = Victory.points + 2;
                            Victory.ListOfWins.Add(Hero.name + " won against " + Enemy.name);
                            Console.WriteLine();
                        }
                        else
                        {

                        }
                    }
                    Console.ReadKey();
                }
            }
            
            /*Dice roll to add to characters strength
             Compare strength and highest attacks
             Show message depending on win or loss
             remove health from the loser.*/
        }

    }
}

