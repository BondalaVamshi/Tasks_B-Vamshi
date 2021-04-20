using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Child:Parent
    {
        public Child():base(24,"hello",12345.12f)
        {
            Console.WriteLine("from child default constructor");
        }
        public void details()
        {
            age = 10;
            name = "cognine";
            sal = 1000.00f;
            Console.WriteLine($"from child {age} {name} {sal}");
        }
    }

    //simple inheritence i.e., from parent to child
    class Child2:Parent
    {
        public void loc(string location)
        {
            this.age = 10;
            this.sal = 1000.20f;
            this.name = "mla";
            Console.WriteLine($" {age} {name} {sal} {location}");
        }
    }
}
