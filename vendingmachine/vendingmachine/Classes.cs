using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    class Classes
    {
        public static class MoneyPool
        {
            public static int[] Value = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            public static int money = 0;

            public static void AddMoney()
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
        public class Inventory: Stock
        {
            public static List<string> MyItems = new List<string>();

            public void ShowStock()
            {
                foreach (var item in FoodItems)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in DrinkItems)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in SnackItems)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
                Console.Clear();
            }
            public static void MyInventory()
            {
                foreach (var item in MyItems)
                {
                    Console.WriteLine(item);
                }
            }       
        }
        public class Basic : Stock
        {
            public virtual void Purchase()
            {
                Inventory ClassInv = new Inventory();
                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("What do you want to purchase?");
                    ClassInv.ShowStock();
                    string PurchaseInput = Convert.ToString(Console.ReadLine());
                    if (FoodItems.Equals(PurchaseInput) || DrinkItems.Equals(PurchaseInput) || SnackItems.Equals(PurchaseInput))
                    {
                        int price;
                        if (FoodItems.TryGetValue(PurchaseInput, out price) || DrinkItems.TryGetValue(PurchaseInput, out price) || SnackItems.TryGetValue(PurchaseInput, out price))
                        {
                            int CheckPrice = Convert.ToInt32(price);
                            if (MoneyPool.money >= CheckPrice)
                            {
                                Console.WriteLine("You add " + PurchaseInput + " to your items.");
                                Inventory.MyItems.Add(PurchaseInput);
                                MoneyPool.money = MoneyPool.money - CheckPrice;
                                Console.WriteLine("Your change is " + MoneyPool.money);
                                MoneyPool.money = 0;

                                Console.ReadKey();
                                isRunning = false;
                                //Om den hittar en som passar så ska den sparas i en lokal variabel så priset kan kollas och subtraheras ifrån vad användaren har.
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money to purchase that product.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            isRunning = false;
                        }                  
                    }
                    else
                    {
                        Console.WriteLine("You entered the wrong product.");
                        Console.ReadKey();
                        Console.Clear();
                        isRunning = false;
                    }
                }               
            }
            public virtual void Inspect()
            {
                foreach (KeyValuePair<string, int> pair in base.FoodItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                };
                foreach (KeyValuePair<string, int> pair in base.DrinkItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                }
                foreach (KeyValuePair<string, int> pair in base.SnackItems)
                {
                    Console.WriteLine(pair.Key, pair.Value);
                }
            }
            public virtual void Use()
            {
                Console.WriteLine("What do you want to consume?");
                Inventory.MyInventory();
                string ConsumeItem = Convert.ToString(Console.ReadLine());
                if (FoodItems.Equals(ConsumeItem))
                {
                    Console.WriteLine("You eat " + ConsumeItem);
                    Inventory.MyItems.Remove(ConsumeItem);
                }
                else if (DrinkItems.Equals(ConsumeItem))
                {
                    Console.WriteLine("You drink " + ConsumeItem);
                    Inventory.MyItems.Remove(ConsumeItem);
                }
                else if (SnackItems.Equals(ConsumeItem))
                {
                    Console.WriteLine("You snack on " + ConsumeItem);
                    Inventory.MyItems.Remove(ConsumeItem);
                }
                else
                {
                    Console.WriteLine("you don't have the item in your inventory.");
                }
                //Jämnför input med vad som finns i dictionaries. Stämmer det så ska den ge tillbaka en string beroende på vilken dictionary som ger "true". Ta bort saken från inventory.
            }
        }
        public abstract class Stock
        {
            public Dictionary<string, int> FoodItems = new Dictionary<string, int>()
            {
                {"Sandwich", 25},
                {"Cookie", 8},
                {"Nutrition bar", 15}
            };
            public Dictionary<string, int> DrinkItems = new Dictionary<string, int>()
            {
                {"Soda", 15},
                {"Juice", 10},
                {"Water", 20},
                {"Carbonated Water", 25}
            };
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
