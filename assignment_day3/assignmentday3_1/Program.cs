using System;

namespace assignmentday3_1
{



    abstract class Account
    {
        public abstract void Calculate_interest();

    }

    class Saving : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("---Saving Account Interest---");
            Console.WriteLine("Calculating Saving account Interest....");
        }
    }


    class Current : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("---Current Account Interest---");
            Console.WriteLine("Calculating Current account Interest....");
        }
    }

    class FD_Account : Account
    {
        public override void Calculate_interest()
        {
            Console.WriteLine("---FD_Account Interest---");
            Console.WriteLine("Calculating FD account Interest....");
        }
    }


    class Program
    {

        public void findinterest(Account acc_Obj)
        {
            if (acc_Obj.GetType() == typeof(Saving))
            {
                Saving save_obj = (Saving)acc_Obj;
            }

            if (acc_Obj.GetType() == typeof(Current))
            {
                Current urrent_obj = (Current)acc_Obj;
            }

            if (acc_Obj.GetType() == typeof(FD_Account))
            {
                FD_Account fd_obj = (FD_Account)acc_Obj;
            }

            acc_Obj.Calculate_interest();
        }

        static void Main(string[] args)
        {


            Program p = new Program();

            p.findinterest(new Saving());
            p.findinterest(new Current());
            p.findinterest(new FD_Account());


            Console.ReadKey();
        }
    }
}