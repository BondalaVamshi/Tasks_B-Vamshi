using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class ar
    {
        public void single()
        {
            int[] sin = new int[5];
            //sin[0] = 5;
            //sin[1] = 10;
            //sin[2] = 20;
            //sin[3] = 30;
            ////sin[4] = 40;
            Console.WriteLine("enter the {0} values into array",sin.Length);
            
            for(int i = 0; i <sin.Length; i++)
            {
                
              
                    sin[i] = int.Parse(Console.ReadLine());
                
                
            }
            Console.WriteLine("this is sorting of an array........");
            Array.Sort(sin);
            foreach(int arra in sin)
            {
                Console.WriteLine(arra);
            }
            Array.Reverse(sin);
            Console.WriteLine("this is reverse of an array........");

            foreach (int arra in sin)
            {
                Console.WriteLine(arra);
            }


            Array.Resize(ref sin, 6);
            Console.WriteLine("enter the {0} values into resized array", sin.Length);
            for (int i = 0; i < sin.Length; i++)
            {
               sin[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("this is resized of an array........");

            foreach (int arra in sin)
            {
                Console.WriteLine(arra);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ar c1 = new ar();
            c1.single();
        }
    }
}
