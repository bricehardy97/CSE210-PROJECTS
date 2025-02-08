using System.Reflection;

class Listing : Activity {
    public List <string> _messages;

    public Listing ():base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _messages = new List<string>();
        _messages.Add ("Who are people that you appreciate?");
        _messages.Add ("What are personal strengths of yours?");
        _messages.Add ("Who are people that you have helped this week?");
        _messages.Add ("When have you felt the Holy Ghost this month?");
        _messages.Add ("Who are some of your personal heroes?");

    }

    public override void Run() {
        Console.WriteLine("We are running the Listing activity!");
    }

}