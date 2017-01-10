using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests 
{

   abstract public class SortTests 
    {

            protected ISortAlgorithm metod;
             
            [Test]
            public void EmptyInput()
            {
                IComparable[] ArrayToSort = new IComparable[] { };
                Assert.AreEqual(ArrayToSort, metod.SortRun(ArrayToSort));
            }

            [Test]
            public void OneElement()
            {
                IComparable[] ArrayToSort = new IComparable[] { 1 };
                Assert.AreEqual(ArrayToSort, metod.SortRun(ArrayToSort));
            }

            [Test]
            public void InvalidTypeInput()
            {
              //  String a="a", b="b", c="c";
                String[] ArrayToSort = new String[] { "a", "b", "c" };
               // Assert.AreEqual(ArrayToSort, MergeSort.MergeSortRun(ArrayToSort));
            }

            [Test]
            public void AreSortingWorks()
            {
                IComparable[] ArrayToSort = new IComparable[] { 5, 1, 3, 4, 2 };
                IComparable[] ArraySorted = new IComparable[] { 1, 2, 3, 4, 5 };

                Assert.AreEqual(ArraySorted, metod.SortRun(ArrayToSort));
                
            }
        }
    //}
}
