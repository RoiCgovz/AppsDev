using System;
using System.Collections;

namespace GroceryCalculationApp
{
    internal class Crud
    {
        Item items;
        public static ArrayList Items = new ArrayList();
        public static void AddItem()
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Items.Add(new Item(name, qty, price));
            Console.WriteLine("Item added!");
        }

        public static void DisplayItems()
        {
            Console.WriteLine("\nProducts:");
            int index = 1;
            foreach (Item i in Items)
            {
                Console.WriteLine($"{index++}.) {i.name.PadRight(20)} | ${i.price,5} | x{i.qty,3}");
            }
        }
        public static void DeleteItems(string )
        {
            foreach (Item i in Items)
            {
                if
            }
        }
    }
}

