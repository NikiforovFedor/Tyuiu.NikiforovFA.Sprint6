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
            int[,] mat = { { 1, 1 }, { 2, 2 } };
            int[,] wait = { { 1, 1 }, { 2, 44 } };
            CollectionAssert.AreEqual(ds.GetMatrix(mat), wait);
        }
    }
}