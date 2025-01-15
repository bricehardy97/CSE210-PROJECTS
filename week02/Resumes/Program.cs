using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job() ;
        job1._jobTitle = "Software Engineer" ;
        job1._company = "Microsoft" ;
        job1._startYear = 2019 ;
        job1._endYear = 2022 ;

       Job job2 = new Job() ;
        job2._jobTitle = "Interpreter" ;
        job2._company = "Purple" ;
        job2._startYear = 2024 ;
        job2._endYear = 2025 ;
  
  
        Console.WriteLine("Job details: " + job1._company + ", " + myJob.Position);

    }
}