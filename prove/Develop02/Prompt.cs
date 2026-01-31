using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _prompts = new List<string>();
    public Random _random = new Random();

    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I talked to today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I could do one thing over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}