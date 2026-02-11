using System;
using System.IO;
using System.Threading;

public abstract class Activity
{
    // Private fields for encapsulation
    private string _name;
    private string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");

        // Input validation
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou completed {_name} for {_duration} seconds.");
        ShowSpinner(3);

        // Enhanced: Log session to file
        LogSession();
    }

    // Execute ensures lifecycle is followed
    public void Execute()
    {
        StartActivity();
        Run();
        EndActivity();
    }

    private void LogSession()
    {
        string logEntry = $"{DateTime.Now:G} | {_name} | Duration: {_duration} seconds";
        File.AppendAllText("session_log.txt", logEntry + Environment.NewLine);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250); // smoother spinner
            Console.Write("\b");

            index = (index + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Abstract method for subclasses
    public abstract void Run();
}
