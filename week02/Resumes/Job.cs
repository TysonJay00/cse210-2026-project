using System;

public class Job
{
    public string _company;
    public string _jobtitle;
    public int _startdate;
    public int _enddate;

    public void display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startdate}-{_enddate}");
    }

   
}

