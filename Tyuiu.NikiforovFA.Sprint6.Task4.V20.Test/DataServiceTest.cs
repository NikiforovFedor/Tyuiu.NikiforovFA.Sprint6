using Tyuiu.NikiforovFA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionValid()
        {
            DataService ds = new DataService();
            double[] wait = new double[11];
            wait[0] = 17.27;
            wait[1] = 14.08;
            wait[2] = 10.27;
            wait[3] = 6.65;
            wait[4] = 3.87;
            wait[5] = 2.00;
            wait[6] = -0.74;
            wait[7] = -3.71;
            wait[8] = -7.59;
            wait[9] = -11.55;
            wait[10] = -14.74;
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
        }
    }
}