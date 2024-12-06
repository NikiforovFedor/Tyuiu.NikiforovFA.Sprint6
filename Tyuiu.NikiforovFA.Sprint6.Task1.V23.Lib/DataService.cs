using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int c = 0;
            int len = (stopValue - startValue) + 1;
            double[] result = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Round((Math.Sin(x)) + ((2.0*x) / 3.0) - Math.Cos(x) * (4.0 * x), 2);
                result[c] = y;
                c++;
            }

            return result;
        }
    }
}
