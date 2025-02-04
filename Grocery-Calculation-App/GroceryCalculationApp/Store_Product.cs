using GroceryCalculationApp;
using System;
using System.Collections.Generic;

namespace GroceryCalculationApp
{
    public class Store_Products
    {
        private static void DisplayProducts(string category, Dictionary<string, double> products)
        {
            Console.WriteLine($"\n*** {category} ***");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product.Key} - ${product.Value:F2}");
            }
            Console.WriteLine(new string('-', 30)); // Adds a separator line
        }

        public static void MeatProd()
        {
            Dictionary<string, double> meatProducts = new Dictionary<string, double>
            {
                { "Chicken", 5.99 },
                { "Beef", 10.49 },
                { "Pork", 7.99 },
                { "Lamb", 12.99 },
                { "Fish", 9.49 }
            };
            DisplayProducts("Meat Products", meatProducts);
        }

        public static void DairyProd()
        {
            Dictionary<string, double> dairyProducts = new Dictionary<string, double>
            {
                { "Milk", 3.49 },
                { "Cheese", 4.99 },
                { "Butter", 2.99 },
                { "Yogurt", 1.99 }
            };
            DisplayProducts("Dairy Products", dairyProducts);
        }

        public static void VegetableProd()
        {
            Dictionary<string, double> vegetableProducts = new Dictionary<string, double>
            {
                { "Carrot", 1.29 },
                { "Broccoli", 2.49 },
                { "Spinach", 1.99 },
                { "Tomato", 2.99 },
                { "Cucumber", 1.79 }
            };
            DisplayProducts("Vegetable Products", vegetableProducts);
        }
    }
}

