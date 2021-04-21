using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method hiding
            MethodHiding mh = new MethodHiding();
            mh.PF = 12;
            mh.sal = 1200;
            mh.Tsal();
          //Method  overloading
            Child c1 = new Child();
            c1.sal = 10000;
            c1.PF = 2500;
            c1.Tsal();
            c1.Tsal("hello");
            int Total=c1.Tsal(1000, 200);
            Console.WriteLine(Total);

            Console.WriteLine("Array");
            //creting array  with "class" datatype
            //which array will give only parent  from under child class
            Parent[] PArray = new Parent[2];
            PArray[0] = new Child();
            PArray[1] = new Child2();
            foreach(Parent p in PArray)
            {
                p.Tsal();
            }

        }
    }
}
