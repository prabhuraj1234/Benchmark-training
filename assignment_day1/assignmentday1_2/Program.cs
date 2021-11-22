using System;

namespace assignmentday1_2
{
    class Month
    {

       

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Month");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("31 days in month ");  //jan
                    break;
                case 2:
                    Console.WriteLine("28 days in month ");  // feb
                    break;
                case 3:
                    Console.WriteLine("31 days in month "); // mar
                    break;
                case 4:
                    Console.WriteLine("30 days in month "); // april
                    break;
                case 5:
                    Console.WriteLine("31 days in month "); // may
                    break;
                case 6:
                    Console.WriteLine("30 days in month "); // june
                    break;
                case 7:
                    Console.WriteLine("31 days in month "); // july
                    break;
                case 8:
                    Console.WriteLine("31 days in month "); // aug
                    break;
                case 9:
                    Console.WriteLine("30 days in month "); // sept
                    break;
                case 10:
                    Console.WriteLine("31 days in month "); // oct
                    break;
                case 11:
                    Console.WriteLine("30 days in month "); // nov
                    break;
                case 12:
                    Console.WriteLine("31 days in month "); // dec
                    break;
                default:
                    Console.WriteLine("Invalid month no");
                    break;
            }
            Console.ReadKey();
        }
    }
}