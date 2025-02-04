using GroceryCalculationApp;
using System;

namespace GroceryStoreDiscountCalculator
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Crud crud = new Crud();
            Item items;
            while (true)
            {
                Console.WriteLine("\n***** WELCOME TO THE GROCERY STORE DISCOUNT CALCULATOR *****");
                Console.WriteLine("\n********** Categories **********");
                Console.WriteLine("\n*** 1: Grain Products ***");
                Console.WriteLine("\n*** 2: Dairy Products ***");
                Console.WriteLine("3: Meat Products");
                Console.WriteLine("4: Baking Products");
                Console.WriteLine("5: Toiletries");
                Console.WriteLine("6: Beverages");
                Console.WriteLine("7: Canned Goods");
                Console.WriteLine("8: Snacks");
                Console.WriteLine("x: Exit Program");

                string input = Console.ReadLine();
                if (input.Equals("x"))
                    break;

                switch (input)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":
                        break;
                    case "4":
                        break; ;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}