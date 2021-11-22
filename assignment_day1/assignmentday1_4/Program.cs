using System;

namespace assignmentday1_4
{
    class EmpProperty
    {

       

        private int empNo;
        private String eName, designation;
        private float salary;

        public int EmpNo
        {
            get
            {
                return empNo;
            }

            set
            {
                empNo = value;
            }
        }

        public string EName
        {
            get
            {
                return eName;
            }

            set
            {
                eName = value;
            }
        }

        public string Designation { get; set; }




        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpProperty e = new EmpProperty();
            e.EmpNo = 101;
            e.EName = "employee_1";
            e.Designation = "Software Engineer";
            Console.WriteLine("No = {0} Name :- {1}  Designation :- {2}", e.EmpNo, e.EName, e.Designation);

            Console.ReadKey();
        }
    }


}