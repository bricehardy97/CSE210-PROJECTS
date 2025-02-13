class Breathing : Activity
{
    public Breathing()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine(GetDescription());
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPreparing to start...\n");
        Program.DisplaySpinner(3, 250);

        for (int i = 0; i < time; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(500);
            Program.DisplaySpinner(1, 250);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(500);
            Program.DisplaySpinner(1, 250);
        }

        Console.WriteLine("\nGreat job! You completed the Breathing Activity.");
        Console.WriteLine($"Time spent: {time} seconds");
        Program.Pause(3);
    }
}