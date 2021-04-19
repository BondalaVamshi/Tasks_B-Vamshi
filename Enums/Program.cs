using System;

namespace enums
{
    public enum days
    {
        monday, thueseday, wednesday, thurseday, friday, saturday, sunnday
    }

    class Program
    {
        public static days scedule{get;set;}=days.monday;

        static void Main(string[] args)
        {
            scedule = days.thueseday;
            scedule = days.sunnday;
            Console.WriteLine("the meetinng date is on {0}",scedule);
           //public static days{get; set;}=days.monday;
            Console.BackgroundColor = ConsoleColor.Green;

            foreach (int i in Enum.GetValues(typeof(days)))
                Console.WriteLine(i+":"+(days)i);
            foreach(string s in Enum.GetNames(typeof(days)))
                Console.WriteLine(s);

            days d= days.thueseday;
            //string today = days.monday;
            Console.WriteLine((int)d);
            Console.WriteLine("Hello World!");
        }
    }
}
