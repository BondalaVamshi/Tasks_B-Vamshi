using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    class ChildClass:ParentClass
    {
        public int ID;
        public void ChildJDetails()
        {
            //to allow  the parent class instead of Hiding use  base.parentMethod Name()
           // base.JurnalistDetails();
            Console.WriteLine("details from Child Class {0} {1} {2} {3} ",Channel,place,name,ID);

        }
    }
}
