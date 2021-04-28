using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class DetailsList
    {
        public void EmpDetailsList()
        {
            EmpDetails emp1 = new EmpDetails
            {
                Id = 1,
                Name = "Ram",
                Gender = "Male",
                Sal = 12500
            };
            EmpDetails emp2 = new EmpDetails
            {
                Id = 2,
                Name = "Sita",
                Gender = "Female",
                Sal = 15000
            };
            EmpDetails emp3 = new EmpDetails
            {
                Id = 3,
                Name = "Laxman",
                Gender = "Male",
                Sal = 9999
            };
            EmpDetails emp4 = new EmpDetails
            {
                Id = 4,
                Name = "Urmila",
                Gender = "Female",
                Sal = 12000
            };
            EmpDetails emp5 = new EmpDetails
            {
                Id = 5,
                Name = "Hanuma",
                Gender = "Male",
                Sal = 10000
            };
           

            List<EmpDetails> detailsList1= new List<EmpDetails>();
            detailsList1.Add(emp1);
            detailsList1.Add(emp2);
            //for storing only one emp details
            EmpDetails e = detailsList1[1];
            Console.WriteLine(e.Id);
            //for  storing multiple obj information
            for(int i = 0; i < detailsList1.Count; i++)
            {
                EmpDetails emp = detailsList1[i];
                Console.WriteLine($"the details of employees are id: {emp.Id}  name: {emp.Name}  gender: {emp.Gender}  sal: {emp.Sal}");
            }
            //inserting of values using index
            detailsList1.Insert(0, emp3);
            for (int i = 0; i < detailsList1.Count; i++)
            {
                EmpDetails emp = detailsList1[i];
                Console.WriteLine($"the details of employees after insertion are id: {emp.Id}  name: {emp.Name}  gender: {emp.Gender}  sal: {emp.Sal}");
            }


            ///inserting  list  into another list OR inserting list of values into another list 
            List<EmpDetails> anotherList = new List<EmpDetails>();
            anotherList.Add(emp4);
            anotherList.Add(emp5);
            //direct inserting prop values into list
            anotherList.Add(new EmpDetails { Id = 6, Name = "Ravan", Gender = "Male", Sal = 15000 });
            //EmpDetails ed = AnotherList[0];
            detailsList1.AddRange(anotherList);

            detailsList1.Sort();
            for (int i = 0; i < detailsList1.Count; i++)
            {
                EmpDetails emp = detailsList1[i];
                Console.WriteLine($"the details of employees after AnotherList are id: {emp.Id}  name: {emp.Name}  gender: {emp.Gender}  sal: {emp.Sal}");
            }

            //detailsList1.Sort();
            //foreach(EmpDetails empDetails in detailsList1)
            //{
            //    //EmpDetails emp = empDetails;
            //    Console.WriteLine($"AFTER SORTING: {empDetails.Id}  name: {empDetails.Name}  gender: {empDetails.Gender}  sal: {empDetails.Sal}");

            //}

            //to get the required range of values GetRange() 
            List<EmpDetails> rangeList= detailsList1.GetRange(1, 2);
            for (int i = 0; i < rangeList.Count; i++)
            {
                EmpDetails empR = rangeList[i];
                Console.WriteLine($"the details of employees in range are id: {empR.Id}  name: {empR.Name}  gender: {empR.Gender}  sal: {empR.Sal}");
            }

            //insert list of values at cirtain index value
            List<EmpDetails> insertRangeList = new List<EmpDetails>();
            insertRangeList.Add(new EmpDetails {Id=7,Name="sugreeva" ,Gender="Male",Sal=9000 });
            //detaillsList1.Insert(1,emp5);
            detailsList1.InsertRange(2,insertRangeList);
            for (int i = 0; i < detailsList1.Count; i++)
            {
                EmpDetails emp = detailsList1[i];
                Console.WriteLine($"the details of employees after InsertRange are id: {emp.Id}  name: {emp.Name}  gender: {emp.Gender}  sal: {emp.Sal}");
            }

            //removing Range values
            // detaillsList1.RemoveAt(4);
            detailsList1.RemoveRange(0, 4);
            for (int i = 0; i < detailsList1.Count; i++)
            {
                EmpDetails emp = detailsList1[i];
                Console.WriteLine($"the details of employees after RemovingRange are id: {emp.Id}  name: {emp.Name}  gender: {emp.Gender}  sal: {emp.Sal}");
            }
        }
    }
}
