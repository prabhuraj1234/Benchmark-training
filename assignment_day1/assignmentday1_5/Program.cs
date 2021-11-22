using System;

namespace assignmentday1_5
{

   
    class Employee
    {
        int empNo;
        String eName, designation;
        float salary;
        public void acceptEmpDetails()
        {
            Console.WriteLine("Enter emp no, name, designation and salary - ");
            empNo = Convert.ToInt32(Console.ReadLine());
            eName = Console.ReadLine();
            designation = Console.ReadLine();
            salary = Convert.ToSingle(Console.ReadLine());
        }


        public void showEmpDetails()
        {

            Console.WriteLine("Emp no = {0}, ename is {1} and  designation is  {2} with  salary  {3} rs/month", empNo, eName, designation, salary);

        }

        static void Main(string[] args)
        {

            // Employee e = new Employee();
            // e.acceptEmpDetails();
            // e.showEmpDetails();
            // Console.ReadKey();

            Emp e1 = new Emp();
            e1.display();

        }
    }
}

namespace assignmentday1_5
{
    class Emp
    {
        public void display()
        {
            for (int i = 0; i < 2; i++)
            {
                Employee e2 = new Employee();
                e2.acceptEmpDetails();
                e2.showEmpDetails();

            }


        }
    }

}