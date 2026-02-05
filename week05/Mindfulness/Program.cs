using System;

class Program
{
    static void Main()
    {
        /*
         * EXCEEDS CORE REQUIREMENTS:
         * - Added both spinner AND numeric countdown animations using backspaces.
         * - Centralized animation logic in the base Activity class.
         * - Randomized prompts/questions for replay value.
         */

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
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
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            activity?.Run();

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to menu.");
                Console.ReadLine();
            }
        }
    }
}
