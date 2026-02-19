using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(int length)
    {
        _date = DateTime.Now;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMM yyyy");
    }

    public abstract double GetDistance();


    public abstract double GetSpeed();


    public abstract double GetPace();
    
    
    
    public string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({_length} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km ";
    } 
}