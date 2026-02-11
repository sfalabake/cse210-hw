using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity helps you relax by guiding you through slow breathing."
        )
    { }

    public override void Run()
    {
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            elapsed += 4;

            Console.Write("\nBreathe out... ");
            ShowCountdown(6);
            elapsed += 6;
        }
    }
}
