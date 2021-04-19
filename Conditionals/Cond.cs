using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinditional
{
    class Cond
    {

        public void don()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            //string msg1 = "hello rgv how are you doing...!";
            //string msg2 = "hello don whats up...!";

            string s = name == "rgv" ? "hello rgv how are you doing...! are you really ...there":"hello don whats up...!" ;
            Console.WriteLine(s);
            ////name == "rgv" ? msg1 : msg2;

            if (name == "hello")
            {
                Console.WriteLine($"hello {name}");
            }
            else if (name == "rgv")
            {
                Console.WriteLine($"hello {name} are you there");
            }
            
            
            switch (name)
            {
                case "rgv":
                    Console.WriteLine("hello rgv how are you doing...!");
                    break;
                case "puri":
                    Console.WriteLine("hello puri how are you doing...!");
                    break;
                case "mani":
                    Console.WriteLine("hello mani how are you doing...!");
                    break;
                case "jd":
                    Console.WriteLine("hello jd how are you doing...!");
                    break;
                default:
                    Console.WriteLine("hello dons how are you doing...!");
                    break;
            }
        }

        
       
    }
}
