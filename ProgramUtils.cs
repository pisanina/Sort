using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
   public class ProgramUtils 
    {
       protected ISortAlgorithm metod;

        public static void PrintTable(IComparable[] ToPrint)
        {
            for (int i = 0; i < ToPrint.Length; i++)
                Console.Write(ToPrint[i] + " ");
            Console.Write("\n");
        }

        public static IComparable[] RandomArray(IComparable[] Array, int lenght)
        {
            Random rnd = new Random();
            for (int i = 0; i < lenght; i++)
                Array[i] = rnd.Next(0, lenght);
            return Array;
        }

        public static long UsedMemory()
        {
            long memory; Process SortApp;
            SortApp = Process.GetCurrentProcess();
            memory = SortApp.PrivateMemorySize64 / 1000;
            return memory;
        }

        public static void Output(IComparable[] Array, int length, ISortAlgorithm metod)
        {
            DateTime Timer = DateTime.Now;
            metod.SortRun(Array);
            long TimeOfSort = (long)(DateTime.Now - Timer).TotalMilliseconds;
            long memory = UsedMemory();

            if (length < 101)
                PrintTable(Array);

            Console.WriteLine(metod + " Time of sort: " + TimeOfSort + "ms " +
                                      "Memory used: " + memory + "kB");
        }

        public static ISortAlgorithm ChosenAlgorithm(int WithAlgo)
        {
            ISortAlgorithm algo;
            switch (WithAlgo)
            {
                case 1: algo = new BubbleSort(); break;
                case 2: algo = new InsertionSort(); break;
                case 3: algo = new HeapSort(); break;
                case 4: algo = new MergeSort(); break;
                case 5: algo = new QuickSort(); break;
                case 6: algo = new SelectSort(); break;
                default:
                    Console.WriteLine("Invalid selection");
                    algo = new SelectSort();  break;
            }
            return algo;
        }
    }
}
