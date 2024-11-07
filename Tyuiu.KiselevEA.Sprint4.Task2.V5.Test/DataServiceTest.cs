using Tyuiu.KiselevEA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] nums = { 4, 7, 3, 5, 5, 6, 4, 5, 6, 2, 8, 7, 3, 9};
            int res = ds.Calculate(nums);
            int wait = 9216;
            Assert.AreEqual(wait,res);
        }
    }
}