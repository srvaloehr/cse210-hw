using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Project Manager";
        job1._company = "Reign Construction";
        job1._startYear = 2025;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Caster";
        job2._company = "CMC";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Stephen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}