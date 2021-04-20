using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods1
{
    class Program
    {
        public void value(int v)
        {
            v = 1000;
            Console.WriteLine($"this is call by value {v}");
            Console.WriteLine("------------------------------");
        }
        public void ByRef(ref int i)
        {
            i = 10;
            Console.WriteLine("this is formal parameter {0}",i);
            Console.WriteLine("------------------------------");

        }
        public void Out(int i,int j,out int y)
        {
            i = 10;
            j = 20;
            y = i+j;
            Console.WriteLine("this is out parameter {0}", y);
            Console.WriteLine("------------------------------");

        }
        public void Params(int i, int j, params int[] y)
        {
            i = 10;
            j = 20;
           // y = i + j;
           // Console.WriteLine("this is out parameter {0}", y);
           foreach(int par in y)
            {
                Console.WriteLine(par);
            }
            Console.WriteLine("these are the normal paarmetr {0} {1}",i,j);
            Console.WriteLine("------------------------------");

        }
        public void named(int i,string s)
        {
            Console.WriteLine($"this is are named prameters {i} {s}");
        }
        static void Main(string[] args)
        {
            int j = 100;
            Program p = new Program();
            p.value(j);
            p.ByRef(ref j);
            p.Out(1, 2, out j);
            p.Params(1, 2, 5, 7, 8, 9, 9);
            p.named(s: "hello", i : 1);
            Console.WriteLine("this is actual parameter {0}", j);

        }
    }
}
