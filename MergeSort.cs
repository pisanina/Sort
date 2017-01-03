using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class MergeSort
    {

        public static int[] MergeSortRun( int[] ArrayToSort)
        {
            var SortedArray = MergeSorting(ArrayToSort);
            for (int i = 0; i < SortedArray.Length; i++)
            {
                ArrayToSort[i] = SortedArray[i];
            }

            return ArrayToSort;
        }
        private static int[] MergeSorting(int[] ArrayToSort)
        {
            if (ArrayToSort.Length <= 1) return ArrayToSort;
            
            var Left = new List<int>();
            var Right = new List<int>();

            Divide (ArrayToSort, Left, Right);

            Left = MergeSorting(Left.ToArray()).ToList();
            Right = MergeSorting(Right.ToArray()).ToList();
            return Merge(Left, Right);
        }

        private static int[] Merge(List<int> Left, List<int> Right)
        {
            var result = new List<int>();

            while (Left.Count > 0 && Right.Count > 0)
            {
                if (Left.First() <= Right.First())
                    MoveValue (Left, result);
                else
                    MoveValue (Right, result);
            }

            while (Left.Count > 0)
                MoveValue (Left, result);

            while (Right.Count > 0)
                MoveValue (Right, result);

            return result.ToArray();
        }

        private static void Divide(int[] ArrayToSort, List<int> Left, List<int> Right)
        {
            for (int i = 0; i < ArrayToSort.Length; i++)
            {
                if (i % 2 > 0)
                    Left.Add(ArrayToSort[i]);
                else
                    Right.Add(ArrayToSort[i]);
            }
        }

        private static void MoveValue(List<int> List, List<int> result)
        {
            result.Add(List.First());
            List.RemoveAt(0);
        }
    }
}
