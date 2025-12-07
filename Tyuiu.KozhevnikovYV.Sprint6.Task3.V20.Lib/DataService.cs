namespace Tyuiu.KozhevnikovYV.Sprint6.Task3.V20.Lib
{
    using System.Numerics;
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 4)
                    {
                        if (matrix[i, j] % 2 ==0)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j];
                    }
                }
            }
            return matrix;
        }
    }
}
