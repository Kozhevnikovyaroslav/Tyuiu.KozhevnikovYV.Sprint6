

namespace Tyuiu.KozhevnikovYV.Sprint6.V1
{
    using Tyuiu.KozhevnikovYV.Sprint6.Task1.V1.Lib;
    using System.Text;
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
            buttonResult_KYV = new Button();
            buttonInfo_KYV = new Button();
            groupBoxСondition_KYV = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxInfo_KYV = new TextBox();
            groupBoxInput_KYV = new GroupBox();
            labelStop = new Label();
            labelStart_KYV = new Label();
            textBoxStart_KYV = new TextBox();
            textBoxStop_KYV = new TextBox();
            groupBoxResult_KYV = new GroupBox();
            labelResult_KYV = new Label();
            textBoxResult_KYV = new TextBox();
            groupBoxСondition_KYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_KYV.SuspendLayout();
            groupBoxResult_KYV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonResult_KYV
            // 
            buttonResult_KYV.BackColor = Color.Chartreuse;
            buttonResult_KYV.Location = new Point(456, 385);
            buttonResult_KYV.Name = "buttonResult_KYV";
            buttonResult_KYV.Size = new Size(98, 53);
            buttonResult_KYV.TabIndex = 0;
            buttonResult_KYV.Text = "Выполнить";
            buttonResult_KYV.UseVisualStyleBackColor = false;
            buttonResult_KYV.Click += buttonResult_KYV_Click;
            // 
            // buttonInfo_KYV
            // 
            buttonInfo_KYV.BackColor = Color.RoyalBlue;
            buttonInfo_KYV.Location = new Point(372, 385);
            buttonInfo_KYV.Name = "buttonInfo_KYV";
            buttonInfo_KYV.Size = new Size(85, 53);
            buttonInfo_KYV.TabIndex = 1;
            buttonInfo_KYV.Text = "Сведения";
            buttonInfo_KYV.UseVisualStyleBackColor = false;
            // 
            // groupBoxСondition_KYV
            // 
            groupBoxСondition_KYV.Controls.Add(pictureBox1);
            groupBoxСondition_KYV.Controls.Add(textBoxInfo_KYV);
            groupBoxСondition_KYV.Location = new Point(12, 12);
            groupBoxСondition_KYV.Name = "groupBoxСondition_KYV";
            groupBoxСondition_KYV.Size = new Size(536, 325);
            groupBoxСondition_KYV.TabIndex = 2;
            groupBoxСondition_KYV.TabStop = false;
            groupBoxСondition_KYV.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(6, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxInfo_KYV
            // 
            textBoxInfo_KYV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInfo_KYV.Location = new Point(6, 26);
            textBoxInfo_KYV.Multiline = true;
            textBoxInfo_KYV.Name = "textBoxInfo_KYV";
            textBoxInfo_KYV.ReadOnly = true;
            textBoxInfo_KYV.Size = new Size(443, 69);
            textBoxInfo_KYV.TabIndex = 0;
            textBoxInfo_KYV.Text = " Протабулировать функцию на заданном диапазоне. Ответ вывести в таблицу.";
            // 
            // groupBoxInput_KYV
            // 
            groupBoxInput_KYV.Controls.Add(labelStop);
            groupBoxInput_KYV.Controls.Add(labelStart_KYV);
            groupBoxInput_KYV.Controls.Add(textBoxStart_KYV);
            groupBoxInput_KYV.Controls.Add(textBoxStop_KYV);
            groupBoxInput_KYV.Location = new Point(12, 343);
            groupBoxInput_KYV.Name = "groupBoxInput_KYV";
            groupBoxInput_KYV.Size = new Size(354, 95);
            groupBoxInput_KYV.TabIndex = 3;
            groupBoxInput_KYV.TabStop = false;
            groupBoxInput_KYV.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(191, 39);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(91, 20);
            labelStop.TabIndex = 4;
            labelStop.Text = "Конец шага";
            // 
            // labelStart_KYV
            // 
            labelStart_KYV.AutoSize = true;
            labelStart_KYV.Location = new Point(6, 39);
            labelStart_KYV.Name = "labelStart_KYV";
            labelStart_KYV.Size = new Size(85, 20);
            labelStart_KYV.TabIndex = 3;
            labelStart_KYV.Text = "Старт шага";
            // 
            // textBoxStart_KYV
            // 
            textBoxStart_KYV.Location = new Point(6, 62);
            textBoxStart_KYV.Name = "textBoxStart_KYV";
            textBoxStart_KYV.Size = new Size(157, 27);
            textBoxStart_KYV.TabIndex = 2;
            // 
            // textBoxStop_KYV
            // 
            textBoxStop_KYV.Location = new Point(191, 62);
            textBoxStop_KYV.Name = "textBoxStop_KYV";
            textBoxStop_KYV.Size = new Size(157, 27);
            textBoxStop_KYV.TabIndex = 1;
            // 
            // groupBoxResult_KYV
            // 
            groupBoxResult_KYV.Controls.Add(labelResult_KYV);
            groupBoxResult_KYV.Controls.Add(textBoxResult_KYV);
            groupBoxResult_KYV.Location = new Point(554, 12);
            groupBoxResult_KYV.Name = "groupBoxResult_KYV";
            groupBoxResult_KYV.Size = new Size(234, 416);
            groupBoxResult_KYV.TabIndex = 4;
            groupBoxResult_KYV.TabStop = false;
            groupBoxResult_KYV.Text = "Вывод данных";
            // 
            // labelResult_KYV
            // 
            labelResult_KYV.AutoSize = true;
            labelResult_KYV.Location = new Point(6, 23);
            labelResult_KYV.Name = "labelResult_KYV";
            labelResult_KYV.Size = new Size(75, 20);
            labelResult_KYV.TabIndex = 1;
            labelResult_KYV.Text = "Результат";
            // 
            // textBoxResult_KYV
            // 
            textBoxResult_KYV.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KYV.Location = new Point(6, 46);
            textBoxResult_KYV.Multiline = true;
            textBoxResult_KYV.Name = "textBoxResult_KYV";
            textBoxResult_KYV.ReadOnly = true;
            textBoxResult_KYV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KYV.Size = new Size(228, 361);
            textBoxResult_KYV.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_KYV);
            Controls.Add(groupBoxInput_KYV);
            Controls.Add(groupBoxСondition_KYV);
            Controls.Add(buttonInfo_KYV);
            Controls.Add(buttonResult_KYV);
            Name = "FormMain";
            Text = "Form1";
            groupBoxСondition_KYV.ResumeLayout(false);
            groupBoxСondition_KYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_KYV.ResumeLayout(false);
            groupBoxInput_KYV.PerformLayout();
            groupBoxResult_KYV.ResumeLayout(false);
            groupBoxResult_KYV.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonResult_KYV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KYV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KYV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KYV.Text = "";
                textBoxResult_KYV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KYV.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_KYV.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_KYV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KYV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private Button buttonResult_KYV;
        private Button buttonInfo_KYV;
        private GroupBox groupBoxСondition_KYV;
        private PictureBox pictureBox1;
        private TextBox textBoxInfo_KYV;
        private GroupBox groupBoxInput_KYV;
        private Label labelStart_KYV;
        private TextBox textBoxStart_KYV;
        private TextBox textBoxStop_KYV;
        private Label labelStop;
        private GroupBox groupBoxResult_KYV;
        private TextBox textBoxResult_KYV;
        private Label labelResult_KYV;
        
    }
}
