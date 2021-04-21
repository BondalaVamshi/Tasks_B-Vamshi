using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    class ParentClass
    {
        public string Channel;
        public string place;
        public string name;
        public void JurnalistDetails()
        {
            Console.WriteLine(" the details of jurnalist from Parent class :{0}: {1}: {2}",Channel,place,name);
        }
    }
}
