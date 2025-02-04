using GroceryCalculationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCalculationApp
{
    public class Item
    { 
            public string Name { get; set; }
            public int Qty { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }

            public Item(string name, int qty, double price, string category)
            {
                Name = name;
                Qty = qty;
                Price = price;
                Category = category;
            }

    }
}
