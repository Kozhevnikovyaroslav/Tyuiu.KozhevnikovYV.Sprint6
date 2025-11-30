namespace Tyuiu.KozhevnikovYV.Sprint6.Task0.V1.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint6;

    public class DataService : ISprint6Task0V1
    {
        public double Calculate(int x)
        {
            double y = x / (Math.Pow(x, 3) + 2);
            return Math.Round(y, 3);
        }
    }
}
