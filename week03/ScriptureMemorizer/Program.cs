/*
EXCEEDING REQUIREMENTS:
- The program supports a library of multiple scriptures instead of a single scripture.
- One scripture is selected at random each time the program runs.
- A difficulty system was added to control how many words are hidden per round.
These enhancements improve replayability and better support scripture memorization.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = GetScriptureLibrary();

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        int wordsToHide = GetDifficulty();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ended.");
                break;
            }
        }
    }

    static List<Scripture> GetScriptureLibrary()
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            )
        );

        return scriptures;
    }

    static int GetDifficulty()
    {
        Console.WriteLine("Select difficulty:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");
        Console.Write("Choice: ");

        string choice = Console.ReadLine();

        return choice switch
        {
            "1" => 2,
            "2" => 4,
            "3" => 6,
            _ => 3
        };
    }
}
