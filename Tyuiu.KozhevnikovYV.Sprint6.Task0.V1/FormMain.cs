using Tyuiu.KozhevnikovYV.Sprint6.Task0.V1.Lib;
using System.Text;
namespace Tyuiu.KozhevnikovYV.Sprint6.Task0.V1
{
    using System.Windows.Forms;
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-25-1 Кожевников Ярослав Вадимович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
