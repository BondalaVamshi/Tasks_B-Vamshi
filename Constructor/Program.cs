using System;

namespace Constructors
{
    class Constructor1
    {
        int eid;

        string ename, address;
        public Constructor1()
        {
            Console.WriteLine($"this is default constructor {eid} {ename} {address} ");
           // Console.WriteLine($"this is bool {b},this is float {f},this is char {ch}");

        }
        public Constructor1(int empid, string empname, string empaddress)
        {
            int i = empid;
            this.eid = empid;
            this.ename = empname;
            this.address = empaddress;
            Console.WriteLine( $"this is localvariable of constr {i}");
            Console.WriteLine($"this is parameterised constructor {eid} {ename} {address}");
        }
        public Constructor1(Constructor1 tempo)
        {
            this.eid = tempo.eid;
            this.ename = tempo.ename;
            Console.WriteLine($"this is copy constructor {eid} ,{ename}");
        }
        public Constructor1(int i)
        {
            this.eid = 100;
            this.ename = "cognine";
            this.address = "kavuri hills,hyd";
            Console.WriteLine($"the details from constructor {eid} ,{ename},{address}");
        }
        public void details()
        {
          
            eid = 120;
            ename = "COGNINE1";
            address = "madhapur,hyd,Method";
            Console.WriteLine($"the details from method {eid} ,{ename},{address}");

        }
        public void test(int t1=12345)
        {
            this.eid = t1;
            int i = 123;
            Console.WriteLine($"this is  test method {eid} {i}");
        }
      
    }
    
}
