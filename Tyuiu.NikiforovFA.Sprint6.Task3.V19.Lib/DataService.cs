using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[] c = new int[rows];
            int[,] res = new int[rows, columns];

            int k = 0;
            for (int i = 0; i < rows; i++)

            {

                c[k++] = matrix[i, columns-1];

            }
            Array.Sort(c);
            k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == (columns - 1))
                    {
                        res[i, j] = c[k];
                        k++;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }

                }
            }
            return res;
        }
    }
}
