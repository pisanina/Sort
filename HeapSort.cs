using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort 
{
    public class HeapSort : SortUtils, ISortAlgorithm 
    {
        public IComparable[] SortRun(IComparable[] ArrayToSort)
        {
            CreateHeap(ArrayToSort);
         //   MaxHeap(ArrayToSort, ArrayToSort.Length, 0);

            return ArrayToSort;
        }

        private static void CreateHeap(IComparable[] Array)
        {
            int HeapSize = Array.Length;
            for (int i = (HeapSize -1) /2; i >= 0; i--)
                MaxHeap(Array, HeapSize, i);

            for (int j = Array.Length - 1; j > 0; j--)
            {
                Swap(Array, j, 0);
                HeapSize--;
                MaxHeap(Array, HeapSize, 0);
            }
         }

        private static void MaxHeap(IComparable[] Array, int HeapSize, int Index)
        {
            int left = (Index + 1) * 2 - 1;
            int right = (Index + 1) * 2;
            int largest = 0;

            if (left < HeapSize && Array[left].CompareTo(Array[Index])>0)
                largest = left;
            else
                largest = Index;

            if (right < HeapSize && Array[right].CompareTo(Array[largest])>0)
                largest = right;
            
            if (largest != Index)
            {
                Swap(Array, Index, largest);
                MaxHeap(Array, HeapSize, largest);
            }
        }

         public HeapSort()
        {
            
        }
    }
}
