namespace Tyuiu.KozhevnikovYV.Sprint6.Task5.V11
{
    using Tyuiu.KozhevnikovYV.Sprint6.Task5.V11.Lib;
    using System.Text;
    using System.IO;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string tempDir = @"C:\DataSprint6";
        string fileName = "InPutDataFileTask5V11.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(tempDir, fileName);
            dataGridViewFile.ColumnCount = 2;
            dataGridViewFile.Columns[0].Width = 20;
            dataGridViewFile.Columns[1].Width = 50;

            this.chartFile.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartFile.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartFile.Series[0].Points.Clear();

            double[] mas = ds.LoadFromDataFile(path);
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewFile.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chartFile.Series[0].Points.AddXY(i, mas[i]);
            }
        }
    }
}
