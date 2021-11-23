using System;

namespace assignmentday3_2
{

    

    class Base_Class
    {
        public virtual void method_1()
        {
            Console.WriteLine("Base Class Sealed Method");
        }

    }


    
    class Child_class_1 : Base_Class
    {
        public sealed override void method_1()
        {
            base.method_1();
            Console.WriteLine("Base Method override in Child Class 1");
        }
    }



  

    class Program
    {
        static void Main(string[] args)
        {
            new Child_class_1().method_1();
            Console.ReadKey();
        }
    }
}