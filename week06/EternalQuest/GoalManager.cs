
public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int TotalPoints { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void Start()
    {
        string command;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
            }
        } while (command != "7");
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (simple/eternal/checklist): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        if (type == "simple")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == "eternal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (type == "checklist")
        {
            Console.Write("Enter target completion count: ");
            int target = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target);
        }

        Goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        ListGoals();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Goals[goalIndex].RecordEvent();
        }
    }

    private void ListGoals()
    {
        int index = 1;
        foreach (var goal in Goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    private void ShowScore()
    {
        TotalPoints = 0;
        foreach (var goal in Goals)
        {
            if (goal.IsComplete()) TotalPoints += goal.Points;
        }
        Console.WriteLine($"Your total score: {TotalPoints} points");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in Goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts[3] == "Eternal")
                {
                    Goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
                }
                else if (parts[3] == "Checklist")
                {
                    Goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[4])));
                }
                else
                {
                    Goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2])));
                }
            }
        }
        Console.WriteLine("Goals loaded!");
    }
}