using System;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiCastDelegate MCD = new MultiCastDelegate();
            MYDelegate m = new MYDelegate(MCD.Hello1);
            m += MCD.Hello2;
            m.Invoke();

            MultiCastDelegate2 mcd2 = new MultiCastDelegate2();
            IntDelegate IDel = new IntDelegate(mcd2.add);
            IDel += mcd2.sub;
            IDel += mcd2.div;
            IDel.Invoke(100,200);
            Console.WriteLine();
        }
    }
}
