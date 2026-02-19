using System;

public class RunningActivity: Activity
{
    private double _distance;

    public RunningActivity(int length, double distance)
       : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetLength() / 60.0);
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }
  
}