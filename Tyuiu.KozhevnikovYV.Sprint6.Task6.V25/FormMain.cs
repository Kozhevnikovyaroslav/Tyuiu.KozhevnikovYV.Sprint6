namespace Tyuiu.KozhevnikovYV.Sprint6.Task6.V25
{ using Tyuiu.KozhevnikovYV.Sprint6.Task6.V25.Lib;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBox1.Text = File.ReadAllText(openFilePath);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = ds.CollectTextFromFile(openFilePath); 
        }
    }
}
