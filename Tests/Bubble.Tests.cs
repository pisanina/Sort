﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sort.Tests
{
    [TestFixture]
    class Bubble : SortTests
    {
        [SetUp]
        public void Setup()
        {
           metod = new BubbleSort();
        }
    }
}
