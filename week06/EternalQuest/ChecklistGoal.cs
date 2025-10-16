using System;

public class ChecklistGoal : Goal
{
	private int _targetCount;
	private int _currentCount;
	private int _bonusPoints;

	public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
		: base(name, description, points)
	{
		_targetCount = targetCount;
		_bonusPoints = bonusPoints;
		_currentCount = currentCount;
	}

	public override int RecordEvent()
	{
		if (IsComplete()) return 0;
		_currentCount++;
		if (_currentCount >= _targetCount)
		{
			return Points + _bonusPoints;
		}
		return Points;
	}

	public override bool IsComplete() => _currentCount >= _targetCount;

	public override string GetStatusText()
	{
		string checkbox = IsComplete() ? "[X]" : "[ ]";
		return $"{checkbox} {Name} ({Description}) -- Completed {_currentCount}/{_targetCount}";
	}

	public override string Serialize()
	{
		return $"Checklist|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
	}

	public static ChecklistGoal Deserialize(string[] parts)
	{
		// Checklist|Name|Desc|Points|Target|Bonus|Current
		string name = parts[1];
		string desc = parts[2];
		int pts = int.Parse(parts[3]);
		int target = int.Parse(parts[4]);
		int bonus = int.Parse(parts[5]);
		int current = int.Parse(parts[6]);
		return new ChecklistGoal(name, desc, pts, target, bonus, current);
	}
}


