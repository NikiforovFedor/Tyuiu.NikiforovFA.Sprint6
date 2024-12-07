using Tyuiu.NikiforovFA.Sprint6.Task2.V16.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionValid()
        {
            DataService ds = new DataService();
            
            double[] wait = new double[11];
            wait[0] = -36.41;
            wait[1] = -22.07;
            wait[2] = 5.68;
            wait[3] = 16.72;
            wait[4] = 8.35;
            wait[5] = -0.50;
            wait[6] = 9.63;
            wait[7] = 16.29;
            wait[8] = 5.01;
            wait[9] = -22.40;
            wait[10] = -36.30;
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
        }
    }
}