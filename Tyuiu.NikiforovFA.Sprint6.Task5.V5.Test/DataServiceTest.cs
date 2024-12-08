using Tyuiu.NikiforovFA.Sprint6.Task5.V5.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcValid()
        {
            DataService ds = new DataService();
            string s = @"C:\DataSprint6\InPutDataFileTask5V5.txt";
            double[] wait = { 10, 16, -12 };

            CollectionAssert.AreEqual(ds.LoadFromDataFile(s), wait);
        }
    }
}