public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name}: {Description} (Eternal)";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}|{Description}|{Points}|Eternal";
    }
}