using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MethodHiding:Parent
    {
        public void Tsal()
        {
            Console.WriteLine($"tMethod Hiding The Tsal of {name} is {sal+PF}");
        }
    }
}
