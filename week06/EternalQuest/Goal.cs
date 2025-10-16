using System;

public abstract class Goal
{
	// Common props
	public string Name { get; private set; }
	public string Description { get; private set; }
	public int Points { get; private set; }

	protected Goal(string name, string description, int points)
	{
		Name = name;
		Description = description;
		Points = points;
	}

	// Returns points earned this record
	public abstract int RecordEvent();
	public abstract bool IsComplete();
	public abstract string GetStatusText();

	// Persistence
	public abstract string Serialize();
	public static Goal Deserialize(string line)
	{
		// format: Type|field1|field2|...
		var parts = line.Split('|');
		if (parts.Length < 4) throw new FormatException("Invalid goal line");
		string type = parts[0];
		switch (type)
		{
			case "Simple":
				return SimpleGoal.Deserialize(parts);
			case "Eternal":
				return EternalGoal.Deserialize(parts);
			case "Checklist":
				return ChecklistGoal.Deserialize(parts);
			default:
				throw new NotSupportedException($"Unknown goal type: {type}");
		}
	}
}


