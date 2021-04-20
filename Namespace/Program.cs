using System;
using exNs;
using ConsoleApp1;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Arith a1 = new Arith();
       
            a1.Add(28, 22);
            int substract=a1.Sub(20,10);
            Console.WriteLine(" this is return value"+substract );
           
            
            Print p = new Print();
            p.Just();
            p.Add(1,2);
            
        }
    }
}
namespace exNs
{
    class Arith
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("this is the value"+c);
        }
        public int Sub(int a, int b)
        {
            int c = b - a;
            return c;
        }
    }
}
