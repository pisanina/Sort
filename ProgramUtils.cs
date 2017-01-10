using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
   public class ProgramUtils
    {
        public static void PrintTable(int[] ToPrint)
        {
            for (int i = 0; i < ToPrint.Length; i++)
                Console.Write(ToPrint[i] + " ");
            Console.Write("\n");
        }

        public static void PrintOutput(int[] ToPrint)
        {
            DateTime Timer = DateTime.Now;
            PrintTable(ToPrint);
            long ms = (long)(DateTime.Now - Timer).TotalMilliseconds;
            Console.WriteLine("Lenght of array: " + ToPrint.Length + " Time of sort: " + ms + " ms");
        }

        public static int[] RandomArray(int[] Array, int lenght)
        {
            Random rnd = new Random();
            for (int i = 0; i < lenght; i++)
                Array[i] = rnd.Next(0, lenght);
            return Array;
        }
    }
}
