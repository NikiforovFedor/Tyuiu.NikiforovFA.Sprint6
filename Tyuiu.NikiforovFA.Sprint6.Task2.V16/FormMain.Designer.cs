namespace Tyuiu.NikiforovFA.Sprint6.Task2.V16
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
            groupBoxCondition_NFA = new GroupBox();
            pictureBoxFormula_NFA = new PictureBox();
            labelCondition_NFA = new Label();
            groupBoxInputData_NFA = new GroupBox();
            buttonDone_NFA = new Button();
            buttonHelp_NFA = new Button();
            textBoxStopStep_NFA = new TextBox();
            textBoxStartStep_NFA = new TextBox();
            labelStopStep_NFA = new Label();
            labelStartStep_NFA = new Label();
            groupBoxOutPut_NFA = new GroupBox();
            dataGridViewFunction_NFA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chartFunction_NFA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).BeginInit();
            groupBoxInputData_NFA.SuspendLayout();
            groupBoxOutPut_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NFA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NFA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(pictureBoxFormula_NFA);
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Location = new Point(12, 12);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(357, 320);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие: ";
            // 
            // pictureBoxFormula_NFA
            // 
            pictureBoxFormula_NFA.Image = Properties.Resources.Снимок_экрана_2024_12_07_143009;
            pictureBoxFormula_NFA.Location = new Point(0, 37);
            pictureBoxFormula_NFA.Name = "pictureBoxFormula_NFA";
            pictureBoxFormula_NFA.Size = new Size(345, 50);
            pictureBoxFormula_NFA.TabIndex = 1;
            pictureBoxFormula_NFA.TabStop = false;
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.AutoSize = true;
            labelCondition_NFA.Location = new Point(6, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(258, 15);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = "Произвести табулирование функции на [-5;5]";
            // 
            // groupBoxInputData_NFA
            // 
            groupBoxInputData_NFA.Controls.Add(buttonDone_NFA);
            groupBoxInputData_NFA.Controls.Add(buttonHelp_NFA);
            groupBoxInputData_NFA.Controls.Add(textBoxStopStep_NFA);
            groupBoxInputData_NFA.Controls.Add(textBoxStartStep_NFA);
            groupBoxInputData_NFA.Controls.Add(labelStopStep_NFA);
            groupBoxInputData_NFA.Controls.Add(labelStartStep_NFA);
            groupBoxInputData_NFA.Location = new Point(18, 338);
            groupBoxInputData_NFA.Name = "groupBoxInputData_NFA";
            groupBoxInputData_NFA.Size = new Size(351, 100);
            groupBoxInputData_NFA.TabIndex = 1;
            groupBoxInputData_NFA.TabStop = false;
            groupBoxInputData_NFA.Text = "Ввод данных: ";
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.BackColor = Color.Green;
            buttonDone_NFA.FlatStyle = FlatStyle.Flat;
            buttonDone_NFA.Location = new Point(264, 33);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(75, 61);
            buttonDone_NFA.TabIndex = 5;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = false;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            buttonDone_NFA.MouseEnter += buttonDone_NFA_MouseEnter;
            buttonDone_NFA.MouseLeave += buttonDone_NFA_MouseLeave;
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_NFA.Location = new Point(183, 33);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.Size = new Size(75, 61);
            buttonHelp_NFA.TabIndex = 4;
            buttonHelp_NFA.Text = "Справка";
            buttonHelp_NFA.UseVisualStyleBackColor = false;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click;
            // 
            // textBoxStopStep_NFA
            // 
            textBoxStopStep_NFA.Location = new Point(87, 53);
            textBoxStopStep_NFA.Name = "textBoxStopStep_NFA";
            textBoxStopStep_NFA.Size = new Size(78, 23);
            textBoxStopStep_NFA.TabIndex = 3;
            textBoxStopStep_NFA.Text = "5";
            textBoxStopStep_NFA.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStartStep_NFA
            // 
            textBoxStartStep_NFA.Location = new Point(6, 53);
            textBoxStartStep_NFA.Name = "textBoxStartStep_NFA";
            textBoxStartStep_NFA.Size = new Size(75, 23);
            textBoxStartStep_NFA.TabIndex = 2;
            textBoxStartStep_NFA.Text = "-5";
            // 
            // labelStopStep_NFA
            // 
            labelStopStep_NFA.AutoSize = true;
            labelStopStep_NFA.Location = new Point(87, 33);
            labelStopStep_NFA.Name = "labelStopStep_NFA";
            labelStopStep_NFA.Size = new Size(78, 15);
            labelStopStep_NFA.TabIndex = 1;
            labelStopStep_NFA.Text = "Конец шага: ";
            // 
            // labelStartStep_NFA
            // 
            labelStartStep_NFA.AutoSize = true;
            labelStartStep_NFA.Location = new Point(6, 33);
            labelStartStep_NFA.Name = "labelStartStep_NFA";
            labelStartStep_NFA.Size = new Size(75, 15);
            labelStartStep_NFA.TabIndex = 0;
            labelStartStep_NFA.Text = "Старт шага: ";
            // 
            // groupBoxOutPut_NFA
            // 
            groupBoxOutPut_NFA.Controls.Add(dataGridViewFunction_NFA);
            groupBoxOutPut_NFA.Controls.Add(chartFunction_NFA);
            groupBoxOutPut_NFA.Location = new Point(398, 12);
            groupBoxOutPut_NFA.Name = "groupBoxOutPut_NFA";
            groupBoxOutPut_NFA.Size = new Size(570, 426);
            groupBoxOutPut_NFA.TabIndex = 6;
            groupBoxOutPut_NFA.TabStop = false;
            groupBoxOutPut_NFA.Text = "Вывод данных: ";
            // 
            // dataGridViewFunction_NFA
            // 
            dataGridViewFunction_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_NFA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_NFA.Location = new Point(20, 37);
            dataGridViewFunction_NFA.Name = "dataGridViewFunction_NFA";
            dataGridViewFunction_NFA.RowHeadersVisible = false;
            dataGridViewFunction_NFA.Size = new Size(104, 383);
            dataGridViewFunction_NFA.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // chartFunction_NFA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NFA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_NFA.Legends.Add(legend1);
            chartFunction_NFA.Location = new Point(144, 37);
            chartFunction_NFA.Name = "chartFunction_NFA";
            chartFunction_NFA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NFA.Series.Add(series1);
            chartFunction_NFA.Size = new Size(426, 383);
            chartFunction_NFA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(groupBoxOutPut_NFA);
            Controls.Add(groupBoxInputData_NFA);
            Controls.Add(groupBoxCondition_NFA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 16 | Никифоров Ф. А.";
            groupBoxCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).EndInit();
            groupBoxInputData_NFA.ResumeLayout(false);
            groupBoxInputData_NFA.PerformLayout();
            groupBoxOutPut_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NFA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private PictureBox pictureBoxFormula_NFA;
        private GroupBox groupBoxInputData_NFA;
        private TextBox textBoxStopStep_NFA;
        private TextBox textBoxStartStep_NFA;
        private Label labelStopStep_NFA;
        private Label labelStartStep_NFA;
        private Button buttonDone_NFA;
        private Button buttonHelp_NFA;
        private GroupBox groupBoxOutPut_NFA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NFA;
        private DataGridView dataGridViewFunction_NFA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
