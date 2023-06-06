using Microsoft.AspNetCore.Mvc;

namespace Prj1ApiApp.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    
    [HttpGet("login/username/password")]
    public ActionResult<Person> Login(string username, string password)
    {
        return "Login successful";
    }
}
// using System;
// using System.Collections.Generic;
// using Prj1ApiModels;
// using Prj1ApiBusiness;
// using Prj1ApiRepository;

// namespace Prj1




// {
//     //this is equivalent to the website
//     class Program
//     {
//         static Dictionary<Guid, StoreData> storeDictionary;

//         static void Main(string[] args)
//         {
//             bool isRunning = true;

//             while (isRunning)
//             {
//                 Console.WriteLine("1. Log in");
//                 Console.WriteLine("2. Quit");

//                 Console.Write("Enter your choice: ");
//                 string choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         RunApp();
//                         break;
//                     case "2":
//                         isRunning = false;
//                         Console.WriteLine("Quitting the program...");
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice. Please try again.");
//                         break;
//                 }
//             }

//             Console.WriteLine("End!");
//         }

//         static void RunApp()
//         {
//             // Create a dictionary to store the products with their quantities
//             Dictionary<int, Product> productDictionary = new Dictionary<int, Product>
//             {
//                 { 1, new Product(1, "Milk", 5.99m, "Organic Milk", new Dictionary<StoreData, int>()) },
//                 { 2, new Product(2, "Bread", 10.99m, "Wheat Bread", new Dictionary<StoreData, int>()) },
//                 { 3, new Product(3, "Chicken", 20.99m, "BBQ Chicken", new Dictionary<StoreData, int>()) },
//             };

//             // Create a dictionary to store stores with GUID ID
//             storeDictionary = new Dictionary<Guid, StoreData>();

//             // Create store objects
//             StoreData store1 = new StoreData(Guid.NewGuid(), "Walmart");
//             StoreData store2 = new StoreData(Guid.NewGuid(), "Kroger");
//             StoreData store3 = new StoreData(Guid.NewGuid(), "HEB");

//             // Add store objects to the dictionary
//             storeDictionary.Add(store1.StoreId, store1);
//             storeDictionary.Add(store2.StoreId, store2);
//             storeDictionary.Add(store3.StoreId, store3);

//             // Set initial quantities for each store
//             foreach (var product in productDictionary.Values)
//             {
//                 product.Quantities[store1] = 10; // Set initial quantity for store1
//                 product.Quantities[store2] = 15; // Set initial quantity for store2
//                 product.Quantities[store3] = 20; // Set initial quantity for store3
//             }

//             bool isLoggedOut = false;
//             Guid orderId = Guid.Empty; // Order ID for the entire order
//             DateTime orderTime = DateTime.MinValue; // Order time for the entire order

//             while (!isLoggedOut)
//             {
//                 Console.WriteLine("Hello there, please enter your first and last name. Enter 'quit' to return to the main menu.");
//                 string names = Console.ReadLine(); // names is a string for user response

//                 // Check if the user wants to quit
//                 if (names.ToLower() == "quit")
//                 {
//                     isLoggedOut = true;
//                     continue;
//                 }

//                 // Split the names into first name and last name
//                 string[] namesArr = names.Split(' ');

//                 // Check if both first name and last name are provided
//                 if (namesArr.Length >= 2)
//                 {
//                     try
//                     {
//                         string fname = namesArr[0];
//                         string lname = namesArr[1];

//                         // Call the Test method in the Repository class
//                         int result = Repository.Test(fname, lname);

//                         // Check the result and proceed accordingly
//                         if (result > 0)
//                         {   
//                             Console.WriteLine("Customer registration successful.");
//                             // Register the user name
//                             Customer customer = new Customer(fname, lname);
//                             // Further processing or display the customer information
//                         }
//                         else
//                         {
//                             Console.WriteLine("Failed to register the customer.");
//                             // Handle the registration failure scenario
//                         }
//                     }
//                     catch (IndexOutOfRangeException)
//                     {
//                         Console.WriteLine("Invalid input. Please try again.");
//                     }
//                  }
//                 else
//                 {
//                         Console.WriteLine("Invalid input. Please enter both your first and last name.");
//             }


//                 // Divide the string delimited by a space
//                 //string[] namesArr = names.Split(' ');

//                 bool isValidStore = false;
//                 StoreData selectedStore = null;

//                 do
//                 {
//                     Console.WriteLine("Thank you. Please choose a store from the list:");
//                     Console.WriteLine("W. Walmart");
//                     Console.WriteLine("K. Kroger");
//                     Console.WriteLine("H. HEB");

//                     string userChoice = Console.ReadLine()?.ToUpper();

//                     if (userChoice == "W")
//                     {
//                         if (storeDictionary.ContainsKey(store1.StoreId))
//                         {
//                             selectedStore = storeDictionary[store1.StoreId];
//                             Console.WriteLine($"{namesArr[0]} {namesArr[1]}, {selectedStore.Name} was selected");
//                             isValidStore = true;
//                         }
//                     }
//                     else if (userChoice == "K")
//                     {
//                         if (storeDictionary.ContainsKey(store2.StoreId))
//                         {
//                             selectedStore = storeDictionary[store2.StoreId];
//                             Console.WriteLine($"{namesArr[0]} {namesArr[1]}, {selectedStore.Name} was selected");
//                             isValidStore = true;
//                         }
//                     }
//                     else if (userChoice == "H")
//                     {
//                         if (storeDictionary.ContainsKey(store3.StoreId))
//                         {
//                             selectedStore = storeDictionary[store3.StoreId];
//                             Console.WriteLine($"{namesArr[0]} {namesArr[1]}, {selectedStore.Name} was selected");
//                             isValidStore = true;
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid choice. Please try again.");
//                     }
//                 } while (!isValidStore);

//                 List<Order> cart = new List<Order>();
//                 bool isAddingProducts = true;
//                 decimal totalAmount = 0m;

//                 while (isAddingProducts)
//                 {
//                     Console.WriteLine("\nPlease choose a product from the list or enter '0' to checkout:");
//                     Console.WriteLine("1. Milk");
//                     Console.WriteLine("2. Bread");
//                     Console.WriteLine("3. Chicken");

//                     string userChoice = Console.ReadLine();

//                     if (int.TryParse(userChoice, out int productId) && productDictionary.ContainsKey(productId))
//                     {
//                         Product selectedProduct = productDictionary[productId];

//                         Console.WriteLine($"Enter the quantity of {selectedProduct.Name}:");

//                         if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
//                         {
//                             if (selectedProduct.Quantities.ContainsKey(selectedStore) && selectedProduct.Quantities[selectedStore] >= quantity)
//                             {
//                                 selectedProduct.Quantities[selectedStore] -= quantity; // Deduct the selected quantity from the available quantity
//                                 cart.Add(new Order
//                                 {
//                                     OrderId = orderId, // Use the same Order ID for each order in the cart
//                                     Store = selectedStore,
//                                     StoreLocation = StoreLocation.GetStoreLocation(selectedStore), // Get the store location from the StoreLocation class
//                                     Product = selectedProduct,
//                                     Customer = new Customer(namesArr[0], namesArr[1]),
//                                     Quantity = quantity,
//                                     OrderTime = orderTime // Use the same Order Time for each order in the cart
//                                 });

//                                 Console.WriteLine($"{quantity} {selectedProduct.Name} added to the cart.");
//                                 totalAmount += selectedProduct.Price * quantity; // Update the total amount
//                             }
//                             else
//                             {
//                                 Console.WriteLine("Insufficient quantity. Please try again.");
//                             }
//                         }
//                         else
//                         {
//                             Console.WriteLine("Invalid quantity. Please try again.");
//                         }
//                     }
//                     else if (userChoice == "0")
//                     {
//                         isAddingProducts = false;
//                         orderId = Guid.NewGuid(); // Generate a new Order ID for the next order
//                         orderTime = DateTime.Now; // Capture the current Order Time
//                         Console.WriteLine("\nCheckout:");
//                         Console.WriteLine($"Customer: {namesArr[0]} {namesArr[1]}");
//                         Console.WriteLine($"Store: {selectedStore.Name}");
//                         Console.WriteLine($"Store Location: {StoreLocation.GetStoreLocation(selectedStore)}");

//                         foreach (var order in cart)
//                         {
//                             Console.WriteLine($"{order.Product.Name} x {order.Quantity} = ${order.Product.Price * order.Quantity}");
//                         }

//                         Console.WriteLine($"Order ID: {orderId}"); // Display the Order ID for the entire order
//                         Console.WriteLine($"Order Time: {orderTime}"); // Display the Order Time for the entire order
//                         Console.WriteLine($"Total: ${totalAmount}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid choice. Please try again.");
//                     }
//                 }
//             }
//         }
//     }
// }

// TODO 6/2: Add CustomerID & Email to Db to manipulate, also modify the repo class to include these fields