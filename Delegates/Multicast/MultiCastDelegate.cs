using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{
    public delegate void MYDelegate();
    public delegate void IntDelegate(int a,int b);
    class MultiCastDelegate
    {
        public void Hello1()
        {
            Console.WriteLine("hello all of you");
        }
        public void Hello2()
        {
            int i = 100;
            string s = "this is string";
            Console.WriteLine(  "this is  Hello2"+i+s);
        }
       
    }
    class MultiCastDelegate2
    {
        public void add(int a1,int b1)
        {
            Console.WriteLine(a1 + b1);

        }
        public void sub(int a1, int b1)
        {
            Console.WriteLine(a1 - b1); 
        }
        public void div(int a1, int b1)
        {
            Console.WriteLine(a1 - b1);

        }
    }
}
