using System;
using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[Eternal Goal] {_name} ({_description})");
    }
}