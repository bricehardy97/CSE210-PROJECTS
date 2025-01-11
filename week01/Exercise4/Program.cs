using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> randomNumbers = new List<int>();

        int number = -1;
        while (number != 0)
        {
            Console.Write ("Enter any number or press 0 to quit : ");

            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number!= 0)
            {
                randomNumbers.Add(number);
            }
        }
        int sum =0;
        foreach (int answer in randomNumbers)
        {
            sum += answer;
        }
        Console.WriteLine ($"The sum of your listed items is : {sum}");

        float average = ((float)sum) / randomNumbers.Count;
        Console.WriteLine($"The average of your listed items is {average}");

        int largest = randomNumbers[0];

        foreach (int answer in randomNumbers)
        {
            if (answer > largest)
            {
                largest = answer;
            }
        }
        Console.WriteLine ($"The largest number in your list is : {largest}");



    }
}