namespace Tyuiu.NikiforovFA.Sprint6.Task5.V5
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
            panelCondition_NFA = new Panel();
            buttonHelp_NFA = new Button();
            buttonOpenFile_NFA = new Button();
            buttonDone_NFA = new Button();
            groupBoxCondition_NFA = new GroupBox();
            labelCondition_NFA = new Label();
            splitContainerOutput_NFA = new SplitContainer();
            groupBoxOutput_NFA = new GroupBox();
            dataGridViewOutput_NFA = new DataGridView();
            chartDiarramm_NFA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelCondition_NFA.SuspendLayout();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_NFA).BeginInit();
            splitContainerOutput_NFA.Panel1.SuspendLayout();
            splitContainerOutput_NFA.Panel2.SuspendLayout();
            splitContainerOutput_NFA.SuspendLayout();
            groupBoxOutput_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_NFA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiarramm_NFA).BeginInit();
            SuspendLayout();
            // 
            // panelCondition_NFA
            // 
            panelCondition_NFA.Controls.Add(buttonHelp_NFA);
            panelCondition_NFA.Controls.Add(buttonOpenFile_NFA);
            panelCondition_NFA.Controls.Add(buttonDone_NFA);
            panelCondition_NFA.Controls.Add(groupBoxCondition_NFA);
            panelCondition_NFA.Dock = DockStyle.Top;
            panelCondition_NFA.Location = new Point(0, 0);
            panelCondition_NFA.Name = "panelCondition_NFA";
            panelCondition_NFA.Size = new Size(681, 102);
            panelCondition_NFA.TabIndex = 1;
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NFA.BackColor = Color.FromArgb(255, 192, 128);
            buttonHelp_NFA.Cursor = Cursors.Hand;
            buttonHelp_NFA.Location = new Point(594, 19);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.Size = new Size(75, 77);
            buttonHelp_NFA.TabIndex = 1;
            buttonHelp_NFA.Text = "Справка";
            buttonHelp_NFA.UseVisualStyleBackColor = false;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click;
            // 
            // buttonOpenFile_NFA
            // 
            buttonOpenFile_NFA.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile_NFA.Cursor = Cursors.Hand;
            buttonOpenFile_NFA.Location = new Point(461, 19);
            buttonOpenFile_NFA.Name = "buttonOpenFile_NFA";
            buttonOpenFile_NFA.Size = new Size(75, 77);
            buttonOpenFile_NFA.TabIndex = 1;
            buttonOpenFile_NFA.Text = "Открыть файл";
            buttonOpenFile_NFA.UseVisualStyleBackColor = false;
            buttonOpenFile_NFA.Click += buttonOpenFile_NFA_Click;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_NFA.Cursor = Cursors.Hand;
            buttonDone_NFA.Location = new Point(380, 19);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(75, 77);
            buttonDone_NFA.TabIndex = 1;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = false;
            buttonDone_NFA.Click += buttonDone_NFA_Click_1;
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Location = new Point(5, 0);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(369, 100);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие: ";
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.Location = new Point(7, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(356, 32);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести все числа, кратные 2.";
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
            splitContainerOutput_NFA.Panel2.Controls.Add(chartDiarramm_NFA);
            splitContainerOutput_NFA.Size = new Size(681, 481);
            splitContainerOutput_NFA.SplitterDistance = 227;
            splitContainerOutput_NFA.TabIndex = 2;
            // 
            // groupBoxOutput_NFA
            // 
            groupBoxOutput_NFA.Controls.Add(dataGridViewOutput_NFA);
            groupBoxOutput_NFA.Dock = DockStyle.Fill;
            groupBoxOutput_NFA.Location = new Point(0, 0);
            groupBoxOutput_NFA.Name = "groupBoxOutput_NFA";
            groupBoxOutput_NFA.Size = new Size(227, 481);
            groupBoxOutput_NFA.TabIndex = 1;
            groupBoxOutput_NFA.TabStop = false;
            groupBoxOutput_NFA.Text = "Вывод данных";
            // 
            // dataGridViewOutput_NFA
            // 
            dataGridViewOutput_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_NFA.Dock = DockStyle.Fill;
            dataGridViewOutput_NFA.Location = new Point(3, 19);
            dataGridViewOutput_NFA.Name = "dataGridViewOutput_NFA";
            dataGridViewOutput_NFA.ReadOnly = true;
            dataGridViewOutput_NFA.RowHeadersVisible = false;
            dataGridViewOutput_NFA.Size = new Size(221, 459);
            dataGridViewOutput_NFA.TabIndex = 0;
            // 
            // chartDiarramm_NFA
            // 
            chartArea1.Name = "ChartArea1";
            chartDiarramm_NFA.ChartAreas.Add(chartArea1);
            chartDiarramm_NFA.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartDiarramm_NFA.Legends.Add(legend1);
            chartDiarramm_NFA.Location = new Point(0, 0);
            chartDiarramm_NFA.Name = "chartDiarramm_NFA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiarramm_NFA.Series.Add(series1);
            chartDiarramm_NFA.Size = new Size(450, 481);
            chartDiarramm_NFA.TabIndex = 0;
            chartDiarramm_NFA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 583);
            Controls.Add(splitContainerOutput_NFA);
            Controls.Add(panelCondition_NFA);
            MinimumSize = new Size(650, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 5 | Никифоров Ф. А.";
            panelCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.ResumeLayout(false);
            splitContainerOutput_NFA.Panel1.ResumeLayout(false);
            splitContainerOutput_NFA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerOutput_NFA).EndInit();
            splitContainerOutput_NFA.ResumeLayout(false);
            groupBoxOutput_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_NFA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiarramm_NFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCondition_NFA;
        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private SplitContainer splitContainerOutput_NFA;
        private GroupBox groupBoxOutput_NFA;
        private DataGridView dataGridViewOutput_NFA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiarramm_NFA;
        private Button buttonHelp_NFA;
        private Button buttonOpenFile_NFA;
        private Button buttonDone_NFA;
    }
}
