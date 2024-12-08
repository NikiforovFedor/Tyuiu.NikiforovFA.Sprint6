using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] res = new double[stopValue - startValue + 1];
            int k = 0;
            for (int x = startValue; x < stopValue + 1; x++)
            {
                if ((3*x-1) != 0)
                {
                    res[k] = Math.Round((Math.Sin(x) - 2*x)/(3*x-1) + Math.Sin(x) - 3 * x + 2, 2);
                    k++;
                }
                else { res[k] = 0; k++; }
            }
            return res;
        }
    }
}
