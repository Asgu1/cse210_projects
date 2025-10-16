using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
	private readonly List<Goal> _goals = new List<Goal>();
	private int _score;

	// Simple gamification: level based on score
	public int Score => _score;
	public int Level => 1 + _score / 1000;

	public void AddGoal(Goal goal)
	{
		_goals.Add(goal);
	}

	public void ListGoals()
	{
		if (_goals.Count == 0)
		{
			Console.WriteLine("No goals yet.");
			return;
		}
		for (int i = 0; i < _goals.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {_goals[i].GetStatusText()}");
		}
	}

	public void RecordEvent(int goalIndex)
	{
		if (goalIndex < 0 || goalIndex >= _goals.Count)
		{
			Console.WriteLine("Invalid goal index.");
			return;
		}
		int earned = _goals[goalIndex].RecordEvent();
		_score += earned;
		Console.WriteLine($"You earned {earned} points! Total score: {_score}. Level: {Level}");
	}

	public void Save(string path)
	{
		using (var writer = new StreamWriter(path))
		{
			writer.WriteLine(_score);
			foreach (var g in _goals)
			{
				writer.WriteLine(g.Serialize());
			}
		}
		Console.WriteLine("Saved.");
	}

	public void Load(string path)
	{
		if (!File.Exists(path))
		{
			Console.WriteLine("File not found.");
			return;
		}
		_goals.Clear();
		var lines = File.ReadAllLines(path);
		if (lines.Length == 0) return;
		_score = int.Parse(lines[0]);
		for (int i = 1; i < lines.Length; i++)
		{
			if (string.IsNullOrWhiteSpace(lines[i])) continue;
			_goals.Add(Goal.Deserialize(lines[i]));
		}
		Console.WriteLine("Loaded.");
	}
}


