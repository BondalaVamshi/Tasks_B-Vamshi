using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Dictionary
    {
        public void CollectionDictionary()
        {
            Dictionary<int, string> normalDictionary = new Dictionary<int, string>();
            normalDictionary.Add(0, "hello");
            normalDictionary.Add(1, "world");
            normalDictionary.Add(3, "world");

            foreach (KeyValuePair<int,string> kvp1 in normalDictionary)
            {
                Console.WriteLine(kvp1);
            }
            foreach (KeyValuePair<int, string> kvp2 in normalDictionary)
            {
                Console.WriteLine(kvp2.Value);
            }
        }
        public void GenericDictionary()
        {
            Dictionary<int, EmpDetails> detailsDictionnary = new Dictionary<int, EmpDetails>();
            detailsDictionnary.Add(0,new EmpDetails { Id = 1, Name = "Virat", job="Cricket",Sal=1000});
            detailsDictionnary.Add(1, new EmpDetails { Id = 2, Name = "Doni", job = "Cricket", Sal = 1200 });
            detailsDictionnary.Add(2, new EmpDetails { Id = 3, Name = "Anand", job = "Chess", Sal = 9000 });
            detailsDictionnary.Add(3, new EmpDetails { Id = 4, Name = "Rahul", job = "Kabaddi", Sal = 5000 });
            for(int i=0; i< detailsDictionnary.Count; i++)
            {
                EmpDetails emp = detailsDictionnary[i];
                Console.WriteLine($"the dictionary values are {emp.Id} {emp.Name} {emp.job} {emp.Sal}");
            }
            EmpDetails emp2 = detailsDictionnary[2];
            Console.WriteLine(emp2.Sal);
            foreach(KeyValuePair<int,EmpDetails> kvp in detailsDictionnary)
            {
                //Console.WriteLine(kvp);
                //Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }


            //insertining dictionary of values into dictionary
            Dictionary<int, EmpDetails> AnotherDictionary = new Dictionary<int, EmpDetails>();
            AnotherDictionary.Add(4,new EmpDetails { Id = 5, Name = "Dharmaraj", job = "kabaddi", Sal = 400 });
           ////DOUGHT //detailsDictionnary.Add(1,AnotherDictionary);

        }
    }
}
