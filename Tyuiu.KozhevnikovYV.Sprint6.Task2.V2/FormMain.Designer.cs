namespace Tyuiu.KozhevnikovYV.Sprint6.Task2.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBoxCondition = new GroupBox();
            pictureBoxCondition = new PictureBox();
            groupBoxInput = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            labelResult = new Label();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(411, 372);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(124, 65);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(319, 372);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(86, 66);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Сведения";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Location = new Point(13, 13);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(522, 319);
            groupBoxCondition.TabIndex = 2;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Image = (Image)resources.GetObject("pictureBoxCondition.Image");
            pictureBoxCondition.Location = new Point(6, 66);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(510, 169);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelStop);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Controls.Add(textBoxStop);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Location = new Point(13, 338);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(300, 100);
            groupBoxInput.TabIndex = 3;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(169, 34);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(91, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 35);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(169, 58);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 58);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(541, 14);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(624, 424);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(16, 32);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат";
            // 
            // chartResult
            // 
            chartArea2.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartResult.Legends.Add(legend2);
            chartResult.Location = new Point(218, 55);
            chartResult.Name = "chartResult";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult.Series.Add(series2);
            chartResult.Size = new Size(400, 363);
            chartResult.TabIndex = 5;
            chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewResult.Location = new Point(16, 55);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(185, 363);
            dataGridViewResult.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 90;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxCondition);
            Controls.Add(buttonInfo);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonInfo;
        private GroupBox groupBoxCondition;
        private PictureBox pictureBoxCondition;
        private GroupBox groupBoxInput;
        private Label labelStop;
        private Label labelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private GroupBox groupBoxResult;
        private Label labelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
