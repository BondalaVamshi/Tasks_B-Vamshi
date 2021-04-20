using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class properties1:FieldProperties
    {
       
        public string MyName { get; set; }
        public int  id{ get; set; }
        public void details()
        {
            MyName = "cognine";
            id = 10;
            Console.WriteLine($"details are {MyName} {id}");
        }


        public void ImplimentingPrivate()
        {
            _Pid = 10;
            address = "kavuri hills ,hyd";
            Console.WriteLine("this is private field" + _Pid);
            name = "vamshi";
            _Date = 19042021;
        }
    }
}
