class Program
{
    static void Main(string[] args)
    {
        Breathing breathingActivity = new Breathing();
        Reflecting reflectingActivity = new Reflecting();
        Listing listingActivity = new Listing();

        bool _isrunning = true;
        while (_isrunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                breathingActivity.Run();
            }
            else if (response == "2")
            {
                reflectingActivity.Run();
            }
            else if (response == "3")
            {
                listingActivity.Run();
            }
            else if (response == "4")
            {
                _isrunning = false;
            }
            else
            {
                Console.WriteLine("Sorry, wrong response. Please enter a number between 1 and 4.");
            }
        }
    }

    public static void DisplaySpinner(int animationLoop, int frameSpeed)
    {
        for (int i = 0; i < animationLoop; i++)
        {
            Console.Write("-");
            Console.Write("\b");
            Thread.Sleep(frameSpeed);
            Console.Write("\\");
            Console.Write("\b");
            Thread.Sleep(frameSpeed);

            Console.Write("|");
            Console.Write("\b");
            Thread.Sleep(frameSpeed);

            Console.Write("/");
            Console.Write("\b");
            Thread.Sleep(frameSpeed);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public static void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
        }
    }
}