using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Class1:Interface1
    {
        public void PersonalDetails()
        {
            string name = "hari";
            string city = "karimnagar";
            Console.WriteLine("class1:the details are" + " " + name + " " + city);
        }
    }

    class class2:Interface1,Interface2
    {
        public void PersonalDetails()
        {
            string name = "javahar";
            string city = "GodavariKhani";
            Console.WriteLine("class2:the details are" + " " + name +" " +city);
        }
        public void JobDetails()
        {
            string role = ".Net Developer";
            int ID = 1;
            Console.WriteLine("class2:Job details are " + " " + role + " " + ID);

        }


    }
}
