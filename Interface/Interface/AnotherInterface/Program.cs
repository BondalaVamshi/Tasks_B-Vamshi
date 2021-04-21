using System;

namespace AnotherInterface
{
    interface I1
    {
        public void name();
    }
    interface I2
    {
        public void name();
    }
    interface I3:I1,I2
    {
        //this is also possible
    }

    class Details:I1,I2
    {
       public  void name()
        {
            Console.WriteLine("this is default interface");
        }
        //this is explicit interface
        //we call it with interface refernce variable  I2 
        //(there involves type casting)  i.e,((I2)d).name();
        //default means calling directly i.e, d.name();
        void I2.name()
        {
            Console.WriteLine("this is vamshi");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.name();
            ((I2)d).name();

            MultipleClassInheritence MCI = new MultipleClassInheritence();
            MCI.Name();
            MCI.Location();
        }
    }
}
