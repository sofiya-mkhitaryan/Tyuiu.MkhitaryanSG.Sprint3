using Tyuiu.MkhitaryanSG.Sprint3.Task4.V13.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 1.899;
            Assert.AreEqual(res, wait);
        }
    }
}
