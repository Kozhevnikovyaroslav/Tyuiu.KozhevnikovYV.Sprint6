namespace Tyuiu.KozhevnikovYV.Sprint6.Task3.V20.Test
{
    using Tyuiu.KozhevnikovYV.Sprint6.Task3.V20.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = { {-14, 17, -19, 3, 2},
                           {-4, -14, -19, -9, -1},
                           {1, 0, 13, 14, 8},
                           {13, 7, 8, -3, -15 },
                           {2, -20, 12, -14, 4 } };
            int[,] mas2 = ds.Calculate(mas);
            int[,] wait = { {-14, 17, -19, 3, 2},
                           {-4, -14, -19, -9, -1},
                           {1, 0, 13, 14, 8},
                           {13, 7, 8, -3, -15 },
                           {0, 0, 0, 0, 0 } };
            CollectionAssert.AreEqual(wait, mas2);
        }
    }
}
