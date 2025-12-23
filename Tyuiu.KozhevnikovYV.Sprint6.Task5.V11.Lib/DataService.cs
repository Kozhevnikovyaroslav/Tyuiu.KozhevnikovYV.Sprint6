namespace Tyuiu.KozhevnikovYV.Sprint6.Task5.V11.Lib
{
    using System.Globalization;
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint6;

    public class DataService : ISprint6Task5V11
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader  = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (( line = reader.ReadLine()) != null)
                {
                    if (!double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
                    {
                        Console.WriteLine("нипалучилос");
                    }
                    numsArray[index] = x;
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val % 5 == 0).ToArray();

            return numsArray;
        }
    }
}
