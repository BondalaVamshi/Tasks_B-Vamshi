using System;

namespace Structures
{
    class Program
    {
        static void Main()
        {
            //Structure1 s1;//= new Structure1();
            ////s1.i;
            //s1.msg(); this  case is  not possible because here no constructor to initalise the value

            Structure1 s1 = new Structure1();
            s1.msg();//which gives default values becaouse default constructor will assign values

            Structure1 s2;
            s2.i = 100;
            s2.msg();

            parametrs p = new parametrs();
            p.msg2();
        }
    }
}
