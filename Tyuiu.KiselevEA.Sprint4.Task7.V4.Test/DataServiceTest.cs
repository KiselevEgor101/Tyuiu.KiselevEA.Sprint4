using Tyuiu.KiselevEA.Sprint4.Task7.V4.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int rows = 3;
            int cols = 4;
            int[,] mtrx = new int[rows, cols];
            string str = "382976421897";
            int res = ds.Calculate(rows, cols, str);
            int wait = 36;
            Assert.AreEqual(res, wait);
        }
    }
}