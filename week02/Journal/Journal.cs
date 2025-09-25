using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private readonly List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string extension = Path.GetExtension(file);
        if (!string.IsNullOrEmpty(extension) && extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
        {
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file, json);
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
        }
    }
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string extension = Path.GetExtension(file);
        if (!string.IsNullOrEmpty(extension) && extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
        {
            string json = File.ReadAllText(file);
            List<Entry> loaded = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
            _entries.AddRange(loaded);
        }
        else
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
            }
        }
    }
}