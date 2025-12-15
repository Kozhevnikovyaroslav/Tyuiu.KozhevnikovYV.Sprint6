using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KozhevnikovYV.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double[] mas = new double[(stopValue - startValue) + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                int z = 3 * x - 1;
                if (z == 0)
                {
                    mas[count] = 0;
                }
                else
                {
                    double y = ((Math.Sin(x) - 2 * x) / z) + Math.Sin(x) - 3 * x + 2;
                    mas[count] = Math.Round(y,2);
                }
                count++;
            }
            return mas;
        }
    }
}
