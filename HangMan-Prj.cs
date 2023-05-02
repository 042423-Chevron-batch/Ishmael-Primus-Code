// Hangman

Console.Write("Enter a letter:");

// Declare a string variable containing the word "example"
string myWord = "cat"; 

int numTries = 6;
bool match = false;
 
// Convert the string to a char array using the ToCharArray() method
char[] WordArray = myWord.ToCharArray(); 

while (numTries > 0 && !match)
{
    string LetterInput = Console.Readline();
    char inputChar = Console.ReadKey().KeyChar;
    Console.WriteLine();

}