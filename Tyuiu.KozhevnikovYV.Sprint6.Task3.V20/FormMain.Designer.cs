
namespace Tyuiu.KozhevnikovYV.Sprint6.Task3.V20
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
            groupBoxCondition = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            label1 = new Label();
            dataGridViewMatrix = new DataGridView();
            label2 = new Label();
            dataGridViewResult = new DataGridView();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(buttonInfo);
            groupBoxCondition.Controls.Add(buttonDone);
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Location = new Point(12, 13);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(486, 292);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // buttonInfo
            // 
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Location = new Point(321, 235);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(43, 51);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(370, 235);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(110, 51);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Name = "label1";
            label1.Size = new Size(346, 40);
            label1.TabIndex = 0;
            label1.Text = "Дана матрица 5 на 5\r\nЗаменить четные элементы из 5 строки на нули.";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewMatrix.Location = new Point(513, 36);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(288, 268);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 13);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 3;
            label2.Text = "Изначальная матрица";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10 });
            dataGridViewResult.Location = new Point(807, 36);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(288, 268);
            dataGridViewResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(807, 13);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 5;
            label3.Text = "Полученная матрица";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 50;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 311);
            Controls.Add(label3);
            Controls.Add(dataGridViewResult);
            Controls.Add(label2);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(groupBoxCondition);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupBoxCondition;
        private Label label1;
        private DataGridView dataGridViewMatrix;
        private Button buttonInfo;
        private Button buttonDone;
        private Label label2;
        private DataGridView dataGridViewResult;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
