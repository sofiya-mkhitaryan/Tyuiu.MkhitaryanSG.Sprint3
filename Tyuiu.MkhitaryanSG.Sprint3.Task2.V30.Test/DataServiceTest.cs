using Tyuiu.MkhitaryanSG.Sprint3.Task2.V30.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 5.121;
            Assert.AreEqual(res, wait);
        }
    }
}
