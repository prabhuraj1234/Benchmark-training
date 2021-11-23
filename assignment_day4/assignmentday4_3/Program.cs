using System;
using System.Collections.Generic;

namespace assignmentday4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            

           


            List<string> listVar = new List<string>();

           

            listVar.Add("one");
            listVar.Add("two");
            listVar.Add("three");
            listVar.Add("four");

            Console.WriteLine("List --> ");
           
            foreach (string l in listVar)
            {
                Console.Write(l + " ");
            }
          
            Console.WriteLine("\n-------------");


           

            string[] words = { "the", "world", "is", "changing", "..." };
            LinkedList<string> linkVar = new LinkedList<string>(words);
            Console.WriteLine(" Linked List --> ");
            foreach (string s in linkVar)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n-------------");


           
            SortedList<int, string> sortVar =
            new SortedList<int, string>();

            sortVar.Add(1, "r");
            sortVar.Add(101, "ee");
            sortVar.Add(14, "taet");
            sortVar.Add(51, "bt");
            sortVar.Add(156, "bgh");
            sortVar.Add(10, "dfs");


            Console.WriteLine(" sorted List --> ");
            foreach (KeyValuePair<int, string> kvp in sortVar)
            {
                Console.Write(kvp.Key + " " + kvp.Value + "\n");
            }

            Console.WriteLine("\n-------------");


            Console.ReadKey();
        }
    }
}