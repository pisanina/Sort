using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests 
{       
   
    class SortTests
    {

        [TestFixture]
        public class SortMetodsTest
        {

            MergeSort Metod;

            [SetUp]
            public void Setup()
            {

                MergeSort Metod = new MergeSort();
               // int[] ArrayToSort = new int[] { 5, 4, 3, 2, 1 };

            }
            [Test]
            public void EmptyInput()
            {
                int[] ArrayToSort = new int[] { };
                Assert.AreEqual(ArrayToSort, MergeSort.MergeSortRun(ArrayToSort));
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
                int[] ArrayToSort = new int[] { 5, 1, 3, 4, 2 };
                int[] ArraySorted = new int[] { 1, 2, 3, 4, 5 };

                Assert.AreEqual(ArraySorted, MergeSort.MergeSortRun(ArrayToSort));
                
            }
        }
    }
}
