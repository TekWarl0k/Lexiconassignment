using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    class Classes
    {
        public class MoneyPool
        {
            public int[] Value = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            public int money = 0;

            public void AddMoney()
            {
                Console.WriteLine("How much do you want to put in the machine?");
                foreach (int num in Value)
                {
                    Console.Write(num + "kr ");
                }
                money = Convert.ToInt32(Console.ReadLine());
                switch (money)
                {
                    case 1:
                        Console.WriteLine("You put 1 krona in the machine.");
                        money = money++;
                        break;
                    case 5:
                        Console.WriteLine("You put 5 kronor in the machine.");
                        money = money + 5;
                        break;
                    case 10:
                        Console.WriteLine("You put 10 kronor in the machine.");
                        money = money + 10;
                        break;
                    case 20:
                        Console.WriteLine("You put 20 kronor in the machine.");
                        money = money + 20;
                        break;
                    case 50:
                        Console.WriteLine("You put 50 kronor in the machine.");
                        money = money + 50;
                        break;
                    case 100:
                        Console.WriteLine("You put 100 kronor in the machine.");
                        money = money + 100;
                        break;
                    case 500:
                        Console.WriteLine("You put 500 kronor in the machine.");
                        money = money + 500;
                        break;
                    case 1000:
                        Console.WriteLine("You put 1000 kronor in the machine. You sure is a player! I should shred your note.");
                        break;
                    default:
                        Console.WriteLine("You put in fake money!");
                        break;
                }
            }
        }
        public class Inventory
        {
            Food MyFood = new Food();
            Drink MyDrink = new Drink();
            Snack MySnack = new Snack();

            public void ShowInventory()
            {
                Console.WriteLine(MyFood);
                Console.WriteLine(MyDrink);
                Console.WriteLine(MySnack);
            }
            public void MyInventory()
            {
                List<string> MyItems = new List<string>();
                foreach (var item in MyItems)
                {
                    Console.WriteLine(item);
                }
            }       
        }
        public abstract class Basic
        {
            public void Purchase()
            {
                string[] CheckArray = { "0" };
                Console.WriteLine("What do you want to purchase?");
                string PurchaseInput = Convert.ToString(Console.ReadLine());
                if (PurchaseInput.Equals(CheckArray))
                {
                    //Jämnför input med dictionaries och om det stämmer så lägg till saken i personliga inventory.
                }
            }
            public void Inspect()
            {
                Food Food = new Food();
                Drink Drink = new Drink();
                Snack Snack = new Snack();
                foreach (KeyValuePair<string, int> pair in Food.FoodItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                };
                foreach (KeyValuePair<string, int> pair in Drink.DrinkItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                }
                foreach (KeyValuePair<string, int> pair in Snack.SnackItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                }
                //Visa alla dictionaries.
            }
            public virtual void Use()
            {
                //Jämnför input med vad som finns i dictionaries. Stämmer det så ska den ge tillbaka en string beroende på vilken dictionary som ger "true". Ta bort saken från inventory.
            }
        }
        public class Food : Basic
        {
            public Dictionary<string, int> FoodItems = new Dictionary<string, int>()
            {
                {"Sandwich", 25},
                {"Cookie", 8},
                {"Nutrition bar", 15}
            };
            public override void Use()
            {
               
            }
        }
        class Drink : Basic
        {
            public Dictionary<string, int> DrinkItems = new Dictionary<string, int>()
            {
                {"Soda", 15},
                {"Juice", 10},
                {"Water", 20},
                {"Carbonated Water", 25}
            };
        }
        class Snack : Basic
        {
            public Dictionary<string, int> SnackItems = new Dictionary<string, int>()
            {
                {"Chocolate bar", 9},
                {"Chips", 10},
                {"Candy bag", 12},
                {"Peanuts", 10}
            };
        }
    }

}
