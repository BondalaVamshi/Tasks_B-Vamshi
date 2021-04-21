using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Child:Parent
    {
        //same method with differnt  parameters or  with same parametrs but diff order 
         public void Tsal(string _name)
        {
          
            Console.WriteLine($"Child:the Tsal  of employee is {sal+PF}");
        }
        public int Tsal(int _sal, int _PF)
        {
            return _sal + _PF;
           //Console.WriteLine("this is total sal fromreturn method");
        }


        public void testArray(string s)
        {
            Console.WriteLine("Child"+test);
        }
    }
    class Child2:Parent
    {
        public void msg()
        {
            Console.WriteLine("second child");

        }

        public void testArray(int i)
        {
            Console.WriteLine("Child1"+test);
        }
    }
}
