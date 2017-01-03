using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class QuickSort : SortUtils
    {
        public static int[] QuickSortRun(int[] ArrayToSort)
        {
            var SortedArray = QuickSortGo(ArrayToSort, 0, ArrayToSort.Length-1);
            for (int i = 0; i < SortedArray.Length; i++)
                ArrayToSort[i] = SortedArray[i];
            return ArrayToSort;
        }

        private static int[] QuickSortGo(int[] ArrayToSort, int left, int right)
        {
           // int left, right;
            int i = left;
            int j = right;
            int pivot = ArrayToSort.Length / 2;
 
            while (i <= j)
            {
                while (ArrayToSort[i].CompareTo(pivot) < 0 )
                     i++;
             
                while (ArrayToSort[j].CompareTo(pivot) > 0)
                     j--;
            
                if (i <= j)
                {
                    Swap( ArrayToSort, i, j);
                    i++;
                    j--;
                }
            }

            if (left < j)
               QuickSortGo(ArrayToSort, left, j);
             
            if (i < right)
                QuickSortGo(ArrayToSort, i, right);
             
          return ArrayToSort;
        }
    }
}
