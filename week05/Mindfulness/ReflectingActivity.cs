using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    public ReflectingActivity()
        : base("Reflection", "Reflect on your strengths and experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int time = 0;

        while (time < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);

            ShowSpinner(5);
            time += 5;
        }

        EndMessage();
    }
}