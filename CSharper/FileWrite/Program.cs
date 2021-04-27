using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string loc = @"F:/ C#.net/FormFile12.txt";
            if (!File.Exists(loc))
            {
                using(StreamWriter sw = File.CreateText(loc))
                {
                    sw.WriteLine("hello all");
                    sw.WriteLine("this is sream writer ");
                }
            }
            using(StreamReader sr = File.OpenText(loc))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
