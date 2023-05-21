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
                { 1, new Product(1, "Milk", 5.99m, "Organic Milk", 10) },
                { 2, new Product(2, "Bread", 10.99m, "Wheat Bread", 5) },
                { 3, new Product(3, "Chicken", 20.99m, "BBQ Chicken", 15) }
            };

            // Create a dictionary to store stores with GUID ID
            Dictionary<Guid, StoreData> storeDictionary = new Dictionary<Guid, StoreData>();

            // Create store objects
            StoreData store1 = new StoreData { StoreId = Guid.NewGuid(), Name = "Walmart" };
            StoreData store2 = new StoreData { StoreId = Guid.NewGuid(), Name = "Kroger" };
            StoreData store3 = new StoreData { StoreId = Guid.NewGuid(), Name = "HEB" };

            // Add store objects to the dictionary
            storeDictionary.Add(store1.StoreId, store1);
            storeDictionary.Add(store2.StoreId, store2);
            storeDictionary.Add(store3.StoreId, store3);

            Console.WriteLine($"Hello there, please enter your first and last name.");
            string names = Console.ReadLine();

            // Divide the string delimited by a space
            string[] namesArr = names.Split(' ');

            // Start the app
            bool isValidStore = false;
            do
            {
                Console.WriteLine("Thank you. Please choose a store from the list:\n" +
                                  "W. Walmart\n" +
                                  "K. Kroger\n" +
                                  "H. HEB");

                string userChoice = Console.ReadLine()?.ToUpper();

                // Perform individual actions if a store is selected
                if (userChoice == "W" && storeDictionary.ContainsKey(store1.StoreId))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Walmart was selected");
                    isValidStore = true;
                }
                else if (userChoice == "K" && storeDictionary.ContainsKey(store2.StoreId))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Kroger was selected");
                    isValidStore = true;
                }
                else if (userChoice == "H" && storeDictionary.ContainsKey(store3.StoreId))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, HEB was selected");
                    isValidStore = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (!isValidStore);

            Console.WriteLine("End!");
        }
    }
}
