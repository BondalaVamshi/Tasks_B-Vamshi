using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate string NameDelegate(string n);
    public delegate string AnonymousDelgate(string n1);
    class Delegate
    {
        public string _name(string name)
        {
            return name;
            //Console.WriteLine(name);
        }
    }
}
