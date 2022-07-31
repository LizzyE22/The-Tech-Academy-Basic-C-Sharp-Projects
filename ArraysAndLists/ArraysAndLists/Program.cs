using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);
            //another example as a string//
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Lizzy");
            intList.Remove("E.");

            Console.WriteLine(intList[0]);
            Console.ReadLine();


            //integer array called numArray//
            ////must indicate how many items the variable is going to hold(5)//
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200; 
            //numArray[4] = 5000;
            ////alternate method, exact as above, but cleaner and easier to read and write//
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            ////even faster way here, same as 2 above//
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            ////changing 600 to 650
            //numArray2[5] = 650;


            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

        }
    }

}
    

