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
                { 1, new Product(1, "Milk", 5.99m, "Organic Milk") },
                { 2, new Product(2, "Bread", 10.99m, "Wheat Bread") },
                { 3, new Product(3, "Chicken", 20.99m, "BBQ Chicken") }
            };

            // TODO FIX STORE FILE TO USE DICTIONARY
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
                if (userChoice == "W" && storeDictionary.ContainsKey(Walmart.StoreId))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Walmart was selected");
                    isValidStore = true;
                }
                else if (userChoice == "K" && storeDictionary.ContainsKey(Kroger.StoreId))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Kroger was selected");
                    isValidStore = true;
                }
                else if (userChoice == "H" && storeDictionary.ContainsKey(HEB.StoreId))
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
