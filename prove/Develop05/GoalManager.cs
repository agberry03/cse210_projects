public class GoalManager
{
    private List<Goal> _createdGoals = new List<Goal>();
    private int _totalScore;
    // Level attribute.
    private int _level = 1;
    // Points to next level attribute.
    private int _levelupPoints = 100;

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
        // Display current level.
        Console.WriteLine($"You are level {_level}.");
        // Display points to next level up.
        Console.WriteLine($"Points to next level up: {_levelupPoints - _totalScore}");
    }
    public void CreateGoal(string goalType, string goalName, string goalDescription, int goalPoints)
    {
        if (goalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _createdGoals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _createdGoals.Add(eternalGoal);
        }
    }
    public void CreateGoal(string goalName, string goalDescription, int goalPoints, int completionAmount, int bonusPoints)
    {
        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, completionAmount, bonusPoints);
        _createdGoals.Add(checklistGoal);
    }
    public void ShowGoalList()
    {
        int i = 1;
        foreach (Goal goal in _createdGoals)
        {
            Console.WriteLine($"{i}. {goal.GetDisplayString()}");
            i++;
        }
    }
    public void ShowGoalSelection()
    {
        int i = 1;
        foreach (Goal goal in _createdGoals)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
    }
    public void RecordEvent(int listNumber)
    {
        _totalScore += _createdGoals[listNumber - 1].RecordEvent();
        Console.WriteLine($"You now have {_totalScore} points.");
        LevelUp();
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalScore}");
            // Save level.
            outputFile.WriteLine($"{_level}");
            // Save points to next level.
            outputFile.WriteLine($"{_levelupPoints}");

            foreach (Goal goal in _createdGoals)
            {
                outputFile.WriteLine($"{goal.GetType()}:{goal.GetStringRepresentation()}");
            }
        }
    }
    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _totalScore = int.Parse(lines[0]);
        // Load level.
        _level = int.Parse(lines[1]);
        // Load level up points.
        _levelupPoints = int.Parse(lines[2]);

        for ( int i = 3; i < lines.Length; i++)
        {
            string line = lines[i];

            if (line == lines[0])
            {
                continue;
            }

            string[] split1 = line.Split(":");
            string[] split2 = split1[1].Split(",");

            if (split1[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(split2[0], split2[1], int.Parse(split2[2]), bool.Parse(split2[3]));
                _createdGoals.Add(simpleGoal);
            }
            if (split1[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(split2[0], split2[1], int.Parse(split2[2]));
                _createdGoals.Add(eternalGoal);
            }
            if (split1[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(split2[0], split2[1], int.Parse(split2[2]), int.Parse(split2[3]), int.Parse(split2[4]), int.Parse(split2[5]));
                _createdGoals.Add(checklistGoal);
            }
        }
    }
    // Level up method.
    public void LevelUp()
    {
        while (_totalScore >= _levelupPoints)
        {
            if (_totalScore >= _levelupPoints)
            {
                _level++;
                _levelupPoints = (int)((int)_levelupPoints * 1.5);
                Console.WriteLine("Congratulations! You leveled up!");
                Console.WriteLine($"You are now level {_level}.");
            }
        }
        
    }
}