using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i,1] % 2 == 0)
                {
                    matrix[i, 1] = 44;
                }
            }  
            return matrix;
        }
    }
}
