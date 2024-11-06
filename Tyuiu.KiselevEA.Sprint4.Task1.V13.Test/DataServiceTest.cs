using Tyuiu.KiselevEA.Sprint4.Task1.V13.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] Array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(Array);
            int wait = 32;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}