using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday1_1
{
    

    class Series
    {

         static void Main(string[] args)
        {
            int num_1 = 0, num_2 = 1, num_3;
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(num_1 + " " + num_2 + " ");
            for (int i = 2; i <= n; i++)
            {
                num_3 = num_1 + num_2;
                Console.Write(num_3 + " ");
                num_1 = num_2;
                num_2 = num_3;
            }
        }
    }

}