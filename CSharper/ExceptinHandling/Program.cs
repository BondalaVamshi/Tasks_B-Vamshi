using System;

namespace ExceptinHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Test TO = new Test();
            TO.Logically();
            TO.Catch();

            DivC DivO = new DivC();
            DivO.Division();
            Console.WriteLine("Hello World!");

            TestTwo TestTwoO = new TestTwo();
            TestTwoO.ApplicationException();
        }
    }
}
