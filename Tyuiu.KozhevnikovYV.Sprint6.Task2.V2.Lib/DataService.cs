namespace Tyuiu.KozhevnikovYV.Sprint6.Task2.V2.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task2V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mas = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Sin(x) + (2 / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x;
                mas[count] = Math.Round(y, 2);
                count++;
            }
            return mas;
        }
    }
}
