// Exceeded core requirements by:
// - Implementing random prompt generation
// - Supporting saving and loading journal entries from files
// - Separating responsibilities using abstraction (Journal, Entry, PromptGenerator)


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(entry._promptText);
                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
