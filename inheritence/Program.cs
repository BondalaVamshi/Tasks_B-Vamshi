using System;

namespace Inheritence
{

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Child c1 = new Child();
            c1.details();

            //child2
            Child2 c2 = new Child2();
            c2.loc("hyd");

            //subchild
            SubChild s = new SubChild();
            s.designation("man");
            Console.ReadLine();
 
        }
    }
}
