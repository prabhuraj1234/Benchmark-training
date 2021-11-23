using System;

namespace assignmentday3_3
{


  
    interface IPrintable
    {
        void print();
    }

    class Account : IPrintable
    {
        string acc_Type = "Saving";
        public void print()
        {
            Console.WriteLine("Account class Print method");
            //   Console.WriteLine(acc_Type);
        }
    }


    class Employee : IPrintable
    {
        string Emp_Type = "Permanent";
        public void print()
        {
            Console.WriteLine("Employee class Print method");
            //  Console.WriteLine(Emp_Type);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Account().print();

            new Employee().print();

            Console.ReadKey();
        }
    }
}