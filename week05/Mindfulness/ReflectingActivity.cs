using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Recall a moment of personal success.",
        "Think of a time you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?",
        "What strengths did you use?"
    };

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity helps you reflect deeply on moments of strength."
        )
    { }

    public override void Run()
    {
        StartActivity();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("Press Enter when ready.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write($"\n{question} ");
            ShowSpinner(5);
        }

        EndActivity();
    }
}
