using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenafighter
{
    public class Classes
    {
        public class Character
        {
            public string name;
            public int strength;
            public int damage;
            public int health;
        }

        public class Battle
        {
            List<string> ListOfWins = new List<string>();
            int points;
        }

        public class Round
        {
            //Character Hero = new Character();
            Random Dice = new Random();
            public void CurrentRound(Character Hero, Character Enemy)
            {
                int HeroDice = Hero.strength + Dice.Next(1, 6);
                int EnemyDice = Enemy.strength + Dice.Next(1, 6);
                if (HeroDice > EnemyDice)
                {
                    Console.WriteLine("Rolls: " + Hero.name + " " + HeroDice + "vs " + Enemy.name + " " + EnemyDice);
                    
                    Console.WriteLine(Hero.name + "attacks " + Enemy.name + "! " + Enemy.name + " takes " + Hero.damage + " damage.");
                    Console.WriteLine("Remaining Health " + Hero.health + " " + Enemy.health);
                }
                else if (HeroDice < EnemyDice)
                {
                    Console.WriteLine();
                }
                else if (HeroDice == EnemyDice)
                {
                    Console.WriteLine();
                }
            }
            

            
            /*Dice roll to add to characters strength
             Compare strength and highest attacks
             Show message depending on win or loss
             remove health from the loser.*/
        }

    }
}

