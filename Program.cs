﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program : ProgramUtils
    {
        static void Main(string[] args)
        {
           int[] Array;
           //Array = new int[] { 19, 11, 15, 12, 17, 8, 6, 5, 2, 1, 99, 88, 77, 0, 44, 34, 71, 21, 26, 66 };

           int length;

           Console.WriteLine("Please write lenght of array");
           length = Convert.ToInt32(Console.ReadLine());

           Array = new int[length];
           RandomArray(Array, length);

            Console.WriteLine("Start array");
            PrintTable(Array);
            
            Console.WriteLine("It works?");
            PrintOutput(HeapSort.SortRun(Array));
        
            Console.ReadLine();
         }
    }
}

    

