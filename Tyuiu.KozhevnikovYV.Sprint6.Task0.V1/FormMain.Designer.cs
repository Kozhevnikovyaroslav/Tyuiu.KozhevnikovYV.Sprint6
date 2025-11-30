using Tyuiu.KozhevnikovYV.Sprint6.Task0.V1.Lib;
using System.Text;
using System.Windows.Forms;
namespace Tyuiu.KozhevnikovYV.Sprint6.Task0.V1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            pictureBoxFunction_KYV = new PictureBox();
            groupBoxAll_KYV = new GroupBox();
            groupBoxOutput_KYV = new GroupBox();
            labelOutput_KYV = new Label();
            textBoxOutput_KYV = new TextBox();
            groupBoxUnput_KYV = new GroupBox();
            labelInput_KYV = new Label();
            textBoxInput_KYV = new TextBox();
            labelСondition_KYV = new Label();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_KYV).BeginInit();
            groupBoxAll_KYV.SuspendLayout();
            groupBoxOutput_KYV.SuspendLayout();
            groupBoxUnput_KYV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(677, 393);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(111, 44);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBoxFunction_KYV
            // 
            pictureBoxFunction_KYV.Image = (Image)resources.GetObject("pictureBoxFunction_KYV.Image");
            pictureBoxFunction_KYV.Location = new Point(615, 56);
            pictureBoxFunction_KYV.Name = "pictureBoxFunction_KYV";
            pictureBoxFunction_KYV.Size = new Size(113, 50);
            pictureBoxFunction_KYV.TabIndex = 4;
            pictureBoxFunction_KYV.TabStop = false;
            // 
            // groupBoxAll_KYV
            // 
            groupBoxAll_KYV.Controls.Add(groupBoxOutput_KYV);
            groupBoxAll_KYV.Controls.Add(groupBoxUnput_KYV);
            groupBoxAll_KYV.Controls.Add(labelСondition_KYV);
            groupBoxAll_KYV.Controls.Add(pictureBoxFunction_KYV);
            groupBoxAll_KYV.Location = new Point(12, 13);
            groupBoxAll_KYV.Name = "groupBoxAll_KYV";
            groupBoxAll_KYV.Size = new Size(776, 355);
            groupBoxAll_KYV.TabIndex = 5;
            groupBoxAll_KYV.TabStop = false;
            groupBoxAll_KYV.Text = "Условие:";
            // 
            // groupBoxOutput_KYV
            // 
            groupBoxOutput_KYV.Controls.Add(labelOutput_KYV);
            groupBoxOutput_KYV.Controls.Add(textBoxOutput_KYV);
            groupBoxOutput_KYV.Location = new Point(493, 226);
            groupBoxOutput_KYV.Name = "groupBoxOutput_KYV";
            groupBoxOutput_KYV.Size = new Size(277, 114);
            groupBoxOutput_KYV.TabIndex = 8;
            groupBoxOutput_KYV.TabStop = false;
            groupBoxOutput_KYV.Text = "Вывод данных:";
            // 
            // labelOutput_KYV
            // 
            labelOutput_KYV.AutoSize = true;
            labelOutput_KYV.Location = new Point(6, 58);
            labelOutput_KYV.Name = "labelOutput_KYV";
            labelOutput_KYV.Size = new Size(78, 20);
            labelOutput_KYV.TabIndex = 1;
            labelOutput_KYV.Text = "Результат:";
            // 
            // textBoxOutput_KYV
            // 
            textBoxOutput_KYV.Location = new Point(6, 81);
            textBoxOutput_KYV.Name = "textBoxOutput_KYV";
            textBoxOutput_KYV.ReadOnly = true;
            textBoxOutput_KYV.Size = new Size(152, 27);
            textBoxOutput_KYV.TabIndex = 0;
            // 
            // groupBoxUnput_KYV
            // 
            groupBoxUnput_KYV.Controls.Add(labelInput_KYV);
            groupBoxUnput_KYV.Controls.Add(textBoxInput_KYV);
            groupBoxUnput_KYV.Location = new Point(6, 226);
            groupBoxUnput_KYV.Name = "groupBoxUnput_KYV";
            groupBoxUnput_KYV.Size = new Size(470, 114);
            groupBoxUnput_KYV.TabIndex = 6;
            groupBoxUnput_KYV.TabStop = false;
            groupBoxUnput_KYV.Text = "Ввод данных:";
            // 
            // labelInput_KYV
            // 
            labelInput_KYV.AutoSize = true;
            labelInput_KYV.Location = new Point(178, 58);
            labelInput_KYV.Name = "labelInput_KYV";
            labelInput_KYV.Size = new Size(112, 20);
            labelInput_KYV.TabIndex = 7;
            labelInput_KYV.Text = "Переменная x:";
            // 
            // textBoxInput_KYV
            // 
            textBoxInput_KYV.Location = new Point(173, 81);
            textBoxInput_KYV.Name = "textBoxInput_KYV";
            textBoxInput_KYV.Size = new Size(125, 27);
            textBoxInput_KYV.TabIndex = 7;
            textBoxInput_KYV.KeyPress += textBoxInput_KeyPress;
            // 
            // labelСondition_KYV
            // 
            labelСondition_KYV.AutoSize = true;
            labelСondition_KYV.Location = new Point(6, 56);
            labelСondition_KYV.Name = "labelСondition_KYV";
            labelСondition_KYV.Size = new Size(236, 20);
            labelСondition_KYV.TabIndex = 5;
            labelСondition_KYV.Text = "Решить выражение по формуле:";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(627, 400);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(39, 31);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxAll_KYV);
            Controls.Add(buttonDone);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 1 | Кожевников Я. В.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_KYV).EndInit();
            groupBoxAll_KYV.ResumeLayout(false);
            groupBoxAll_KYV.PerformLayout();
            groupBoxOutput_KYV.ResumeLayout(false);
            groupBoxOutput_KYV.PerformLayout();
            groupBoxUnput_KYV.ResumeLayout(false);
            groupBoxUnput_KYV.PerformLayout();
            ResumeLayout(false);
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_KYV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_KYV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons .OK, MessageBoxIcon.Error );
            }

        }
          private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47) ||  (e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        #endregion

        private Button buttonDone;
        private PictureBox pictureBoxFunction_KYV;
        private GroupBox groupBoxAll_KYV;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox_KYV;
        private Label labelInput_KYV;
        private GroupBox groupBoxUnput_KYV;
        private TextBox textBoxInput_KYV;
        private Label labelСondition_KYV;
        private GroupBox groupBoxOutput_KYV;
        private Label labelOutput_KYV;
        private TextBox textBoxOutput_KYV;
        private Button buttonHelp;
    }
}
