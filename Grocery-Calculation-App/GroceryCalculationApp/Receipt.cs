using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryCalculationApp
{
    class Receipt
    {
        public static void GenerateReceipt(List<Product> shopCart, double grandTotal)
        {
            double finalTotal = 0;
            double discountPercent, discountAmount, finalAmount, totalPrice;

            Console.Clear();
            Console.WriteLine("\n----- Grocery Store Receipt -----");
            Console.WriteLine("Name of Product       Price   Quantity  Total");
            Console.WriteLine("------------------------------------------------");

            var mergedCart = shopCart
                .GroupBy(p => p.Name)
                .Select(g => new Product(g.Key, g.First().Price, g.Sum(p => p.Quantity))) 
                .ToList();

            foreach (var product in mergedCart)
            {
                totalPrice = product.Price * product.Quantity;
                finalTotal += totalPrice;
                Console.WriteLine($"{product.Name.PadRight(20)} ${product.Price:F2}    x{product.Quantity}    ${totalPrice:F2}");
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Grand Total: $" + finalTotal.ToString("F2"));

            discountPercent = finalTotal > 500 ? 20 : finalTotal > 200 ? 15 : finalTotal > 100 ? 10 : 0;
            discountAmount = finalTotal * discountPercent / 100;
            finalAmount = finalTotal - discountAmount;

            Console.WriteLine("Discount applied: " + discountPercent + "%" + "\nDiscount amount: $" + discountAmount.ToString("F2") + "\nFinal amount to be paid: $" + finalAmount.ToString("F2"));
            Console.WriteLine("\nPlease Pay to The Counter if you are done. \n\nThank you!");
            Console.Write("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}
