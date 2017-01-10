using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    public class BubbleSort : SortUtils
    {
          public static int[] SortRun(int[] ArrayToSort)
         {
            int Lenght = ArrayToSort.Length;
            int Iteration = 0;
            bool Swapped = true;

            while (Iteration < (Lenght - 1) && Swapped)
            {
                Swapped = false;
                for (int j = 0; j < (Lenght - 1 - Iteration); j++)
                    if (ArrayToSort[j] > ArrayToSort[j + 1])
                        Swap(ArrayToSort, j, j+1);
                Swapped = true;
                Iteration++;
            }
            return ArrayToSort;
        }

         public BubbleSort()
        {
            // TODO: Complete member initialization
            // int foo;
        }
    }
}
