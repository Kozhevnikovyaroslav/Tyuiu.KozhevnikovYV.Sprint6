namespace Tyuiu.KozhevnikovYV.Sprint6.Task4.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition = new GroupBox();
            pictureBox1 = new PictureBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult = new TextBox();
            GroupBoxResult = new GroupBox();
            groupBoxInput = new GroupBox();
            labelStop = new Label();
            labelstart = new Label();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            GroupBoxResult.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBox1);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(537, 313);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(555, 12);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(626, 549);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 243);
            textBoxResult.TabIndex = 2;
            // 
            // GroupBoxResult
            // 
            GroupBoxResult.Controls.Add(textBoxResult);
            GroupBoxResult.Location = new Point(412, 331);
            GroupBoxResult.Name = "GroupBoxResult";
            GroupBoxResult.Size = new Size(137, 284);
            GroupBoxResult.TabIndex = 3;
            GroupBoxResult.TabStop = false;
            GroupBoxResult.Text = "Вывод";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(labelStop);
            groupBoxInput.Controls.Add(labelstart);
            groupBoxInput.Controls.Add(textBoxStopStep);
            groupBoxInput.Controls.Add(textBoxStartStep);
            groupBoxInput.Location = new Point(12, 331);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(384, 284);
            groupBoxInput.TabIndex = 4;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(238, 104);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(91, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага";
            // 
            // labelstart
            // 
            labelstart.AutoSize = true;
            labelstart.Location = new Point(16, 104);
            labelstart.Name = "labelstart";
            labelstart.Size = new Size(85, 20);
            labelstart.TabIndex = 2;
            labelstart.Text = "Старт шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(238, 127);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(125, 27);
            textBoxStopStep.TabIndex = 1;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(16, 127);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(977, 586);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 48);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1087, 586);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 48);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 692);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxInput);
            Controls.Add(GroupBoxResult);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            GroupBoxResult.ResumeLayout(false);
            GroupBoxResult.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private TextBox textBoxResult;
        private GroupBox GroupBoxResult;
        private GroupBox groupBoxInput;
        private Label labelStop;
        private Label labelstart;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private Button buttonDone;
        private Button buttonSave;
    }
}
