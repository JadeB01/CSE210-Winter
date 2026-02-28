using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal stregth of yours?",
        "Who are people that you have helped this week?"
    };

    private List<string> _items = new List<string>();
    private Random _random = new Random();

    public ListingActivity(int duration)
        : base("Listing Activity",
                "this activity will help you reflect on the good things in your life. ",
                duration)
    {
    }

    public void Run()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}