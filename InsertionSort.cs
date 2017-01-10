using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sort
{
    class InsertionSort : SortUtils
    { 
        public static int[] SortRun(int[] ArrayToSort)
        {
            int CurrentElement;
            for (int Index = 1; Index < ArrayToSort.Length; Index++)
            {
                CurrentElement = Index;
                while ((CurrentElement > 0) && (ArrayToSort[CurrentElement - 1] > ArrayToSort[CurrentElement]))
                {
                    Swap(ArrayToSort, CurrentElement, CurrentElement - 1);
                    CurrentElement--;
                }   
            }
                return ArrayToSort;
        }
         public InsertionSort()
        {
            // TODO: Complete member initialization
            // int foo;
        }
    }


}
