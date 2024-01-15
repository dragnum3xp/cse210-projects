using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobtitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobtitle = "Backend Developer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DysplayInformation();
        job2.DysplayInformation();

        Resume MyResume = new Resume();
        MyResume._member = "Filipe";
        MyResume._Joblist.Add(job1);
        MyResume._Joblist.Add(job2);

        MyResume.Display();
    }
}