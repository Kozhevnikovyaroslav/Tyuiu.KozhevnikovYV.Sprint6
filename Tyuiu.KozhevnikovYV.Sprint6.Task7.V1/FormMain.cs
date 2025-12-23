namespace Tyuiu.KozhevnikovYV.Sprint6.Task7.V1
{
    using System.IO;
    using Tyuiu.KozhevnikovYV.Sprint6.Task7.V1.Lib;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int row;
        static int col;
        public static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadIntMatrixFromCsv(string path)
        {
            char separator = ';';
            var rowsList = new List<int[]>();

            using (var reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    int[] row = new int[parts.Length];
                    for (int i = 0; i < parts.Length; i++)
                        row[i] = int.Parse(parts[i].Trim());

                    rowsList.Add(row);
                }
            }

            if (rowsList.Count == 0)
                throw new Exception("Файл пустой");

            int rows = rowsList.Count;
            int cols = rowsList[0].Length;

            // проверка, что в каждой строке одинаковое число столбцов
            for (int r = 0; r < rows; r++)
                if (rowsList[r].Length != cols)
                    throw new Exception($"Строка {r + 1} имеет {rowsList[r].Length} элементов, ожидалось {cols}");

            int[,] matrix = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    matrix[r, c] = rowsList[r][c];
            row = rows;
            col = cols;

            return matrix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] arrayValues = new int[row, col];

            arrayValues = LoadIntMatrixFromCsv(openFilePath);

            dataGridView1.ColumnCount = col;
            dataGridView1.RowCount = row;
            dataGridView2.ColumnCount = col;
            dataGridView2.RowCount = row;

            for (int i = 0; i < col; i++)
            {
                dataGridView1.Columns[i].Width = 50;
                dataGridView2.Columns[i].Width = 50;
            }
            for (int r = 0; r < col; r++)
            {
                for (int c = 0;c < row; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] res = ds.GetMatrix(openFilePath);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    dataGridView2.Rows[r].Cells[c].Value = res[r, c];
                }
            }

        }
    }
}
