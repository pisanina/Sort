using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SortUtils 
    {
        public static void Swap(IComparable[] array, int a, int b)
        {
            IComparable temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
