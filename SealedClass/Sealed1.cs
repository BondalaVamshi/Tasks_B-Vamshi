using System;
using System.Collections.Generic;
using System.Text;

namespace Sealed
{
   sealed class Sealed1
    {
        int s1 = 300;
   public void S()
        {
            int i1 = 100;
            int i2 = 200;
            int i3 = i1 + i2;
            Console.WriteLine("addition value is "+i3);
            Console.WriteLine("this is sealed class "+s1);
        }
    }
    /// <summary>
    /// sealed classes are not be like a Base class
    /// it always be like derived classes
    /// it does not allow inherited by other classes
    /// </summary>
    class Vclass//:Sealed1
    {
      virtual public void Smsg()
        {
            Console.WriteLine("this is Vclass");
        }
    }
    class class1:Vclass
    {
       
       public int C1 = 100;
        sealed override public void Smsg()
        {
            Console.WriteLine("this is class1"+C1);
        }
    }
    class class2 : class1
    {
        int C2 = 200;
        //in this class Smsg override is not possible because we sealed the method
        //sealed methods can not be overriden 
        //sealed method used only in method overriden conncepts only
       override public void Smsg()
        {
            Console.WriteLine("this is class1" + C2+C1);
        }
    }
}
