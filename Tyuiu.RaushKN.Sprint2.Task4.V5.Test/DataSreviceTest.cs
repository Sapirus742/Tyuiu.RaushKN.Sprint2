using Tyuiu.RaushKN.Sprint2.Task4.V5.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataSreviceTest
    {
        [TestMethod]
        public void ValidExpressionTrue()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 17.086;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidExpressionFalse()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 97;
            Assert.AreEqual(wait, res);
        }
    }
}