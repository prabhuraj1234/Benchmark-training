using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, ans;
            Console.WriteLine("enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            ans = a + b;
            Console.WriteLine("addition is" + ans);
            Console.ReadKey();
        }
    }
}
