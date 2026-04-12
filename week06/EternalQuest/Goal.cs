using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Abstract methods (must be implemented in derived classes)
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    // Virtual method (can be overridden)
    public virtual string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }
}