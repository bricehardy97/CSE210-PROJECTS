using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you receive?");
        string answer=Console.ReadLine();
        int grade = int.Parse(answer);

        string letter ="";

        if (grade >= 90)
        {
            letter ="A";
        }
        else if (grade >= 80)
        {
            letter= "B";
        }
        else if (grade >= 70)
        {
            letter ="C";
        } 
        else if (grade >= 70)
        {
            letter ="D";
        }
        else
        {
            letter ="F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine ("You Passed this course!");
        }
        else 
        {
            Console.WriteLine("Im sorry but you did not pass, please try again.");
        }
    }
}