 using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.PersonalDetails();

            class2 c2 = new class2();
            c2.PersonalDetails();
            c2.JobDetails();


            Interface1 I1 = new Class1();
            I1.PersonalDetails();
        }
    }
}
