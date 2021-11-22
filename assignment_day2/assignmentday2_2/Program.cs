using System;

namespace assignmentday2_2
{

    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    };

    class Program
    {
        

        public static void Week(Days d)
        {
            Console.WriteLine("days is " + d);
        }


        static void Main(string[] args)
        {
            Week(Days.Monday);


            Console.ReadKey();
        }
    }
}