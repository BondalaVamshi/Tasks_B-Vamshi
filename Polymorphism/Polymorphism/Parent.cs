using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Parent
    {
        public int sal;
        public string name;
        public int PF;
        public void Tsal()
        {
           // return sal;
            Console.WriteLine($"Parent:the Tsal is {sal +PF} of employee {name}");
        }


        public string test = "testing array  string";
        public void testArray()
        {
            Console.WriteLine("Parent"+test);
        }

    }
}
