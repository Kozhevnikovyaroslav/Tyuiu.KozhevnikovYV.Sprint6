namespace Tyuiu.KozhevnikovYV.Sprint6.Task3.V20
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Tyuiu.KozhevnikovYV.Sprint6.Task3.V20.Lib;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mas = { {-14, 17, -19, 3, 2},
                       {-4, -14, -19, -9, -1},
                       {1, 0, 13, 14, 8},
                       {13, 7, 8, -3, -15 },
                       {2, -20, 12, -14, 4 } };

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] masclone = (int[,])mas.Clone();
            int[,] mas1 = ds.Calculate(masclone);
            int rows = mas.GetLength(0);
            int cols = mas.GetLength(1);
            dataGridViewResult.RowCount = rows;
            dataGridViewResult.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;
            dataGridViewMatrix.ColumnCount = cols;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = mas[i, j];
                }
                
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = mas1[i, j];
                }

            }
        }
    }

}
