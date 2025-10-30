using Tyuiu.MkhitaryanSG.Sprint3.Task6.V27.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 99;

            Assert.AreEqual(res, wait);
        }
    }
}
