// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static void IfStatement(string[] args)
{
    if (args.Length == 0)
    {
        Console.WriteLine("There are no arguments.");
    }
    else
    {
        Console.WriteLine("There is at least one argument.");
    }
}