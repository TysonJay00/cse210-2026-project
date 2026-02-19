using System;

public class BikingActivity: Activity
{
    private double _speed;

    public BikingActivity(int length, double speed)
       : base(length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / (GetLength() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
  
}