// Hangman game

        // Declare the word to match
        string wordToMatch = "cat";
        
        // Convert the word to match to a char array
        char[] wordArray = wordToMatch.ToCharArray();
        
        // Declare an array to store the matches
        char[] matches = new char[wordToMatch.Length];
        for (int i = 0; i < matches.Length; i++)
        {
            matches[i] = '_';
        }
        
        // Declare variables to track the number of tries and whether the word has been matched
        int numTries = 6;
        bool wordMatched = false;
        
        // Loop through each try
        while (numTries > 0 && !wordMatched)
        {
            Console.WriteLine($"You have {numTries} tries remaining.");
            
            // Prompt the user to enter a character
            Console.WriteLine("Enter a 'l' for a letter or a 'w' for a word: ");
            string choice = Console.Readline;
            if (choice == "w") {
                Console.WriteLine("Enter a word: ");
                string word = Console.Readline;
                word == wordToMatch;
                Console.WriteLine("You win! ")
            }
            else if (choice == "l") {
                Console.WriteLine("Enter a letter for a word: ")
                char inputChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
            
                 // Check if the input character matches any character in the word
                bool foundMatch = false;
                for (int j = 0; j < wordArray.Length; j++)
                {
                    if (inputChar == wordArray[j])
                    {
                        matches[j] = inputChar;
                        foundMatch = true;
                }
            
                // Display the matches so far
                 Console.WriteLine(matches);
            
                // If a match was found, display a message
                if (foundMatch)
                {
                    Console.WriteLine($"The character {inputChar} was found.");
                }
            
                // Check if the word has been completely matched
                 if (new string(matches) == wordToMatch)
                 {
                     wordMatched = true;
                    Console.WriteLine("Congratulations, you matched the word!");
                }
            
                 // Decrement the number of tries
                numTries--;
        
                 // If the word was not matched, display a message
                if (!wordMatched)
                {
                    Console.WriteLine($"You did not match the word \"{wordToMatch}\".");
                    }
                }
            }
            else {
                 Console.WriteLine("Invalid choice: ")
                 }
            }
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
