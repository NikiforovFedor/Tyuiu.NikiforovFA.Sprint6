using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task0.V4.Lib
{
    public class DataService : ISprint6Task0V4
    {
        public double Calculate(int x)
        {
            double res = (2.4 * (x * x * x) + 0.4 * (x * x) - 1.4 * x + 4.1);
            return Math.Round(res, 3);
        }
    }
}
