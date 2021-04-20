using System;

namespace DinamicJogged
{
    class DJog
    {
        public void VillNames()
        {
            Console.WriteLine("enter the row value for the array");
           int val=int.Parse(Console.ReadLine());
            string[][] vname = new string[][] 
                             { new string[] { "1", "hello", "all", "4 " }, new string[]{"2","hello","all","4"}};
            Console.WriteLine("enter the values into the array");
            for (int r = 0; r < vname.Length; r++)
            {
               for (int c = 0; c < vname[r].Length; c++)
               {
                   vname[r][c] = Console.ReadLine();
               }
            }
            Console.WriteLine(" the values of the array are ....");
            for (int r = 0; r < vname.Length; r++)
            {
                for (int c = 0; c < vname[r].Length; c++)
                {
                    Console.WriteLine(vname[r][c]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DJog d = new DJog();
            d.VillNames();
            Console.ReadKey();
        }
    }
}
