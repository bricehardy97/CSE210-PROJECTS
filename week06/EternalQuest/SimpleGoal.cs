public class SimpleGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        }
    }

    public override bool IsComplete()
    {
        return IsCompleted;
    }

    public override string GetDetailsString()
    {
        return IsCompleted ? $"[X] {Name}: {Description}" : $"[ ] {Name}: {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}|{Description}|{Points}|{(IsCompleted ? "Completed" : "Incomplete")}";
    }
}