using Tyuiu.NikiforovFA.Sprint6.Task7.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrixValid()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint6\\Test.csv";
            int[,] wait = { { 1, 1 }, { 2, 44 } };
            CollectionAssert.AreEqual(ds.GetMatrix(path), wait);
        }
    }
}