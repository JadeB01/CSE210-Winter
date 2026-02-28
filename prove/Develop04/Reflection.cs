using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn from this experience?",
        "How did you feel afterward?"
    };

    private Random _random = new Random();

    public ReflectionActivity(int duration) //": base" calls to the constructor in parent class (Activity class). The specific code it pulls is "public Activity(string name, string description, int duration)//
        //why use ":base" ? So it can use...//
        : base("Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown stregth and resilience.",
            duration) // this line "duration" from the Activity class//
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nConsider the following prompt: \n");
        Console.WriteLine($"---{GetRandomPrompt()} ---");
        Console.WriteLine("\nWHen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder each of the following questions:");
        ShowSpinner (3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}