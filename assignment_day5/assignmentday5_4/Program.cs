using System;
using System.Collections.Generic;
using System.Collections;
namespace assignmentday5_4
{


    

    class student
    {
        public int rollno;
        public string name;

        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

           

            student s1 = new student(2, "Student_1");
            student s2 = new student(1, "Student_2");

           
            SortedList<int, string> sortList = new SortedList<int, string>();

            sortList.Add(s1.rollno, s1.name);
            sortList.Add(s2.rollno, s2.name);

            Console.WriteLine(" sorted List --> ");
            foreach (KeyValuePair<int, string> kvp in sortList)
            {
                Console.Write(kvp.Key + "--" + kvp.Value + "\n");
            }



            Console.WriteLine("\n------------");
            

            Hashtable ht = new Hashtable();
            ht.Add(s1.rollno, s1.name);
            ht.Add(s2.rollno, s2.name);

            foreach (DictionaryEntry di in ht)
            {
                Console.WriteLine("{0} - {1}", di.Key, di.Value);
            }

            Console.ReadKey();
        }
    }
}