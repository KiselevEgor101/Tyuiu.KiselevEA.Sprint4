using Tyuiu.KiselevEA.Sprint4.Task6.V15.Lib;
namespace Tyuiu.KiselevEA.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();

            var name = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(name);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}