using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinditional
{
    class plce:Cond
    {
       public const int i = 1;
        public readonly int i1 = 100;
        public plce()
        {
         
            i1 = 200;
            Console.WriteLine($"this is an readonly: {i1}");
            Console.WriteLine($"this is an constant: {i}");
          
        }
        public void don()
        {
            Console.WriteLine("hello dons i am your dad..!");

          

        }
    }
}
