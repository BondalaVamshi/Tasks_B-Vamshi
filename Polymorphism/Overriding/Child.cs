using System;
using System.Collections.Generic;
using System.Text;

namespace Overriding
{
    class Child:Parent
    {
       
        public override void TOtalsal()
        {
            sal = 2000;
            name = "child";
            PF = 500;
            loc = "knr";
            Console.WriteLine($"CHILD:the Tsal is \"{sal + PF}\" of employee \"{name}\" location is \"{loc}\" ");
        }
    }
}
