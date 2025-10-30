using Tyuiu.MkhitaryanSG.Sprint3.Task7.V23.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 13.29;
            valueWaitArray[1] = 13.31;
            valueWaitArray[2] = 11.48;
            valueWaitArray[3] = 8.42;
            valueWaitArray[4] = 5.73;
            valueWaitArray[5] = 4.00;
            valueWaitArray[6] = 2.27;
            valueWaitArray[7] = -0.42;
            valueWaitArray[8] = -3.48;
            valueWaitArray[9] = -5.31;
            valueWaitArray[10] = -5.29;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
