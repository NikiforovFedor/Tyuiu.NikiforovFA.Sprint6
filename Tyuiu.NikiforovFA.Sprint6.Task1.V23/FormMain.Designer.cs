namespace Tyuiu.NikiforovFA.Sprint6.Task1.V23
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
            labelCondition_NFA = new Label();
            pictureBoxFormula_NFA = new PictureBox();
            groupBoxInputData_NFA = new GroupBox();
            labelEndStep_NFA = new Label();
            labelStartStep_NFA = new Label();
            textBoxEndStep_NFA = new TextBox();
            textBoxStartStep_NFA = new TextBox();
            groupBoxOutPutData_NFA = new GroupBox();
            textBoxResoult_NFA = new TextBox();
            labelResoult_NFA = new Label();
            buttonHelp_NFA = new Button();
            buttonDone_NFA = new Button();
            groupBoxButtons_NFA = new GroupBox();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).BeginInit();
            groupBoxInputData_NFA.SuspendLayout();
            groupBoxOutPutData_NFA.SuspendLayout();
            groupBoxButtons_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Controls.Add(pictureBoxFormula_NFA);
            groupBoxCondition_NFA.Location = new Point(12, 12);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(415, 316);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие: ";
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.AutoSize = true;
            labelCondition_NFA.Location = new Point(0, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(258, 15);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = "Произвести табулирование функции на [-5;5]";
            // 
            // pictureBoxFormula_NFA
            // 
            pictureBoxFormula_NFA.Image = Properties.Resources.Снимок_экрана_2024_12_06_182859;
            pictureBoxFormula_NFA.Location = new Point(0, 37);
            pictureBoxFormula_NFA.Name = "pictureBoxFormula_NFA";
            pictureBoxFormula_NFA.Size = new Size(351, 47);
            pictureBoxFormula_NFA.TabIndex = 1;
            pictureBoxFormula_NFA.TabStop = false;
            // 
            // groupBoxInputData_NFA
            // 
            groupBoxInputData_NFA.Controls.Add(labelEndStep_NFA);
            groupBoxInputData_NFA.Controls.Add(labelStartStep_NFA);
            groupBoxInputData_NFA.Controls.Add(textBoxEndStep_NFA);
            groupBoxInputData_NFA.Controls.Add(textBoxStartStep_NFA);
            groupBoxInputData_NFA.Location = new Point(12, 338);
            groupBoxInputData_NFA.Name = "groupBoxInputData_NFA";
            groupBoxInputData_NFA.Size = new Size(258, 100);
            groupBoxInputData_NFA.TabIndex = 1;
            groupBoxInputData_NFA.TabStop = false;
            groupBoxInputData_NFA.Text = "Ввод данных: ";
            // 
            // labelEndStep_NFA
            // 
            labelEndStep_NFA.AutoSize = true;
            labelEndStep_NFA.Location = new Point(137, 31);
            labelEndStep_NFA.Name = "labelEndStep_NFA";
            labelEndStep_NFA.Size = new Size(78, 15);
            labelEndStep_NFA.TabIndex = 3;
            labelEndStep_NFA.Text = "Конец шага: ";
            // 
            // labelStartStep_NFA
            // 
            labelStartStep_NFA.AutoSize = true;
            labelStartStep_NFA.Location = new Point(6, 31);
            labelStartStep_NFA.Name = "labelStartStep_NFA";
            labelStartStep_NFA.Size = new Size(75, 15);
            labelStartStep_NFA.TabIndex = 2;
            labelStartStep_NFA.Text = "Старт шага: ";
            // 
            // textBoxEndStep_NFA
            // 
            textBoxEndStep_NFA.Location = new Point(137, 54);
            textBoxEndStep_NFA.Name = "textBoxEndStep_NFA";
            textBoxEndStep_NFA.Size = new Size(100, 23);
            textBoxEndStep_NFA.TabIndex = 1;
            // 
            // textBoxStartStep_NFA
            // 
            textBoxStartStep_NFA.Location = new Point(6, 54);
            textBoxStartStep_NFA.Name = "textBoxStartStep_NFA";
            textBoxStartStep_NFA.Size = new Size(100, 23);
            textBoxStartStep_NFA.TabIndex = 0;
            textBoxStartStep_NFA.TextChanged += textBoxStartStep_NFA_TextChanged;
            // 
            // groupBoxOutPutData_NFA
            // 
            groupBoxOutPutData_NFA.Controls.Add(textBoxResoult_NFA);
            groupBoxOutPutData_NFA.Controls.Add(labelResoult_NFA);
            groupBoxOutPutData_NFA.Location = new Point(433, 12);
            groupBoxOutPutData_NFA.Name = "groupBoxOutPutData_NFA";
            groupBoxOutPutData_NFA.Size = new Size(355, 426);
            groupBoxOutPutData_NFA.TabIndex = 3;
            groupBoxOutPutData_NFA.TabStop = false;
            groupBoxOutPutData_NFA.Text = "Вывод данных: ";
            // 
            // textBoxResoult_NFA
            // 
            textBoxResoult_NFA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResoult_NFA.Location = new Point(6, 37);
            textBoxResoult_NFA.Multiline = true;
            textBoxResoult_NFA.Name = "textBoxResoult_NFA";
            textBoxResoult_NFA.ReadOnly = true;
            textBoxResoult_NFA.ScrollBars = ScrollBars.Vertical;
            textBoxResoult_NFA.Size = new Size(343, 383);
            textBoxResoult_NFA.TabIndex = 1;
            // 
            // labelResoult_NFA
            // 
            labelResoult_NFA.AutoSize = true;
            labelResoult_NFA.Location = new Point(6, 19);
            labelResoult_NFA.Name = "labelResoult_NFA";
            labelResoult_NFA.Size = new Size(66, 15);
            labelResoult_NFA.TabIndex = 0;
            labelResoult_NFA.Text = "Результат: ";
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_NFA.Location = new Point(6, 31);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.Size = new Size(54, 46);
            buttonHelp_NFA.TabIndex = 0;
            buttonHelp_NFA.Text = "Справка";
            buttonHelp_NFA.UseVisualStyleBackColor = false;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_NFA.Location = new Point(66, 31);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(79, 46);
            buttonDone_NFA.TabIndex = 1;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = false;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            // 
            // groupBoxButtons_NFA
            // 
            groupBoxButtons_NFA.Controls.Add(buttonDone_NFA);
            groupBoxButtons_NFA.Controls.Add(buttonHelp_NFA);
            groupBoxButtons_NFA.Location = new Point(276, 338);
            groupBoxButtons_NFA.Name = "groupBoxButtons_NFA";
            groupBoxButtons_NFA.Size = new Size(151, 100);
            groupBoxButtons_NFA.TabIndex = 2;
            groupBoxButtons_NFA.TabStop = false;
            groupBoxButtons_NFA.Text = "Управление";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPutData_NFA);
            Controls.Add(groupBoxButtons_NFA);
            Controls.Add(groupBoxInputData_NFA);
            Controls.Add(groupBoxCondition_NFA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 23 | Никифоров Ф. А.";
            groupBoxCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).EndInit();
            groupBoxInputData_NFA.ResumeLayout(false);
            groupBoxInputData_NFA.PerformLayout();
            groupBoxOutPutData_NFA.ResumeLayout(false);
            groupBoxOutPutData_NFA.PerformLayout();
            groupBoxButtons_NFA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private PictureBox pictureBoxFormula_NFA;
        private GroupBox groupBoxInputData_NFA;
        private Label labelEndStep_NFA;
        private Label labelStartStep_NFA;
        private TextBox textBoxEndStep_NFA;
        private TextBox textBoxStartStep_NFA;
        private GroupBox groupBoxOutPutData_NFA;
        private TextBox textBoxResoult_NFA;
        private Label labelResoult_NFA;
        private Button buttonHelp_NFA;
        private Button buttonDone_NFA;
        private GroupBox groupBoxButtons_NFA;
    }
}
