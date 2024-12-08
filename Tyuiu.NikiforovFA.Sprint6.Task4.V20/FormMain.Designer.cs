namespace Tyuiu.NikiforovFA.Sprint6.Task4.V20
{
    partial class FormMain_NFA
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
            panelCondition_NFA = new Panel();
            buttonDone_NFA = new Button();
            buttonSave_NFA = new Button();
            buttonHelp_NFA = new Button();
            groupBoxInput_NFA = new GroupBox();
            textBoxStopStep_NFA = new TextBox();
            textBoxStartStep_NFA = new TextBox();
            labelStopStep_NFA = new Label();
            labelStartStep_NFA = new Label();
            groupBoxCondition_NFA = new GroupBox();
            chartFunction_NFA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_NFA = new GroupBox();
            textBoxOutput_NFA = new TextBox();
            splitContainerOutput_NFA = new SplitContainer();
            panelCondition_NFA.SuspendLayout();
            groupBoxInput_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NFA).BeginInit();
            groupBoxOutput_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_NFA).BeginInit();
            splitContainerOutput_NFA.Panel1.SuspendLayout();
            splitContainerOutput_NFA.Panel2.SuspendLayout();
            splitContainerOutput_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // panelCondition_NFA
            // 
            panelCondition_NFA.Controls.Add(buttonDone_NFA);
            panelCondition_NFA.Controls.Add(buttonSave_NFA);
            panelCondition_NFA.Controls.Add(buttonHelp_NFA);
            panelCondition_NFA.Controls.Add(groupBoxInput_NFA);
            panelCondition_NFA.Controls.Add(groupBoxCondition_NFA);
            panelCondition_NFA.Dock = DockStyle.Top;
            panelCondition_NFA.Location = new Point(0, 0);
            panelCondition_NFA.Name = "panelCondition_NFA";
            panelCondition_NFA.Size = new Size(984, 102);
            panelCondition_NFA.TabIndex = 0;
            panelCondition_NFA.Paint += panelCondition_NFA_Paint;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.BackColor = Color.Green;
            buttonDone_NFA.Cursor = Cursors.Hand;
            buttonDone_NFA.Location = new Point(484, 22);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(87, 67);
            buttonDone_NFA.TabIndex = 4;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = false;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            // 
            // buttonSave_NFA
            // 
            buttonSave_NFA.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_NFA.Cursor = Cursors.Hand;
            buttonSave_NFA.Location = new Point(577, 22);
            buttonSave_NFA.Name = "buttonSave_NFA";
            buttonSave_NFA.Size = new Size(75, 67);
            buttonSave_NFA.TabIndex = 4;
            buttonSave_NFA.Text = "Сохранить";
            buttonSave_NFA.UseVisualStyleBackColor = false;
            buttonSave_NFA.Click += buttonSave_NFA_Click;
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NFA.BackColor = Color.FromArgb(255, 192, 128);
            buttonHelp_NFA.Cursor = Cursors.Hand;
            buttonHelp_NFA.Location = new Point(897, 22);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.Size = new Size(75, 67);
            buttonHelp_NFA.TabIndex = 4;
            buttonHelp_NFA.Text = "Справка";
            buttonHelp_NFA.UseVisualStyleBackColor = false;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click;
            // 
            // groupBoxInput_NFA
            // 
            groupBoxInput_NFA.Controls.Add(textBoxStopStep_NFA);
            groupBoxInput_NFA.Controls.Add(textBoxStartStep_NFA);
            groupBoxInput_NFA.Controls.Add(labelStopStep_NFA);
            groupBoxInput_NFA.Controls.Add(labelStartStep_NFA);
            groupBoxInput_NFA.Location = new Point(253, 3);
            groupBoxInput_NFA.Name = "groupBoxInput_NFA";
            groupBoxInput_NFA.Size = new Size(225, 99);
            groupBoxInput_NFA.TabIndex = 1;
            groupBoxInput_NFA.TabStop = false;
            groupBoxInput_NFA.Text = "Ввод данных";
            // 
            // textBoxStopStep_NFA
            // 
            textBoxStopStep_NFA.Location = new Point(110, 40);
            textBoxStopStep_NFA.Name = "textBoxStopStep_NFA";
            textBoxStopStep_NFA.Size = new Size(64, 23);
            textBoxStopStep_NFA.TabIndex = 2;
            textBoxStopStep_NFA.Text = "5";
            // 
            // textBoxStartStep_NFA
            // 
            textBoxStartStep_NFA.Location = new Point(6, 40);
            textBoxStartStep_NFA.Name = "textBoxStartStep_NFA";
            textBoxStartStep_NFA.Size = new Size(64, 23);
            textBoxStartStep_NFA.TabIndex = 2;
            textBoxStartStep_NFA.Text = "-5";
            // 
            // labelStopStep_NFA
            // 
            labelStopStep_NFA.AutoSize = true;
            labelStopStep_NFA.Location = new Point(110, 18);
            labelStopStep_NFA.Name = "labelStopStep_NFA";
            labelStopStep_NFA.Size = new Size(72, 15);
            labelStopStep_NFA.TabIndex = 1;
            labelStopStep_NFA.Text = "Конец шага";
            // 
            // labelStartStep_NFA
            // 
            labelStartStep_NFA.AutoSize = true;
            labelStartStep_NFA.Location = new Point(6, 19);
            labelStartStep_NFA.Name = "labelStartStep_NFA";
            labelStartStep_NFA.Size = new Size(69, 15);
            labelStartStep_NFA.TabIndex = 0;
            labelStartStep_NFA.Text = "Старт шага";
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Location = new Point(5, 0);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(242, 100);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие: ";
            groupBoxCondition_NFA.Enter += groupBoxCondition_NFA_Enter;
            // 
            // chartFunction_NFA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NFA.ChartAreas.Add(chartArea1);
            chartFunction_NFA.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_NFA.Legends.Add(legend1);
            chartFunction_NFA.Location = new Point(0, 0);
            chartFunction_NFA.Name = "chartFunction_NFA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NFA.Series.Add(series1);
            chartFunction_NFA.Size = new Size(717, 509);
            chartFunction_NFA.TabIndex = 0;
            chartFunction_NFA.Click += chart1_Click;
            // 
            // groupBoxOutput_NFA
            // 
            groupBoxOutput_NFA.Controls.Add(textBoxOutput_NFA);
            groupBoxOutput_NFA.Dock = DockStyle.Fill;
            groupBoxOutput_NFA.Location = new Point(0, 0);
            groupBoxOutput_NFA.Name = "groupBoxOutput_NFA";
            groupBoxOutput_NFA.Size = new Size(263, 509);
            groupBoxOutput_NFA.TabIndex = 0;
            groupBoxOutput_NFA.TabStop = false;
            groupBoxOutput_NFA.Text = "Вывод данных";
            // 
            // textBoxOutput_NFA
            // 
            textBoxOutput_NFA.Dock = DockStyle.Fill;
            textBoxOutput_NFA.Location = new Point(3, 19);
            textBoxOutput_NFA.Multiline = true;
            textBoxOutput_NFA.Name = "textBoxOutput_NFA";
            textBoxOutput_NFA.ReadOnly = true;
            textBoxOutput_NFA.Size = new Size(257, 487);
            textBoxOutput_NFA.TabIndex = 0;
            // 
            // splitContainerOutput_NFA
            // 
            splitContainerOutput_NFA.Dock = DockStyle.Fill;
            splitContainerOutput_NFA.Location = new Point(0, 102);
            splitContainerOutput_NFA.Name = "splitContainerOutput_NFA";
            // 
            // splitContainerOutput_NFA.Panel1
            // 
            splitContainerOutput_NFA.Panel1.Controls.Add(groupBoxOutput_NFA);
            // 
            // splitContainerOutput_NFA.Panel2
            // 
            splitContainerOutput_NFA.Panel2.Controls.Add(chartFunction_NFA);
            splitContainerOutput_NFA.Size = new Size(984, 509);
            splitContainerOutput_NFA.SplitterDistance = 263;
            splitContainerOutput_NFA.TabIndex = 3;
            // 
            // FormMain_NFA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(splitContainerOutput_NFA);
            Controls.Add(panelCondition_NFA);
            MinimumSize = new Size(800, 450);
            Name = "FormMain_NFA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 20 | Никифоров Ф. А.";
            panelCondition_NFA.ResumeLayout(false);
            groupBoxInput_NFA.ResumeLayout(false);
            groupBoxInput_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NFA).EndInit();
            groupBoxOutput_NFA.ResumeLayout(false);
            groupBoxOutput_NFA.PerformLayout();
            splitContainerOutput_NFA.Panel1.ResumeLayout(false);
            splitContainerOutput_NFA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_NFA).EndInit();
            splitContainerOutput_NFA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCondition_NFA;
        private GroupBox groupBoxCondition_NFA;
        private Panel panel1;
        private GroupBox groupBoxOutput_NFA;
        private GroupBox groupBoxInput_NFA;
        private Label labelStopStep_NFA;
        private Label labelStartStep_NFA;
        private TextBox textBoxOutput_NFA;
        private Button buttonDone_NFA;
        private Button buttonSave_NFA;
        private Button buttonHelp_NFA;
        private TextBox textBoxStopStep_NFA;
        private TextBox textBoxStartStep_NFA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NFA;
        private Splitter splitter1;
        private SplitContainer splitContainerOutput_NFA;
    }
}
