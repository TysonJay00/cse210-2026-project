using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
       : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return $"{box} {GetName()} ({Getdescription()})";
    }

    
    public override string GetStringRepresentation()
    {
  
        return $"SimpleGoal|{GetName()}|{Getdescription()}|{GetPointValue()}|{_isComplete}";
    }

    
    public void SetComplete(bool value)
    {
        _isComplete = value;
    }

}