﻿using Tyuiu.MkhitaryanSG.Sprint3.Task5.V30.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 81;
            Assert.AreEqual(res, wait);
        }
    }
}
