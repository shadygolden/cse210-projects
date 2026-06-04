using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Think of a time you helped someone.",
        "Think of a time you achieved something difficult."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this successful?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on a time when you showed strength and resilience.";
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("\nThink about this...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + _questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        EndMessage();
    }
}