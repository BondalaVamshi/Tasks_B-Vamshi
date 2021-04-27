using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptinHandling
{
    class Test
    {
        public void Logically()
        {
            try
            {
                Console.WriteLine("enter the value for valA");
                int valA = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the value for  valB");
                int valB = int.Parse(Console.ReadLine());
                if (valB == 0)
                {
                    Console.WriteLine("valB do not be \"0\" ");
                }
                int divRes = valA / valB;
                Console.WriteLine($"the division result is :{divRes}");
            }
            finally
            {
                Console.WriteLine("this is try finally combo..");
                StringBuilder jiantName = new StringBuilder();
                jiantName.Append("rama");
                jiantName.Append("laxmana");
                jiantName.Append("sita");
                jiantName.Append("hanuma");
                Console.WriteLine(jiantName);

            }
            Console.WriteLine("this is ending of this method........");
        }
        public void Catch()
        {
            Console.WriteLine("enter the value for valA");
            int valA = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for  valB");
            int valB = int.Parse(Console.ReadLine());
            int divRes = valA / valB;
            Console.WriteLine(divRes);
            Catch();
            
        }
    }
     //public class OnlyEvenNo : ApplicationException
     //{
     //   public override string Message
     //   {
     //       get
     //       {
     //           return "only even numbers are allowed";
     //       }
     //   }
     //}
    class TestTwo
    {
        public void ApplicationException()
        {
            Console.WriteLine("enter the value for valA");
            int valA = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for  valB");
            int valB = int.Parse(Console.ReadLine());
            if(valA%2!=0 || valB % 2 != 0)
            {
                throw new OnlyEvenValues.OnlyEvenNo();
            }
            int divRes = valA / valB;
            Console.WriteLine(divRes);
        }
    }
    

}
namespace OnlyEvenValues
{
    public class OnlyEvenNo : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "only even numbers are allowed";
            }
        }
    }
}
