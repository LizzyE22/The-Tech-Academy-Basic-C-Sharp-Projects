﻿using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lizzy";

            //escape character/new line character/tab//
            string quote = "The man said, \"Hello\", Lizzy \n Hello on a new line. \n \t Hello on a tab";

            ////escape character when needing a backslash//
            //string fileName = "C:\\Users\\Lizzy";
            ////alternate method for escape sequences within an entire string//
            //string fileName2 = @"C:\Users\Lizzy";

            ////2nd line is reassigning and it will only print out the most recent//
            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("y");

            ////property of a string//
            int length = name.Length;
            //changes to uppercase//
            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();



            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(fileName2);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);





            Console.ReadLine();
        }
    }
}
