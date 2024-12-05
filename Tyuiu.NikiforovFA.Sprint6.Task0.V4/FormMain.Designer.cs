namespace Tyuiu.NikiforovFA.Sprint6.Task0.V4
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
            groupBoxCondition_NFA = new GroupBox();
            labelCondition_NFA = new Label();
            groupBoxInputData_NFA = new GroupBox();
            labelInputData_NFA = new Label();
            groupBoxOutPutData_NFA = new GroupBox();
            buttonHelp_NFA = new Button();
            buttonDone_NFA = new Button();
            textBoxResoult_NFA = new TextBox();
            labelResoult_NFA = new Label();
            pictureBoxFormula_NFA = new PictureBox();
            groupBoxCondition_NFA.SuspendLayout();
            groupBoxInputData_NFA.SuspendLayout();
            groupBoxOutPutData_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(pictureBoxFormula_NFA);
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Location = new Point(12, 12);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(776, 235);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие:";
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.Location = new Point(6, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(381, 138);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = resources.GetString("labelCondition_NFA.Text");
            // 
            // groupBoxInputData_NFA
            // 
            groupBoxInputData_NFA.Controls.Add(labelInputData_NFA);
            groupBoxInputData_NFA.Location = new Point(12, 272);
            groupBoxInputData_NFA.Name = "groupBoxInputData_NFA";
            groupBoxInputData_NFA.Size = new Size(535, 166);
            groupBoxInputData_NFA.TabIndex = 1;
            groupBoxInputData_NFA.TabStop = false;
            groupBoxInputData_NFA.Text = "Ввод данных";
            // 
            // labelInputData_NFA
            // 
            labelInputData_NFA.AutoSize = true;
            labelInputData_NFA.Location = new Point(6, 19);
            labelInputData_NFA.Name = "labelInputData_NFA";
            labelInputData_NFA.Size = new Size(28, 15);
            labelInputData_NFA.TabIndex = 0;
            labelInputData_NFA.Text = "X=3";
            // 
            // groupBoxOutPutData_NFA
            // 
            groupBoxOutPutData_NFA.Controls.Add(buttonHelp_NFA);
            groupBoxOutPutData_NFA.Controls.Add(buttonDone_NFA);
            groupBoxOutPutData_NFA.Controls.Add(textBoxResoult_NFA);
            groupBoxOutPutData_NFA.Controls.Add(labelResoult_NFA);
            groupBoxOutPutData_NFA.Location = new Point(582, 272);
            groupBoxOutPutData_NFA.Name = "groupBoxOutPutData_NFA";
            groupBoxOutPutData_NFA.Size = new Size(206, 166);
            groupBoxOutPutData_NFA.TabIndex = 2;
            groupBoxOutPutData_NFA.TabStop = false;
            groupBoxOutPutData_NFA.Text = "Вывод данных: ";
            // 
            // buttonHelp_NFA
            // 
            buttonHelp_NFA.FlatStyle = FlatStyle.Flat;
            buttonHelp_NFA.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_NFA.Location = new Point(160, 37);
            buttonHelp_NFA.Name = "buttonHelp_NFA";
            buttonHelp_NFA.RightToLeft = RightToLeft.No;
            buttonHelp_NFA.Size = new Size(25, 23);
            buttonHelp_NFA.TabIndex = 2;
            buttonHelp_NFA.Text = "?";
            buttonHelp_NFA.UseVisualStyleBackColor = true;
            buttonHelp_NFA.Click += buttonHelp_NFA_Click_1;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.Location = new Point(21, 137);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(164, 23);
            buttonDone_NFA.TabIndex = 1;
            buttonDone_NFA.Text = "Выполнить";
            buttonDone_NFA.UseVisualStyleBackColor = true;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            // 
            // textBoxResoult_NFA
            // 
            textBoxResoult_NFA.Location = new Point(6, 37);
            textBoxResoult_NFA.Name = "textBoxResoult_NFA";
            textBoxResoult_NFA.ReadOnly = true;
            textBoxResoult_NFA.Size = new Size(100, 23);
            textBoxResoult_NFA.TabIndex = 0;
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
            // pictureBoxFormula_NFA
            // 
            pictureBoxFormula_NFA.Image = Properties.Resources.Снимок_экрана_2024_12_05_150358;
            pictureBoxFormula_NFA.Location = new Point(406, 32);
            pictureBoxFormula_NFA.Name = "pictureBoxFormula_NFA";
            pictureBoxFormula_NFA.Size = new Size(364, 37);
            pictureBoxFormula_NFA.TabIndex = 1;
            pictureBoxFormula_NFA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPutData_NFA);
            Controls.Add(groupBoxInputData_NFA);
            Controls.Add(groupBoxCondition_NFA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Никифоров Ф. А.";
            Load += FormMain_Load;
            groupBoxCondition_NFA.ResumeLayout(false);
            groupBoxInputData_NFA.ResumeLayout(false);
            groupBoxInputData_NFA.PerformLayout();
            groupBoxOutPutData_NFA.ResumeLayout(false);
            groupBoxOutPutData_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private GroupBox groupBoxInputData_NFA;
        private GroupBox groupBoxOutPutData_NFA;
        private Label labelInputData_NFA;
        private Button buttonDone_NFA;
        private TextBox textBoxResoult_NFA;
        private Label labelResoult_NFA;
        private Button buttonHelp_NFA;
        private PictureBox pictureBoxFormula_NFA;
    }
}
