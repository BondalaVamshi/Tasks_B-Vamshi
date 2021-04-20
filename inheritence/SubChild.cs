using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    //in this subchild we can get both Parent and child values 
    class SubChild:Child
    {
        public void designation(string role)
        {
            this.age = 25;
            this.name = "MP";
            this.sal = 1200.00f;
            role="Management";
            Console.WriteLine($"from subchild {age} {sal} {name} {role}");
        }
    }
}
