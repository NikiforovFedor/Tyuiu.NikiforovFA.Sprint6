using Tyuiu.NikiforovFA.Sprint6.Task0.V4.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(2), 22.1);
        }
    }
}