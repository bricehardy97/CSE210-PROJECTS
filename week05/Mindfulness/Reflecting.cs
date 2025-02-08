class Reflecting:Activity
{
    public List<string> _prompts;
    public List<string> _questions;
    public Reflecting ():base("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
        _prompts = new List<string>();
        _questions = new List<string>();

         _prompts = new List<string>();
        _prompts.Add ("Think of a time when you stood up for someone else.");
        _prompts.Add ("Think of a time when you did something really difficult.");
        _prompts.Add ("Think of a time when you helped someone in need.");
        _prompts.Add ("Think of a time when you did something truly selfless.");

         _questions = new List<string>();
        _questions.Add ("Why was this experience meaningful to you?");
        _questions.Add ("Have you ever done anything like this before?");
        _questions.Add ("How did you get started?");
        _questions.Add ("How did you feel when it was complete?");

    }

    public override void Run() {
        Console.WriteLine("We are running the Reflecting activity!");
    }

}