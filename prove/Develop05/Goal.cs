using System;
public class Goal //parent class//
{
    protected string _name;
    protected string _description;
    protected int _points;

//Constructor//
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_name} ({_description})");
    }


}