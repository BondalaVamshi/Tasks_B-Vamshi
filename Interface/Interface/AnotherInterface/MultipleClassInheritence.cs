using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherInterface
{
    interface IA
    {
        void Name();
    }
    interface IB
    {
        void Location();
    }
    class CA:IA
    {
        public void Name()
        {
            Console.WriteLine("name of the  employee is \"Rani\"");
        }
    }

    class CB:IB
    {
        public void Location()
        {
            Console.WriteLine("CB:name of the employee is \" Rajan\"");
        }
    }
    class MultipleClassInheritence : IA,IB
    {

        CA ca = new CA();
        CB cb = new CB();
        public void Name()
        {
            Console.WriteLine("this is from multiple class inheritence");

            ca.Name();
        }
        public void Location()
        {
            Console.WriteLine("this is from multiple class inheritence");

            cb.Location();
        }
    }
   
}
