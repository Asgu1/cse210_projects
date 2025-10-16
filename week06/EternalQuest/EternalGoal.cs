using System;

public class EternalGoal : Goal
{
	public EternalGoal(string name, string description, int points)
		: base(name, description, points)
	{
	}

	public override int RecordEvent()
	{
		return Points; // never complete, always awards points
	}

	public override bool IsComplete() => false;

	public override string GetStatusText()
	{
		return $"[∞] {Name} ({Description})";
	}

	public override string Serialize()
	{
		return $"Eternal|{Name}|{Description}|{Points}";
	}

	public static EternalGoal Deserialize(string[] parts)
	{
		// Eternal|Name|Desc|Points
		string name = parts[1];
		string desc = parts[2];
		int pts = int.Parse(parts[3]);
		return new EternalGoal(name, desc, pts);
	}
}


