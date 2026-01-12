using System;

class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();
        job1._company = "Wayne Enterprises";
        job1._jobtitle = "Software Engineer";
        job1._startdate = 2018;
        job1._enddate = 2022;

       

        Job job2 = new Job();
        job2._company = "Queen Industries";
        job2._jobtitle = "Assistant to the Regional Manager";
        job2._startdate = 2022;
        job2._enddate = 2024;

   

        Resume resume = new Resume();
        resume._name = "Tim Drake";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.display();
    }
}