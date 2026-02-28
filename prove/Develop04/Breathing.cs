using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing Activity",
                "This activity will help you relax by guiding you through slow breathing.",
                duration)
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreath in...");
            ShowCountDown(4);

            Console.WriteLine("\nBreath out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}