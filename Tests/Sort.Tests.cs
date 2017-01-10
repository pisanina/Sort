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

        //[TestFixture]
        //public class SortMetodsTest
        //{

        //    //MergeSort Metod;

       [SetUp]
       public void Setup()
       {

           SelectSort metod = new SelectSort();
           //metod = new SelectSort();
       }
               // int[] ArrayToSort = new int[] { 5, 4, 3, 2, 1 };
         //   ISortAlgorithm Algo1 = new SelectSort();
             
           // [TestCase(new Algo1())]
            [Test]
            public void EmptyInput()
            {
                int[] ArrayToSort = new int[] { };
                Assert.AreEqual(ArrayToSort, metod.SortRun(ArrayToSort));
            }

            [Test]
            public void OneElement()
            {
                int[] ArrayToSort = new int[] { 1 };
                Assert.AreEqual(ArrayToSort, SelectSort.SortRun(ArrayToSort));
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

                Assert.AreEqual(ArraySorted, SelectSort.SortRun(ArrayToSort));
                
            }
        }
    //}
}
