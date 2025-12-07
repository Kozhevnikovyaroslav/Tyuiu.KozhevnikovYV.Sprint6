namespace Tyuiu.KozhevnikovYV.Sprint6.Task2.V2
{   using Tyuiu.KozhevnikovYV.Sprint6.Task2.V2.Lib;
    using System.Text;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {   DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult.Titles.Add("График функция F(x)");

                this.chartResult.ChartAreas[0].AxisX.Title = ("Ось X");
                this.chartResult.ChartAreas[0].AxisY.Title = ("Ось Y");

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
