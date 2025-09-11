using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.PuzyrevIV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void ChekSubstractionArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, };
            var res = DataService.SubtrationArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void ChekSubtractionArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
