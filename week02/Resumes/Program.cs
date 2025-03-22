using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        
        job1._jobTitle = "Administrative Assistent";
        job1._company = "MM Aluminios e Ferragens";
        job1._startYear = 2024;
        job1._endYear = 2024;
        

        Job job2 = new Job();

        job2._jobTitle = "Technical Assistent";
        job2._company = "State health department";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Victor Ferreira";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}