namespace Tyuiu.NikiforovFA.Sprint6.Task3.V19
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
            groupBoxCondition_NFA = new GroupBox();
            textBoxMatrix_NFA = new TextBox();
            dataGridViewMatrix_NFA = new DataGridView();
            labelCondition_NFA = new Label();
            groupBoxOutPutData = new GroupBox();
            textBoxResoult_NFA = new TextBox();
            buttonHelp_NFA = new Button();
            buttonDone_NFA = new Button();
            labelResoult_NFA = new Label();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NFA).BeginInit();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(textBoxMatrix_NFA);
            groupBoxCondition_NFA.Controls.Add(dataGridViewMatrix_NFA);
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Location = new Point(12, 12);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(590, 333);
            groupBoxCondition_NFA.TabIndex = 2;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие: ";
            // 
            // textBoxMatrix_NFA
            // 
            textBoxMatrix_NFA.Location = new Point(6, 54);
            textBoxMatrix_NFA.Multiline = true;
            textBoxMatrix_NFA.Name = "textBoxMatrix_NFA";
            textBoxMatrix_NFA.ReadOnly = true;
            textBoxMatrix_NFA.Size = new Size(286, 174);
            textBoxMatrix_NFA.TabIndex = 5;
            textBoxMatrix_NFA.Text = "\r\n4 32-20 27 21\r\n17 15 -1 -2 -1\r\n-3 18 12-10 29\r\n7-15 2 -8 12\r\n-10 25 5 27 21";
            textBoxMatrix_NFA.TextChanged += textBox2_TextChanged;
            // 
            // dataGridViewMatrix_NFA
            // 
            dataGridViewMatrix_NFA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMatrix_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMatrix_NFA.ColumnHeadersVisible = false;
            dataGridViewMatrix_NFA.EnableHeadersVisualStyles = false;
            dataGridViewMatrix_NFA.Location = new Point(325, 22);
            dataGridViewMatrix_NFA.Name = "dataGridViewMatrix_NFA";
            dataGridViewMatrix_NFA.ReadOnly = true;
            dataGridViewMatrix_NFA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMatrix_NFA.RowHeadersVisible = false;
            dataGridViewMatrix_NFA.ScrollBars = ScrollBars.None;
            dataGridViewMatrix_NFA.Size = new Size(265, 263);
            dataGridViewMatrix_NFA.TabIndex = 3;
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.AutoSize = true;
            labelCondition_NFA.Location = new Point(6, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(286, 30);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = "Дана матрица 5 на 5.\r\nОтсортировать последний столбец по возрастаню\r\n";
            labelCondition_NFA.Click += labelCondition_NFA_Click;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxResoult_NFA);
            groupBoxOutPutData.Controls.Add(buttonHelp_NFA);
            groupBoxOutPutData.Controls.Add(buttonDone_NFA);
            groupBoxOutPutData.Controls.Add(labelResoult_NFA);
            groupBoxOutPutData.Location = new Point(639, 12);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(223, 333);
            groupBoxOutPutData.TabIndex = 3;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Выыод данных: ";
            // 
            // textBoxResoult_NFA
            // 
            textBoxResoult_NFA.Location = new Point(6, 54);
            textBoxResoult_NFA.Multiline = true;
            textBoxResoult_NFA.Name = "textBoxResoult_NFA";
            textBoxResoult_NFA.ReadOnly = true;
            textBoxResoult_NFA.Size = new Size(211, 103);
            textBoxResoult_NFA.TabIndex = 8;
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_NFA.Location = new Point(6, 262);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.Size = new Size(75, 61);
            buttonHelp_NFA.TabIndex = 7;
            buttonHelp_NFA.Text = "Справка";
            buttonHelp_NFA.UseVisualStyleBackColor = false;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.BackColor = Color.Green;
            buttonDone_NFA.FlatStyle = FlatStyle.Flat;
            buttonDone_NFA.Location = new Point(142, 262);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(75, 58);
            buttonDone_NFA.TabIndex = 6;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = false;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            // 
            // labelResoult_NFA
            // 
            labelResoult_NFA.AutoSize = true;
            labelResoult_NFA.Location = new Point(6, 22);
            labelResoult_NFA.Name = "labelResoult_NFA";
            labelResoult_NFA.Size = new Size(66, 15);
            labelResoult_NFA.TabIndex = 0;
            labelResoult_NFA.Text = "Результат: ";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 367);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBoxCondition_NFA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Никифоров Ф. А.";
            Load += FormLoad;
            groupBoxCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NFA).EndInit();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxMatrix_NFA;
        private DataGridView dataGridViewMatrix_NFA;
        private Label labelResoult_NFA;
        private Button buttonDone_NFA;
        private Button buttonHelp_NFA;
        private TextBox textBoxResoult_NFA;
    }
}
