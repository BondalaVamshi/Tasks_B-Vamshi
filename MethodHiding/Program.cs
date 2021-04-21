using System;

namespace MethodHiding
{

    class Program
    {
        static void Main(string[] args)
        {
            ParentClass p1 = new ParentClass();
            p1.Channel = "tv9";
            p1.name = "ramu";
            p1.place = "hyd";
            p1.JurnalistDetails();

            ChildClass c1 = new ChildClass();
            c1.Channel = "tv10";
            c1.name = "bhim";
            c1.place = "scbd";
            c1.ID = 12;
            c1.ChildJDetails();

            //ChildClass c11 = new ChildClass();
            //c11.ID = 1;
            //c11.name = "name";
            //c11.place = "place";
            //c11.Channel = "channels";
            //c11.JurnalistDetails();

            // parent class refernce to child class object
            ParentClass h1 = new ChildClass();
            p1.Channel = "tv9";
            p1.name = "rammu";
            p1.place = "wrgl";
            //p1.ID = 12;
            p1.JurnalistDetails();

            //converting child class object to parent class data type
            ChildClass h2 = new ChildClass();
            h2.Channel = "HMtv";
            h2.name = "surya";
            h2.place = "nzbd";
            h2.ID = 12;
            ((ParentClass)c1).JurnalistDetails();


        }
    }
}
