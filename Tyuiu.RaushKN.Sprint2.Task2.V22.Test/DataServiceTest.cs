using Tyuiu.RaushKN.Sprint2.Task2.V22.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 12;
            int y = 10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait,res);
        }
    }
}