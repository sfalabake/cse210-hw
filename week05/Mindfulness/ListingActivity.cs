using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths you have?",
        "Who are people you have helped recently?",
        "What are moments you felt joy today?"
    };

    private static Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "This activity helps you reflect on the positive by listing meaningful items."
        )
    { }

    public override void Run()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"\nList as many responses as you can to:\n--- {prompt} ---");
        Console.WriteLine("You may begin in:");
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

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
