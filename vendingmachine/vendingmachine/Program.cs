using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static vendingmachine.Classes;

namespace vendingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Run = true;
            while (Run)
            {
                Inventory Inventory = new Inventory();
                Basic Basic = new Basic();
                Console.WriteLine("Welcome to the vending machine.");
                Console.WriteLine("\t[1] Inspect what's in the machine.");
                Console.WriteLine("\t[2] Put in money in the machine");
                Console.WriteLine("\t[3] Purchase something.");
                Console.WriteLine("\t[4] Consume something you have.");
                Console.WriteLine("\t[5] Step away from the machine.");
                int Choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (Choice)
                    {
                        case 1:
                            Inventory.ShowStock();
                            break;
                        case 2:
                            MoneyPool.AddMoney();
                            break;
                        case 3:
                            Basic.Purchase();
                            break;
                        case 4:
                            Basic.Use();
                            break;
                        case 5:
                            Run = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a proper value.");
                }
            }      
        }
    }
}
