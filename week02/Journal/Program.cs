using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }
    }
}

// ===== Entry Class =====
class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"{_response}\n");
    }
}

// ===== Journal Class =====
class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
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
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                _entries.Add(entry);
            }
        }
    }
}

// ===== Prompt Generator Class =====
class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}