using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
       : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public bool JustCompleted()
    {
        return _amountCompleted == _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    
    public override string GetDetailsString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {GetName()} ({Getdescription()}) -- Completed {_amountCompleted}/{_target}";
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{Getdescription()}|{GetPointValue()}|{_amountCompleted}|{_target}|{_bonus}";
    }
    
    public void SetAmountCompleted(int value)
    {
        _amountCompleted = value;
    }


}