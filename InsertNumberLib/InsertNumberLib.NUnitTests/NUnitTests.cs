using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberLib.NUnitTests
{
    [TestFixture]
    public class NUnitTests
    {
        [TestCase(15, 15, 0, 0, 15)]
        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(8, 15, 3, 8, 120)]

        public void InsertNumber_(int firstnum,int secondnum, byte i, byte j, int expected )
        {
            var actual = InsertNumberClassLib.InsertNumber(firstnum, secondnum, i, j);
            Assert.AreEqual(expected, actual);
           
        }
    }
}
