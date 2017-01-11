using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class MergeSort : ISortAlgorithm
    {
        public IComparable[] SortRun(IComparable[] ArrayToSort)
        {
            IComparable[] SortedArray = MergeSorting(ArrayToSort);
            for (int i = 0; i < SortedArray.Length; i++)
            {
                ArrayToSort[i] = SortedArray[i];
            }

          return ArrayToSort;
        }

        private static IComparable[] MergeSorting(IComparable[] ArrayToSort)
        {
            if (ArrayToSort.Length <= 1) return ArrayToSort;

            var Left = new List<IComparable>();
            var Right = new List<IComparable>();

            Divide(ArrayToSort, Left, Right);

            Left = MergeSorting(Left.ToArray()).ToList();
            Right = MergeSorting(Right.ToArray()).ToList();
            return Merge(Left, Right);
        }

        private static IComparable[] Merge(List<IComparable> Left, List<IComparable> Right)
        {
             List<IComparable> result = new List<IComparable>();

            while (Left.Count > 0 && Right.Count > 0)
            {
                if (Left.First().CompareTo(Right.First()) <= 0)
                    MoveValue(Left, result);
                else
                    MoveValue(Right, result);
            }

            while (Left.Count > 0)
                MoveValue(Left, result);

            while (Right.Count > 0)
                MoveValue(Right, result);

            return result.ToArray();
        }

        private static void Divide(IComparable[] ArrayToSort, List<IComparable> Left, 
                                   List<IComparable> Right)
        {
            for (int i = 0; i < ArrayToSort.Length; i++)
            {
                if (i % 2 > 0)
                    Left.Add(ArrayToSort[i]);
                else
                    Right.Add(ArrayToSort[i]);
            }
        }

        private static void MoveValue(List<IComparable> List, List<IComparable> result)
        {
            result.Add(List.First());
            List.RemoveAt(0);
        }

        public MergeSort()
        {
        
        }
    }
}
