namespace Tyuiu.KozhevnikovYV.Sprint6.Task4.V20
{ using System.Text;
    using System.IO;
    using Tyuiu.KozhevnikovYV.Sprint6.Task4.V20.Lib;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = (Convert.ToInt32(textBoxStartStep.Text));
                int stopStep = (Convert.ToInt32(textBoxStopStep.Text));

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] mas = new double[len];

                mas = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, mas[i]);
                    textBoxResult.AppendText(mas[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string tempDir = Path.GetTempPath();
                string fileName = "OutPutFileTask0.txt";
                string path = Path.Combine(tempDir, fileName);
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogresult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
