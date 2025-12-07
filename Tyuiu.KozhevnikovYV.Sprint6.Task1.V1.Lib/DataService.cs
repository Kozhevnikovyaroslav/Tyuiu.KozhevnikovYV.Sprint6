namespace Tyuiu.KozhevnikovYV.Sprint6.Task1.V1.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] mas = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x < stopValue; x++)
            {
                if (x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(2 * x) + (Math.Sin(x)) / x * 2.5 + 2 * x;
                }
                mas[count] = y;
                count++;
            }
            return mas;
        }
    }
}
