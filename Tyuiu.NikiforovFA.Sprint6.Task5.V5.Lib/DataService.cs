using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task5.V5.Lib
{
    public class DataService : ISprint6Task5V5
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line)) % 2 == 0)
                    {
                        len++;
                    }
                    
                }
            }
            double[] res = new double[len];
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line)) % 2 == 0)
                    {
                        res[k++] = Convert.ToDouble(line);
                    }
                }
            }
            return res;
        }
    }
}
