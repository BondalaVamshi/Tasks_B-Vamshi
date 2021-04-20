using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
   public static class StaticC
    {
      public static int I=100;
        static public void somest()
        {
            Console.WriteLine("hello this is static ");
        }
        static StaticC()
        {
            Console.WriteLine("this is a static constructor");
        }
    }
}
