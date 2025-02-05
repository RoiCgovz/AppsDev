using System;
using System.Collections.Generic;
using System.Linq;
namespace GroceryCalculationApp
{
    class GroceryStoreDiscountCalculator
    {
        static void Main()
        {
            string continueShopping;
            List<Product> shoppingCart = new List<Product>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Grocery Store!");
                Console.WriteLine("1. Start Shopping");
                Console.WriteLine("2. View Cart & Checkout");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string mainMenuChoice = Console.ReadLine();

                if (mainMenuChoice == "1")
                {
                    do
                    {
                        Console.Clear();
                        ProductCategory.DisplayCategories();

                        Console.Write("Choose a category (1-6): ");
                        int categoryChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.Clear();
                        if (categoryChoice >= 0 && categoryChoice < 6)
                        {
                            string categoryName = ProductCategory.GetCategoryName(categoryChoice);
                            LinkedList<Product> products = ProductCategory.GetProductsInCategory(categoryChoice);

                            Console.WriteLine($"Products in {categoryName} category:");
                            int index = 1;
                            foreach (var product in products)
                            {
                                Console.WriteLine($"{index}. {product.Name} - ${product.Price:F2}");
                                index++;
                            }

                            Console.Write("Choose a product: ");
                            int productChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (productChoice >= 0 && productChoice < products.Count)
                            {
                                var selectedProduct = GetProductByIndex(products, productChoice);

                                Console.Write("Enter the quantity: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());

                                var existingProduct = shoppingCart.FirstOrDefault(p => p.Name == selectedProduct.Name);

                                if (existingProduct != null)
                                {
                                    
                                    existingProduct.Quantity += quantity;
                                }
                                else
                                {                                  
                                    shoppingCart.Add(new Product(selectedProduct.Name, selectedProduct.Price, quantity));
                                }

                                Console.WriteLine($"You added {quantity} {selectedProduct.Name}(s) to your cart.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid product choice.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid category choice.");
                        }

                        while (true) 
                        {
                            Console.Write("Would you like to add another item? (y/n): ");
                            continueShopping = Console.ReadLine().ToLower();

                            if (continueShopping == "y")
                            {
                                break; 
                            }
                            else if (continueShopping == "n")
                            {
                               
                                break;
                            }
                            else
                            {

                                Console.WriteLine("Invalid input. Please enter 'y' to continue shopping or 'n' to return to the main menu.");
                            }
                        }

                        if (continueShopping == "n")
                        {
                            break;  
                        }

                    } while (continueShopping == "y");
                }
                else if (mainMenuChoice == "2")
                {
                    double grandTotal = shoppingCart.Sum(p => p.Price * p.Quantity);
                    Receipt.GenerateReceipt(shoppingCart, grandTotal);
                }
                else if (mainMenuChoice == "3")
                {
                    Console.WriteLine("Thank you for shopping with us!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                    Console.ReadKey();
                }
            }
        }

        static Product GetProductByIndex(LinkedList<Product> products, int index)
        {
            int i = 0;
            foreach (var product in products)
            {
                if (i == index)
                    return product;
                i++;
            }
            return null;
        }
    }
}
