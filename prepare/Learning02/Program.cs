using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTittle="Designer";
        job1._company="Go Fitness center";
        job1._startYear=2021;
        job1._endYear=2022;

        Job job2 = new Job();
        job2._jobTittle="Gym Instructor";
        job2._company="U-fit";
        job2._startYear=2016;
        job2._endYear=2019;

        Resume myResume = new Resume();
        myResume._name="Elder Cuases";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

        
    }
}