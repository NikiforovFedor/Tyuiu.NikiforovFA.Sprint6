using Tyuiu.NikiforovFA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            int[,] array = { {  1, 2, 9, }
                            ,{  4, 5, 3 },
                             {  7 ,8, 6 } };
            int[,] wait = { {  1, 2, 3, }
                            ,{  4, 5, 6 },
                             {  7 ,8, 9 } };

            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}