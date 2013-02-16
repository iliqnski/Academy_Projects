using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.NumberInArray;

namespace _16.UnitTestTask04
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 2, 2, -3, 2 };

            int result = NumberInArray.GetNumber(arr, 2);
            Assert.AreEqual(3, result);
        }
    }
}
