using System;

public class SimpleGoal : Goal
{
	private bool _isComplete;

	public SimpleGoal(string name, string description, int points, bool isComplete = false)
		: base(name, description, points)
	{
		_isComplete = isComplete;
	}

	public override int RecordEvent()
	{
		if (_isComplete) return 0;
		_isComplete = true;
		return Points;
	}

	public override bool IsComplete() => _isComplete;

	public override string GetStatusText()
	{
		string checkbox = _isComplete ? "[X]" : "[ ]";
		return $"{checkbox} {Name} ({Description})";
	}

	public override string Serialize()
	{
		return $"Simple|{Name}|{Description}|{Points}|{_isComplete}";
	}

	public static SimpleGoal Deserialize(string[] parts)
	{
		// Simple|Name|Desc|Points|IsComplete
		string name = parts[1];
		string desc = parts[2];
		int pts = int.Parse(parts[3]);
		bool isComplete = bool.Parse(parts[4]);
		return new SimpleGoal(name, desc, pts, isComplete);
	}
}


