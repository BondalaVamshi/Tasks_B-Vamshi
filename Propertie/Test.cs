using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Test
    {  

       
        private int _Ti;
        private string _Tname;
        public void setName(string Tname)
        {
            if (Tname != "cognine")
            {
                throw new Exception("name must be \"Congnine\" ");
            }
            this._Tname = Tname;
        }
        public string GetName()
        {
            return this._Tname;
        }

        public int Ti
        {
            set { _Ti = value; }
            get { return _Ti; }
        }

    }
}
