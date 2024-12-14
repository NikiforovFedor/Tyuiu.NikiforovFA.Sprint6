using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(string path)
        {
            int rows;
            int columns;
            string FileData = File.ReadAllText(path);
            FileData = FileData.Replace('\n', '\r');

            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line[j]);
                }
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[1, j] % 2 == 0)
                {
                    array[1, j] = 44;
                }
            }
            return array;
        }
    }
}
