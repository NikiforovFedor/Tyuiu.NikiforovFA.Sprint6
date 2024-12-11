namespace Tyuiu.NikiforovFA.Sprint6.Task6.V27
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_NFA = new Panel();
            buttonAbout_NFA = new Button();
            buttonDone_NFA = new Button();
            buttonOpenFile_NFA = new Button();
            panelCondition_NFA = new Panel();
            groupBoxCondition_NFA = new GroupBox();
            labelCondition_NFA = new Label();
            splitContainerInputOutput_NFA = new SplitContainer();
            groupBoxInput_NFA = new GroupBox();
            textBoxInput_NFA = new TextBox();
            groupBoxOutput_NFA = new GroupBox();
            textBoxOutput_NFA = new TextBox();
            openFileDialogTask_NFA = new OpenFileDialog();
            toolTip1_NFA = new ToolTip(components);
            panelButtons_NFA.SuspendLayout();
            panelCondition_NFA.SuspendLayout();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_NFA).BeginInit();
            splitContainerInputOutput_NFA.Panel1.SuspendLayout();
            splitContainerInputOutput_NFA.Panel2.SuspendLayout();
            splitContainerInputOutput_NFA.SuspendLayout();
            groupBoxInput_NFA.SuspendLayout();
            groupBoxOutput_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_NFA
            // 
            panelButtons_NFA.Controls.Add(buttonAbout_NFA);
            panelButtons_NFA.Controls.Add(buttonDone_NFA);
            panelButtons_NFA.Controls.Add(buttonOpenFile_NFA);
            panelButtons_NFA.Dock = DockStyle.Top;
            panelButtons_NFA.Location = new Point(0, 0);
            panelButtons_NFA.Name = "panelButtons_NFA";
            panelButtons_NFA.Size = new Size(800, 62);
            panelButtons_NFA.TabIndex = 0;
            // 
            // buttonAbout_NFA
            // 
            buttonAbout_NFA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_NFA.Image = Properties.Resources.Help;
            buttonAbout_NFA.Location = new Point(738, 3);
            buttonAbout_NFA.Name = "buttonAbout_NFA";
            buttonAbout_NFA.Size = new Size(50, 50);
            buttonAbout_NFA.TabIndex = 1;
            buttonAbout_NFA.UseVisualStyleBackColor = true;
            buttonAbout_NFA.Click += buttonAbout_NFA_Click;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.Enabled = false;
            buttonDone_NFA.Image = Properties.Resources.Done;
            buttonDone_NFA.Location = new Point(83, 3);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(50, 50);
            buttonDone_NFA.TabIndex = 0;
            toolTip1_NFA.SetToolTip(buttonDone_NFA, "Запустить выполнение программы");
            buttonDone_NFA.UseVisualStyleBackColor = true;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            // 
            // buttonOpenFile_NFA
            // 
            buttonOpenFile_NFA.Image = Properties.Resources.Download2;
            buttonOpenFile_NFA.Location = new Point(12, 3);
            buttonOpenFile_NFA.Name = "buttonOpenFile_NFA";
            buttonOpenFile_NFA.Size = new Size(50, 50);
            buttonOpenFile_NFA.TabIndex = 0;
            toolTip1_NFA.SetToolTip(buttonOpenFile_NFA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_NFA.UseVisualStyleBackColor = true;
            buttonOpenFile_NFA.Click += buttonOpenFile_NFA_Click;
            // 
            // panelCondition_NFA
            // 
            panelCondition_NFA.Controls.Add(groupBoxCondition_NFA);
            panelCondition_NFA.Dock = DockStyle.Top;
            panelCondition_NFA.Location = new Point(0, 62);
            panelCondition_NFA.Name = "panelCondition_NFA";
            panelCondition_NFA.Size = new Size(800, 66);
            panelCondition_NFA.TabIndex = 1;
            // 
            // groupBoxCondition_NFA
            // 
            groupBoxCondition_NFA.Controls.Add(labelCondition_NFA);
            groupBoxCondition_NFA.Dock = DockStyle.Fill;
            groupBoxCondition_NFA.Location = new Point(0, 0);
            groupBoxCondition_NFA.Name = "groupBoxCondition_NFA";
            groupBoxCondition_NFA.Size = new Size(800, 66);
            groupBoxCondition_NFA.TabIndex = 0;
            groupBoxCondition_NFA.TabStop = false;
            groupBoxCondition_NFA.Text = "Условие";
            // 
            // labelCondition_NFA
            // 
            labelCondition_NFA.Dock = DockStyle.Fill;
            labelCondition_NFA.Location = new Point(3, 19);
            labelCondition_NFA.Name = "labelCondition_NFA";
            labelCondition_NFA.Size = new Size(794, 44);
            labelCondition_NFA.TabIndex = 0;
            labelCondition_NFA.Text = resources.GetString("labelCondition_NFA.Text");
            // 
            // splitContainerInputOutput_NFA
            // 
            splitContainerInputOutput_NFA.Dock = DockStyle.Fill;
            splitContainerInputOutput_NFA.Location = new Point(0, 128);
            splitContainerInputOutput_NFA.Name = "splitContainerInputOutput_NFA";
            // 
            // splitContainerInputOutput_NFA.Panel1
            // 
            splitContainerInputOutput_NFA.Panel1.Controls.Add(groupBoxInput_NFA);
            splitContainerInputOutput_NFA.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainerInputOutput_NFA.Panel2
            // 
            splitContainerInputOutput_NFA.Panel2.Controls.Add(groupBoxOutput_NFA);
            splitContainerInputOutput_NFA.Size = new Size(800, 322);
            splitContainerInputOutput_NFA.SplitterDistance = 362;
            splitContainerInputOutput_NFA.TabIndex = 2;
            // 
            // groupBoxInput_NFA
            // 
            groupBoxInput_NFA.Controls.Add(textBoxInput_NFA);
            groupBoxInput_NFA.Dock = DockStyle.Fill;
            groupBoxInput_NFA.Location = new Point(0, 0);
            groupBoxInput_NFA.Name = "groupBoxInput_NFA";
            groupBoxInput_NFA.Size = new Size(362, 322);
            groupBoxInput_NFA.TabIndex = 0;
            groupBoxInput_NFA.TabStop = false;
            groupBoxInput_NFA.Text = "Ввод ";
            // 
            // textBoxInput_NFA
            // 
            textBoxInput_NFA.Dock = DockStyle.Fill;
            textBoxInput_NFA.Location = new Point(3, 19);
            textBoxInput_NFA.Multiline = true;
            textBoxInput_NFA.Name = "textBoxInput_NFA";
            textBoxInput_NFA.ReadOnly = true;
            textBoxInput_NFA.Size = new Size(356, 300);
            textBoxInput_NFA.TabIndex = 0;
            // 
            // groupBoxOutput_NFA
            // 
            groupBoxOutput_NFA.Controls.Add(textBoxOutput_NFA);
            groupBoxOutput_NFA.Dock = DockStyle.Fill;
            groupBoxOutput_NFA.Location = new Point(0, 0);
            groupBoxOutput_NFA.Name = "groupBoxOutput_NFA";
            groupBoxOutput_NFA.Size = new Size(434, 322);
            groupBoxOutput_NFA.TabIndex = 0;
            groupBoxOutput_NFA.TabStop = false;
            groupBoxOutput_NFA.Text = "Вывод";
            // 
            // textBoxOutput_NFA
            // 
            textBoxOutput_NFA.Dock = DockStyle.Fill;
            textBoxOutput_NFA.Location = new Point(3, 19);
            textBoxOutput_NFA.Multiline = true;
            textBoxOutput_NFA.Name = "textBoxOutput_NFA";
            textBoxOutput_NFA.ReadOnly = true;
            textBoxOutput_NFA.Size = new Size(428, 300);
            textBoxOutput_NFA.TabIndex = 0;
            // 
            // openFileDialogTask_NFA
            // 
            openFileDialogTask_NFA.FileName = "InPutDataFileTask6V27";
            openFileDialogTask_NFA.InitialDirectory = "C:\\DataSprint6\\InPutDataFileTask6V27";
            // 
            // toolTip1_NFA
            // 
            toolTip1_NFA.ToolTipIcon = ToolTipIcon.Info;
            toolTip1_NFA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainerInputOutput_NFA);
            Controls.Add(panelCondition_NFA);
            Controls.Add(panelButtons_NFA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 27 | Никифоров Ф. А.";
            panelButtons_NFA.ResumeLayout(false);
            panelCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.ResumeLayout(false);
            splitContainerInputOutput_NFA.Panel1.ResumeLayout(false);
            splitContainerInputOutput_NFA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_NFA).EndInit();
            splitContainerInputOutput_NFA.ResumeLayout(false);
            groupBoxInput_NFA.ResumeLayout(false);
            groupBoxInput_NFA.PerformLayout();
            groupBoxOutput_NFA.ResumeLayout(false);
            groupBoxOutput_NFA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_NFA;
        private Panel panelCondition_NFA;
        private Button button2;
        private Button buttonOpenFile_NFA;
        private SplitContainer splitContainerInputOutput_NFA;
        private GroupBox groupBoxCondition_NFA;
        private Label labelCondition_NFA;
        private GroupBox groupBoxInput_NFA;
        private TextBox textBoxInput_NFA;
        private GroupBox groupBoxOutput_NFA;
        private TextBox textBoxOutput_NFA;
        private Button buttonDone_NFA;
        private ToolTip toolTip1_NFA;
        private OpenFileDialog openFileDialogTask_NFA;
        private Button buttonAbout_NFA;
    }
}
