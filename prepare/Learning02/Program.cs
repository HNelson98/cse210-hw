using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._company = "Google";
       job1._startYear = 2000;
       job1._endYear = 2010;

       Job job2 = new Job();
       job2._jobTitle = "CEO";
       job2._company = "Google";
       job2._startYear = 2010;
       job2._endYear = 2030;

       Resume Henry = new Resume();
       Henry._name = "Henry Nelson";
       Henry._jobs.Add(job1);
       Henry._jobs.Add(job2);
       Henry.Display();
    }
}