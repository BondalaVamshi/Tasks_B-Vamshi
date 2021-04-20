using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Parent
    {
       public int age;
       public string name;
       public float sal;
        public Parent()
        {
            //name = "some"; 
            Console.WriteLine($"{age}, {name}, {sal}");
        }
        public  Parent(int _age,string  _name,float _sal)
        {
            //this.age = _age;
            //this.name = _name;
            //this.sal = _sal;
            Console.WriteLine( $"the details are {_age} {_name} {_sal}");
        }
    }
}
