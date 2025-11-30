namespace Tyuiu.KozhevnikovYV.Sprint6.Task0.V1.Test
{
    using Tyuiu.KozhevnikovYV.Sprint6.Task0.V1.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            double y = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(y, wait);
        }
    }
}
