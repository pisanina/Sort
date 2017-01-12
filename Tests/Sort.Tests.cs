using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

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
               // metod.SortRun(ArrayToSort).ShouldBeEmpty();
            }

            [Test]
            public void OneElement()
            {
                IComparable[] ArrayToSort = new IComparable[] { 1 };
                Assert.AreEqual(ArrayToSort, metod.SortRun(ArrayToSort));
                metod.SortRun(ArrayToSort).ShouldBe(ArrayToSort);
            }

            [Test]
            public void SortingStrings()
            {
                String[] ArrayToSort = new String[] { "ca", "a", "bb", "ba" };
                String[] ArraySorted = new String[] { "a", "ba", "bb", "ca" };
                Assert.AreEqual(ArrayToSort, metod.SortRun(ArrayToSort));
               // Should.CompleteIn(() => metod.SortRun(ArrayToSort), TimeSpan.FromMilliseconds(10));
            }

            [Test]
            public void AreSortingWorks()
            {
                IComparable[] ArrayToSort = new IComparable[] { 5, 1, 3, 4, 2 };
                IComparable[] ArraySorted = new IComparable[] { 1, 2, 3, 4, 5 };
                Assert.AreEqual(ArraySorted, metod.SortRun(ArrayToSort));
                metod.SortRun(ArrayToSort).ShouldBe(ArraySorted);
            }

            [Test]
            public void SortingWithNegativeNumbers()
            {
                IComparable[] ArrayToSort = new IComparable[] { 5, 1, 3, 4, 2, -5, 0 };
                IComparable[] ArraySorted = new IComparable[] { -5, 0, 1, 2, 3, 4, 5 };
                Assert.AreEqual(ArraySorted, metod.SortRun(ArrayToSort));
                metod.SortRun(ArrayToSort).ShouldBe(ArraySorted);
            }
            //[Test]
            //public void SortingNotWorksWithFloat()
            //{
            //    IComparable[] ArrayToSort = new IComparable[] { 6.3, 1.2, 3.0, 4, 2 };
            //    IComparable[] ArraySorted = new IComparable[] { 1.2, 2, 3.0, 4, 6.3 };
            //    Assert.AreEqual(ArraySorted, metod.SortRun(ArrayToSort));
            //    metod.SortRun(ArrayToSort).ShouldBe(ArraySorted);
            //}
       
        }
    //}
}
