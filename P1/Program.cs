using System;
using System.Collections.Generic;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to store the products with their quantities
            Dictionary<int, Product> productDictionary = new Dictionary<int, Product>
            {
                { 1, new Product(1, "Milk", 5.99m, "Organic Milk", new Dictionary<Store, int>()) },
                { 2, new Product(2, "Bread", 10.99m, "Wheat Bread", new Dictionary<Store, int>()) },
                { 3, new Product(3, "Chicken", 20.99m, "BBQ Chicken", new Dictionary<Store, int>()) }
            };

            // Create a dictionary to store stores with integer keys
            Dictionary<int, Store> storeDictionary = new Dictionary<int, Store>();

            // Create store objects
            Store Walmart = new Store(1, "Houston");
            Store Kroger = new Store(2, "Sugar Land");
            Store HEB = new Store(3, "Cypress");

            // Add store objects to the dictionary
            storeDictionary.Add(Walmart.StoreId, Walmart);
            storeDictionary.Add(Kroger.StoreId, Kroger);
            storeDictionary.Add(HEB.StoreId, HEB);

            // Link quantities of Product 1 to Walmart, Kroger, and HEB
            productDictionary[1].Quantities[Walmart] = 4;
            productDictionary[1].Quantities[Kroger] = 4;
            productDictionary[1].Quantities[HEB] = 2;

            // Link quantities of Product 2
            productDictionary[2].Quantities[Walmart] = 9;
            productDictionary[2].Quantities[Kroger] = 9;
            productDictionary[2].Quantities[HEB] = 9;

            // Link quantities of Product 3
            productDictionary[3].Quantities[Walmart] = 3;
            productDictionary[3].Quantities[Kroger] = 3;
            productDictionary[3].Quantities[HEB] = 3;


            // Start the app
            Console.WriteLine("Hello there, please enter your first and last name.");
            string names = Console.ReadLine();

            // Divide the string delimited by a space
            string[] namesArr = names.Split(' ');

            bool isValidStore = false;
            Store selectedStore = null;
            do
            {
                Console.WriteLine("Thank you. Please choose a store from the list:\n" +
                                  "1. Walmart\n" +
                                  "2. Kroger\n" +
                                  "3. HEB");

                string userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int storeId) && storeDictionary.ContainsKey(storeId))
                {
                    selectedStore = storeDictionary[storeId];
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, {selectedStore.Location} was selected");
                    isValidStore = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (!isValidStore);

            List<Order> cart = new List<Order>();
            bool isAddingProducts = true;
            while (isAddingProducts)
            {
                Console.WriteLine("\nPlease choose a product from the list or enter '0' to checkout:\n" +
                                  "1. Milk\n" +
                                  "2. Bread\n" +
                                  "3. Chicken");

                string userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int productId) && productDictionary.ContainsKey(productId))
                {
                    Product selectedProduct = productDictionary[productId];

                    Console.WriteLine($"Enter the quantity of {selectedProduct.Name}:");

                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                    {
                        if (selectedProduct.Quantities.ContainsKey(selectedStore) && selectedProduct.Quantities[selectedStore] >= quantity)
                        {
                            selectedProduct.Quantities[selectedStore] -= quantity; // Deduct the selected quantity from the available quantity
                            cart.Add(new Order
                            {
                                OrderId = Guid.NewGuid(), // Generate a new Guid for the OrderId
                                Store = selectedStore,
                                Product = selectedProduct,
                                Customer = new Customer(namesArr[0], namesArr[1]),
                                Quantity = quantity,
                                OrderTime = DateTime.Now

                            });

                            Console.WriteLine($"{quantity} {selectedProduct.Name} added to the cart.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient quantity. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Please try again.");
                    }
                }
                else if (userChoice == "0")
                {
                    isAddingProducts = false;
                    Console.WriteLine("\nCheckout:");
                    Console.WriteLine($"Customer: {namesArr[0]} {namesArr[1]}");
                    Console.WriteLine($"Store: {selectedStore.Location}");

                    decimal totalAmount = 0m;
                    foreach (var order in cart)
                    {
                        decimal orderAmount = order.Quantity * order.Product.Price;
                        Console.WriteLine($"{order.Product.Name} x {order.Quantity} = ${orderAmount}");
                        totalAmount += orderAmount;
                    }

                    Console.WriteLine($"Total: ${totalAmount}");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            Console.WriteLine("End!");
        }
    }
}
