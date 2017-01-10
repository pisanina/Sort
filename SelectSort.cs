using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectSort : SortUtils
    {
         public static int[] SortRun(int[] ArrayToSort)
        {
            int Lenght = ArrayToSort.Length;
            int MinIndex;

            for (int i = 0; i < Lenght - 1; i++)
            {
                MinIndex = i;
                for (int j = i+1; j < Lenght; j++)
                {
                    if (ArrayToSort[j] < ArrayToSort[MinIndex])
                        MinIndex = j;
                }
                if (MinIndex != i)
                    Swap(ArrayToSort, MinIndex, i);
            }
            return ArrayToSort;
        }
         public SelectSort()
        {
            // TODO: Complete member initialization
            // int foo;
        }
    }
}
