using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// DivideByZeroException
/// </summary>
namespace ExceptinHandling
{
    class DivC
    {
        public void Division()
        {
            try
            {
                Console.WriteLine("enter the value for valA");
                int valA = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the value for  valB");
                int valB = int.Parse(Console.ReadLine());
                int divRes = valA / valB;
                Console.WriteLine($"the division result is :{divRes}");
            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("must enter integer value only");
               // Console.WriteLine(ex2.Message);
            }
            //this Exception is the default or like a else part in ifelse
            //because exception is the root class for all runtime exceptions
            catch(Exception ex)
            {
                int a = 10;
                int b = 20;
                int c = b / a;
                Console.WriteLine(ex.Message);
                Console.WriteLine($"the model for  input is  {b} / {a} = {c}");

            }
            finally
            {
                Console.WriteLine("Pracctiece makes man perfect...Keep practicing...!");
            }
            Console.WriteLine("the is the ending of method");
        }
    }
}
