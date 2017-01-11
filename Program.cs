using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program : ProgramUtils
    {
        static void Main(string[] args)
        {
           IComparable[] Array;
           int length;
           int  WithAlgo;
           ISortAlgorithm metod;
     
           Console.WriteLine("Please write lenght of array");
           length = Convert.ToInt32(Console.ReadLine());
           Array = new IComparable[length];
           RandomArray(Array, length);
            
           Console.WriteLine("Choose Sort algorithm (1-6): \n" +
                             "1.Bubble, 2.Insertion, 3.Heap, 4.Merge, 5.Quick, 6.Select");
           WithAlgo = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Sorting array of length "+ length);

           metod = ChosenAlgorithm(WithAlgo);
           Output(Array, Array.Length, metod);
           Console.ReadLine();
         }
     }
}

    

