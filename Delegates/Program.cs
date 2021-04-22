using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Delegate D = new Delegate();

            NameDelegate nd = new NameDelegate(D._name);
            string sm= nd.Invoke("hello all this isreturn type delegate");
            Console.WriteLine(sm);

            AnonymousDelgate AMD = delegate (String s1) 
            {
                return s1;
            };
            String name = AMD.Invoke("COGNINE");
            Console.WriteLine(name);
       
        }
    }
}
