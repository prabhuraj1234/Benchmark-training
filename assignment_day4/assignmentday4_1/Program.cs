﻿using System;

namespace assignmentday4_1
{
    class Program
    {

        int day, month, year;

        public Program(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
             
            String date = $"{day} / {month} / {year}";
            return date;

        }



        static void Main(string[] args)
        {
            Console.WriteLine(new Program(21, 11, 2021));
            Console.ReadKey();
        }
    }
}