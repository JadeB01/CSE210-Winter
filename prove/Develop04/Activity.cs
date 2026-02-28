using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in SECONDS, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());
        //When a user clicks on to one of the activities, this is the first this they will see, and the first question to ask.//

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have Completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\"};
        int counter = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            counter = (counter + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}