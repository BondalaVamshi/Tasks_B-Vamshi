using System;
using System.Collections.Generic;
using System.Text;

namespace Overriding
{
    class Parent
    {
        public int sal;
        public string name;
        public int PF;
        public string loc;
        public virtual void TOtalsal()
        {
            sal = 1000;
            name = "parent";
            PF = 200;
            loc = "hyd";
            Console.WriteLine($"Parent:the Tsal is {sal + PF} of employee {name} and loction is {loc}");
        }
    }
}
