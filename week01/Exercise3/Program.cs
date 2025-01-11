using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber =randomGenerator.Next(1,100);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        
            if (magicNumber  > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Great Job you guessed the magic number!!");
            }
        }
    }
}
