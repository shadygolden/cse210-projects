using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate:",
        "List your personal strengths:",
        "List things you are grateful for:"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you focus on positive things by listing them.";
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("Start listing items...");

        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");

        EndMessage();
    }
}