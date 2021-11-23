using System;

namespace ThirdDay_Assignment3_Program6_IndexOut
{
    
    class Program
    {
        public static void ipArray(int[] a)
        {

            Console.Write("Input 5 elements in the array :\n");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array -- ");
            foreach (int it in a)
            {
                Console.WriteLine(it);
            }
           
            a[6] = 1;

        }

        static void Main(string[] args)
        {
            int[] a = new int[5];


            try
            {
                ipArray(a);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index out of bound--" + e.Message);
            }

            Console.ReadKey();
        }
    }
}