using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue-startValue + 1];
            int k = 0;
            for (int x = startValue; x < stopValue + 1; x++)
            {
                if (x - 0.4 != 0)
                {
                    res[k] = Math.Round(((Math.Cos(x)) / (x - 0.4)) + Math.Sin(x) * 8.0 * x + 2.0, 2);
                    k++;
                }
                else { res[k] = 0; k++; }
            }
            return res;

        }
    }
}
