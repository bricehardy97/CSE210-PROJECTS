class Listing : Activity
{
    private List<string> _messages;

    public Listing()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _messages = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine(GetDescription());
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPreparing to start...\n");
        Program.DisplaySpinner(3, 250);

        Random random = new Random();
        int promptIndex = random.Next(_messages.Count);
        Console.WriteLine(_messages[promptIndex]);
        Program.Pause(3);

        Console.WriteLine("\nStart listing items:");
        List<string> userItems = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < time)
        {
            string item = Console.ReadLine();
            userItems.Add(item);
            elapsedTime++;
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items.");
        Console.WriteLine("\nGreat job! You completed the Listing Activity.");
        Console.WriteLine($"Time spent: {time} seconds");
        Program.Pause(3);
    }
}