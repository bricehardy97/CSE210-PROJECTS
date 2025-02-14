public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int Completed { get; private set; }

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        Target = target;
        Completed = 0;
    }

    public override void RecordEvent()
    {
        if (Completed < Target)
        {
            Completed++;
            int earnedPoints = Points;
            if (Completed == Target) earnedPoints += 500; // Bonus on completion
            Console.WriteLine($"Goal '{Name}' recorded! You earned {earnedPoints} points.");
        }
    }

    public override bool IsComplete()
    {
        return Completed >= Target;
    }

    public override string GetDetailsString()
    {
        return IsComplete() 
            ? $"[X] {Name}: {Description} - Completed {Completed}/{Target} times" 
            : $"[ ] {Name}: {Description} - Completed {Completed}/{Target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}|{Description}|{Points}|Checklist|{Target}|{Completed}";
    }
}