using Tyuiu.MkhitaryanSG.Sprint3.Task5.V30.Lib;
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
            int stopValue1 = 11;
            int startValue2 = 1;
            int stopValue2 = 3;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 9;
            Assert.AreEqual(res, wait);
        }
    }
}
