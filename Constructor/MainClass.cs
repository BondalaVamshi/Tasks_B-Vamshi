using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Constructor1 c1 = new Constructor1();
            //c1.details();
            //Constructor1 c2 = new Constructor1(1, "vamshi", "cognine kavuri hills");
            //c2.test(200);
            Constructor1 t = new Constructor1(1);
            Constructor1 t1 = new Constructor1(t);
            StaticC.somest();
        }
    }
}
