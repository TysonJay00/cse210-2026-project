using System;

public class SwimmingActivity: Activity
{
    private int _laps;

    public SwimmingActivity(int length, int laps)
       : base(length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return _laps / (GetLength() / 60.0);
    }

    public override double GetPace()
    {
        return GetLength() / _laps;
    }
  
}