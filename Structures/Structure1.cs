using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    struct Structure1
    {
        public int i;
        public void msg()
        {
            Console.WriteLine("the values from struct are " + i);
        }
    }

    struct parametrs
    {
        private int _id;
        public int ID
        {
            set { this._id = value; }
            get { return this._id; }
        }
        public void msg2()
        {
            Console.WriteLine("enter the values imto the ID");
            ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ID);
        }
    }
}

    
    
