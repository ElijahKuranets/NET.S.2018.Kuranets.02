using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertNumberLibTests
{
    [TestClass]
    public class InsertNumberClassLibTests
    {
        [TestMethod]
        public void InsertNumber_8in15_9returned()
        {
            var result = InsertNumberLib.InsertNumberClassLib.InsertNumber(8, 15, 0, 0);
            int expected = 9;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InsertNumber_8in15_120returned()
        {
            var result = InsertNumberLib.InsertNumberClassLib.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, result);
        }
    }
}
