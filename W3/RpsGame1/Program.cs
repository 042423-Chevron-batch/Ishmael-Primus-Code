using System;

namespace RpsGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there. Please enter your name.");
            string name = Console.ReadLine();

            int userWins = 0;
            int compWins = 0;
            int ties = 0;
            int rounds = 0;

            while (userWins < 2 && compWins < 2)
            {
                rounds++;
                Console.WriteLine($"\nRound {rounds}");
                Console.WriteLine("Please enter R, P, or S for Rock, Paper, or Scissors.");
                string userChoice = Console.ReadLine().ToUpper();

                // hard-code the computer's choice.
                char compChoice = 'P';

                // Compare the results with the computer's hard-coded choice.
                if (userChoice == "R" && compChoice.ToString().Equals("P"))
                {
                    // Computer wins
                    Console.WriteLine($"Doh! {name}, bruh... The computer won");
                    compWins++;
                }
                else if (userChoice == "S" && compChoice.ToString().Equals("P"))
                {
                    // User wins
                    Console.WriteLine($"YAAAAS!!! {name}, bruh... The user won");
                    userWins++;
                }
                else
                {
                    // Tie
                    Console.WriteLine($"Close!! {name}, bruh... It was a tie.");
                    ties++;
                }
            }

            Console.WriteLine("\nGame over!");

            if (userWins > compWins)
            {
                Console.WriteLine($"Congratulations, {name}! You won the game with {userWins} wins.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}. The computer won the game with {compWins} wins.");
            }

            Console.WriteLine($"Total rounds played: {rounds}");
            Console.WriteLine($"User wins: {userWins}");
            Console.WriteLine($"Computer wins: {compWins}");
            Console.WriteLine($"Ties: {ties}");
        }
    }
}
