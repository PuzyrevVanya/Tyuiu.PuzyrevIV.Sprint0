using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PuzyrevIV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
       public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Иван";
            var res = DataService.GetMessege(name);

            // Вызываем класс Assert и методов AreEqual
            Assert.AreEqual("Привет, Иван", res);
        }
    }
}
