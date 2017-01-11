using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program : ProgramUtils
    {
        static void Main(string[] args)
        {
            IComparable[] Array;
            int length;
            int WithAlgo;
            ISortAlgorithm metod;

            length = CheckInputOfLength();

            Array = new IComparable[length];
            RandomArray(Array, length);

            WithAlgo = ChooseSortAlgorithm(length);
            metod = ChosenAlgorithm(WithAlgo);

            Output(Array, Array.Length, metod);
            Console.ReadLine();
        }
    }
}

    

