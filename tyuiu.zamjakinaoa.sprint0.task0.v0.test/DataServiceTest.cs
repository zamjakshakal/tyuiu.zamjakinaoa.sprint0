using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.zamjakinaoa.sprint0.task2.v0.lib;

namespace tyuiu.zamjakinaoa.sprint0.task2.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Олеся";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Олеся", res);
        }
    }
}
