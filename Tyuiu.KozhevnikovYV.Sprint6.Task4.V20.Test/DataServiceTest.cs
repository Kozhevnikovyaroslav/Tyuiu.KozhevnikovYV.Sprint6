namespace Tyuiu.KozhevnikovYV.Sprint6.Task4.V20.Test
{
    using Tyuiu.KozhevnikovYV.Sprint6.Task4.V20.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] mas = new double[11];
            int startValue = -5;
            int stopValue = 5;
            mas = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 17.27, 14.08, 10.27, 6.65, 3.87, 2.00, -0.74, -3.71, -7.59, -11.55, -14.74 };
            CollectionAssert.AreEqual(wait, mas);

        }
    }
}
