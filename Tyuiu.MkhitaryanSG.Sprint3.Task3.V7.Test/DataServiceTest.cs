using Tyuiu.MkhitaryanSG.Sprint3.Task3.V7.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string expected = "4ft h44t nt4";

            Assert.AreEqual(expected, res);
        }
    }
}
