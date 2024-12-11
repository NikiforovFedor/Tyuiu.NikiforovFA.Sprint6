using Tyuiu.NikiforovFA.Sprint6.Task6.V27.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFileValid()
        {
            DataService ds = new DataService();
            string s = @"C:\DataSprint6\Test.txt";
            Assert.AreEqual(ds.CollectTextFromFile(s), "Hello Holl ");


        }
    }
}