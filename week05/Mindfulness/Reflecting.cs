class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Run()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity");
        Console.WriteLine(GetDescription());
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPreparing to start...\n");
        Program.DisplaySpinner(3, 250);

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
        Program.Pause(3);

        int elapsedTime = 0;
        while (elapsedTime < time)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine(_questions[questionIndex]);
            Program.Pause(5);
            elapsedTime += 5;
        }

        Console.WriteLine("\nGreat job! You completed the Reflecting Activity.");
        Console.WriteLine($"Time spent: {time} seconds");
        Program.Pause(3);
    }
}
