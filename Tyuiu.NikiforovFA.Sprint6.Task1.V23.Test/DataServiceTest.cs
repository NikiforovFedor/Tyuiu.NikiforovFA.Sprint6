using Tyuiu.NikiforovFA.Sprint6.Task1.V23.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionValid()
        {
            DataService dataService = new DataService();
            double[] wait = new double[11];
            wait[0] = 3.30;
            wait[1] = -12.37;
            wait[2] = -14.02;
            wait[3] = -5.57;
            wait[4] = 0.65;
            wait[5] = 0;
            wait[6] = -0.65;
            wait[7] = 5.57;
            wait[8] = 14.02;
            wait[9] = 12.37;
            wait[10] = -3.30;
            CollectionAssert.AreEqual(wait, dataService.GetMassFunction(-5, 5));
        }
    }
}