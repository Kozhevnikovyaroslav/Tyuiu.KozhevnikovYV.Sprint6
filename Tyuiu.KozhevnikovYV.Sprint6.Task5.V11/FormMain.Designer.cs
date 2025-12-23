namespace Tyuiu.KozhevnikovYV.Sprint6.Task5.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            dataGridViewFile = new DataGridView();
            chartFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFile).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(694, 409);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 29);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewFile
            // 
            dataGridViewFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFile.Location = new Point(12, 12);
            dataGridViewFile.Name = "dataGridViewFile";
            dataGridViewFile.RowHeadersWidth = 51;
            dataGridViewFile.Size = new Size(300, 375);
            dataGridViewFile.TabIndex = 1;
            // 
            // chartFile
            // 
            chartArea1.Name = "ChartArea1";
            chartFile.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFile.Legends.Add(legend1);
            chartFile.Location = new Point(328, 12);
            chartFile.Name = "chartFile";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFile.Series.Add(series1);
            chartFile.Size = new Size(460, 375);
            chartFile.TabIndex = 2;
            chartFile.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartFile);
            Controls.Add(dataGridViewFile);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private DataGridView dataGridViewFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFile;
    }
}
