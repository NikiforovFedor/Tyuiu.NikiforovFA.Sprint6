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

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 1] % 2 == 0)
                {
                    array[i, 1] = 44;
                }
            }
            return array;
        }
    }
}
