using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName ();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayAnswer(userName, squareNumber);
        
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favoirte number.");
        int favorite = int.Parse(Console.ReadLine());
        return favorite;
    }
    static int SquareNumber(int favorite)
    {
        int square = favorite * favorite;
        return square;
    }

    static void DisplayAnswer(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

       

    
    
} 