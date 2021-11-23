using System;

namespace assignmentday3_4
{
    




    class Program
    {


        static int Divide_Fun(int no_1, int no_2)
        {

            int ans;
            ans = no_1 / no_2;
            return ans;

        }


        static void Call_Method_1(int a, int b)
        {
            try
            {
                Divide_Fun(a, b);
            }
            

            catch (Exception e)
            {
                Console.WriteLine("Catch Block  2-- ");
                Console.WriteLine("Exception Message - " + e.Message);

            }

        }






        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2  numbers -");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Call_Method_1(a, b);
            }
            catch (System.FormatException s)
            {
                Console.WriteLine("Catch block 3 sytsem Formate Exception");
                Console.WriteLine(s.Message);
            }


            Console.ReadKey();
        }
    }
}