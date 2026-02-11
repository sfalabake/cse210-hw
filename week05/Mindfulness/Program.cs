using System;
using System.IO;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. View Session History");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    if (File.Exists("session_log.txt"))
                    {
                        Console.Clear();
                        Console.WriteLine("Session History:\n");
                        Console.WriteLine(File.ReadAllText("session_log.txt"));
                    }
                    else
                    {
                        Console.WriteLine("No sessions recorded yet.");
                    }
                    Console.WriteLine("\nPress Enter to return to menu.");
                    Console.ReadLine();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }

            activity?.Execute();

            if (running && choice != "4")
            {
                Console.WriteLine("\nPress Enter to return to menu.");
                Console.ReadLine();
            }
        }
    }
}
