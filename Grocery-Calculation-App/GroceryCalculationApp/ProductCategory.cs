using System;
using System.Collections.Generic;
using GroceryCalculationApp;

public class ProductCategory
{
    private static List<LinkedList<Product>> productCategories = new List<LinkedList<Product>>();
    static ProductCategory()
    {
     
        LinkedList<Product> dairy = new LinkedList<Product>();
        dairy.AddLast(new Product("Milk", 3.50));
        dairy.AddLast(new Product("Cheese", 5.00));
        dairy.AddLast(new Product("Yogurt", 2.50));
        productCategories.Add(dairy);

        LinkedList<Product> bakery = new LinkedList<Product>();
        bakery.AddLast(new Product("Bread", 2.00));
        bakery.AddLast(new Product("Croissant", 1.50));
        bakery.AddLast(new Product("Bagels", 3.00));
        productCategories.Add(bakery);

      
        LinkedList<Product> produce = new LinkedList<Product>();
        produce.AddLast(new Product("Apple", 0.75));
        produce.AddLast(new Product("Banana", 0.50));
        produce.AddLast(new Product("Carrot", 1.20));
        productCategories.Add(produce);

        LinkedList<Product> beverages = new LinkedList<Product>();
        beverages.AddLast(new Product("Juice", 3.00));
        beverages.AddLast(new Product("Coffee", 5.00));
        beverages.AddLast(new Product("Tea", 2.50));
        productCategories.Add(beverages);


        LinkedList<Product> snacks = new LinkedList<Product>();
        snacks.AddLast(new Product("Chips", 1.50));
        snacks.AddLast(new Product("Cookies", 2.50));
        snacks.AddLast(new Product("Nuts", 3.00));
        productCategories.Add(snacks);

       
        LinkedList<Product> grains = new LinkedList<Product>();
        grains.AddLast(new Product("Rice", 2.00));
        grains.AddLast(new Product("Wheat", 1.80));
        grains.AddLast(new Product("Barley", 2.50));
        productCategories.Add(grains);
    }

    public static void DisplayCategories()
    {
        Console.WriteLine("\nSelect a category:");
        Console.WriteLine("1. Dairy");
        Console.WriteLine("2. Bakery");
        Console.WriteLine("3. Produce");
        Console.WriteLine("4. Beverages");
        Console.WriteLine("5. Snacks");
        Console.WriteLine("6. Grains");
    }

    public static string GetCategoryName(int categoryIndex)
    {
        string[] categoryNames = { "Dairy", "Bakery", "Produce", "Beverages", "Snacks", "Grains" };

        if (categoryIndex >= 0 && categoryIndex < categoryNames.Length)
        {
            return categoryNames[categoryIndex];
        }
        return "Unknown";
    }

    public static LinkedList<Product> GetProductsInCategory(int categoryIndex)
    {
        if (categoryIndex >= 0 && categoryIndex < productCategories.Count)
        {
            return productCategories[categoryIndex];
        }
        return null;
    }
}    

