using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    public class BubbleSort
    {
        //public int[] ArrayToSort
        //{
        //  get { return ArrayToSort; }
        //  set { ArrayToSort = value; }
        // }

        public int[] BubbleSortMetod(int[] ArrayToSort)
        {
            ArrayToSort = new int[] { 19, 17, 15, 12, 10, 8, 6, 5, 2, 1 };

            int Lenght = ArrayToSort.Length;
            int Iteration = 0;
            bool Swapped = true;

            while (Iteration < (Lenght - 1) && Swapped)
            {
                Swapped = false;
                for (int j = 0; j < (Lenght - 1 - Iteration); j++)
                    if (ArrayToSort[j] > ArrayToSort[j + 1])
                        Swap(ArrayToSort, j, j++);
                Swapped = true;
            }
            return ArrayToSort;
        }

        void Swap(int[] array, int a, int b)
        {
            int Buffor = array[a];
            array[a] = array[b];
            array[b] = Buffor;

        }
    }

}
