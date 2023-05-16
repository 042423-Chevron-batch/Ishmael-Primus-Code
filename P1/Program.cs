// May 15th TODO create prototype implementing the created classes
using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, please enter your first and last name.");
            string names = Console.ReadLine();

            // divide the string delimited by a space
            string[] namesArr = names!.Split(' ');
            char Sugarland = 'S';
            char Woodlands = 'W';
            char Cypress = 'C';

            // start the app
            do
            {
                try
                {
                Console.WriteLine(
                "Thank you. Please choose a store from the list:\n S. Sugarland\n W. Woodlands\n C. Cypress");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"There was an exception => {ex.Message}");
                }

                string? userChoice = null;
                int wrong = 0;
                do
                {
                    if (wrong > 0)
                    {
                        Console.WriteLine(
                            "Please follow directions. Please choose a store from the list:\n S. Sugarland\n W. Woodlands\n C. Cypress"
                        );
                    }
                    userChoice = Console.ReadLine()?.ToUpper();
                    wrong++;
                } while (
                    !userChoice!.Equals("S") && !userChoice.Equals("W") && !userChoice.Equals("C")
                );

                // Perform individual actions if either store is selected
                if (userChoice == "S" && Sugarland.ToString().Equals("S"))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Sugarland was selected");
                    break;
                }
                else if (userChoice == "W" && Woodlands.ToString().Equals("W"))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Woodlands was selected");
                    break;
                }
                else if (userChoice == "C" && Cypress.ToString().Equals("C"))
                {
                    Console.WriteLine($"{namesArr[0]} {namesArr[1]}, Cypress was selected");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }
            } while (true);
            {
                Console.WriteLine("End!");
            }
        }
    }
}
