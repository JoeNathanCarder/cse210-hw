using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Microsoft";
        job2._startYear = 2010;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "Joe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.ShowResume();

    }
}