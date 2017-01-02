using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
   public  class SortUtils
    {

        public static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        public static void PrintTable(int[] ToPrint)
        {
            for (int i = 0; i < ToPrint.Length; i++)
                Console.Write(ToPrint[i] + " ");
                Console.Write("\n");
        }

       public static void PrintOutput (int[] ToPrint)
        {
            DateTime Timer = DateTime.Now;
            SortUtils.PrintTable(ToPrint);
            long ms = (long)(DateTime.Now - Timer).TotalMilliseconds;
            Console.WriteLine("Time " + ms + " ms");
        }

       public static Array RandomArray (int[] Array)
       {
         // int[] Array; 
           int lenght;
            Console.WriteLine("Please write lenght of array");
            lenght = Convert.ToInt32(Console.ReadLine());
           Array = new int[lenght];
           Random rnd = new Random();
                  for (int i=0; i<lenght; i++)
                     Array[i] = rnd.Next(0, lenght); 
           return Array;

       }
    }
}
