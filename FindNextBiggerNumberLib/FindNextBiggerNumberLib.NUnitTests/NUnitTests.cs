﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumberLib.NUnitTests
{
    [TestFixture]
    public class NUnitTests
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        [TestCase(10, -1)]
        [TestCase(20, -1)]


        public void FindNumber_InsertNumber_ReturnedBiggerNumber(int number, int expected)
        {
            var actual = FNBNClassLib.FindNextBiggerNumber(number);
            Assert.AreEqual(expected, actual);

        }





    }
}
