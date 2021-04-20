using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class FieldProperties
    {
            private int Pid;
            private string Pname;
            public string address;
        public string name { get; set; }
        private int Date { get; set; }
        public int _Date
        {
            get { return Date; }
            set { Date = value; }
        }
        public int _Pid
            {
                get { return Pid; }
                set { Pid = value; }
            }
        public int _AnotherPid
        {
            get { return Pid; }
            set { Pid = value; }
        }
    }
}
