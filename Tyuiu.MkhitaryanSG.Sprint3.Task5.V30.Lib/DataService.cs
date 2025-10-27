using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue1; j <= stopValue1; j++)
                {
                    sumSeries = sumSeries + ((Math.Pow(x, 3) - i) + x);
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
