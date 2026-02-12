using System;
/*
Exceeding Requirements Comment:
In addition to the core requirements, this program includes:
- A simple level-up system: every 1000 points, the player levels up.
- Badges for completing multiple goals.
- Fun goal types could easily be added (e.g., negative goals).
- GoalManager fully encapsulates menu logic and scoring.
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}


