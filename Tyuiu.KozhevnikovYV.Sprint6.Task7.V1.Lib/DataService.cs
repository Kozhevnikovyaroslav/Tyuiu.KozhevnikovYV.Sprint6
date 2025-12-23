using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KozhevnikovYV.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            lines = lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();

            int rows = lines.Length;
            int cols = lines[0].Split(';', StringSplitOptions.RemoveEmptyEntries).Length;

            int[,] matrix = new int[rows, cols];

            // 1) заполняем матрицу из файла
            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j].Trim());
                }
            }

            // 2) обработка: второй столбец (index 1)
            int colIndex = 1;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, colIndex] < 0)
                    matrix[i, colIndex] = 1;
            }

            return matrix;
        }
    }
}
