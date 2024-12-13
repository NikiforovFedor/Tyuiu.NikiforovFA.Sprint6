namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14
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
            buttonSave_NFA = new Button();
            buttonAbout_NFA = new Button();
            buttonDone_NFA = new Button();
            buttonOpenFile_NFA = new Button();
            panelCondition_NFA = new Panel();
            groupBoxCondition_NFA = new GroupBox();
            labelCondition_NFA = new Label();
            splitContainerInputOutput_NFA = new SplitContainer();
            groupBoxInput_NFA = new GroupBox();
            dataGridViewInput_NFA = new DataGridView();
            groupBoxOutput_NFA = new GroupBox();
            dataGridViewOutput_NFA = new DataGridView();
            openFileDialogTask_NFA = new OpenFileDialog();
            toolTip1_NFA = new ToolTip(components);
            saveFileDialog_NFA = new SaveFileDialog();
            panelButtons_NFA.SuspendLayout();
            panelCondition_NFA.SuspendLayout();
            groupBoxCondition_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_NFA).BeginInit();
            splitContainerInputOutput_NFA.Panel1.SuspendLayout();
            splitContainerInputOutput_NFA.Panel2.SuspendLayout();
            splitContainerInputOutput_NFA.SuspendLayout();
            groupBoxInput_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_NFA).BeginInit();
            groupBoxOutput_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_NFA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_NFA
            // 
            panelButtons_NFA.Controls.Add(buttonSave_NFA);
            panelButtons_NFA.Controls.Add(buttonAbout_NFA);
            panelButtons_NFA.Controls.Add(buttonDone_NFA);
            panelButtons_NFA.Controls.Add(buttonOpenFile_NFA);
            panelButtons_NFA.Dock = DockStyle.Top;
            panelButtons_NFA.Location = new Point(0, 0);
            panelButtons_NFA.Name = "panelButtons_NFA";
            panelButtons_NFA.Size = new Size(800, 62);
            panelButtons_NFA.TabIndex = 0;
            // 
            // buttonSave_NFA
            // 
            buttonSave_NFA.Enabled = false;
            buttonSave_NFA.FlatStyle = FlatStyle.Flat;
            buttonSave_NFA.Image = (Image)resources.GetObject("buttonSave_NFA.Image");
            buttonSave_NFA.Location = new Point(154, 3);
            buttonSave_NFA.Name = "buttonSave_NFA";
            buttonSave_NFA.Size = new Size(50, 50);
            buttonSave_NFA.TabIndex = 2;
            toolTip1_NFA.SetToolTip(buttonSave_NFA, "Сохранить в файл\r\nСохранить обработанные данные в файл CSV");
            buttonSave_NFA.UseVisualStyleBackColor = true;
            buttonSave_NFA.Click += button1_Click;
            buttonSave_NFA.MouseEnter += buttonSave_NFA_MouseEnter;
            // 
            // buttonAbout_NFA
            // 
            buttonAbout_NFA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_NFA.FlatStyle = FlatStyle.Flat;
            buttonAbout_NFA.Image = Properties.Resources.Help;
            buttonAbout_NFA.Location = new Point(738, 3);
            buttonAbout_NFA.Name = "buttonAbout_NFA";
            buttonAbout_NFA.Size = new Size(50, 50);
            buttonAbout_NFA.TabIndex = 1;
            toolTip1_NFA.SetToolTip(buttonAbout_NFA, "Справка\r\nСведения о программе");
            buttonAbout_NFA.UseVisualStyleBackColor = true;
            buttonAbout_NFA.Click += buttonAbout_NFA_Click;
            buttonAbout_NFA.MouseEnter += buttonAbout_NFA_MouseEnter;
            // 
            // buttonDone_NFA
            // 
            buttonDone_NFA.Enabled = false;
            buttonDone_NFA.FlatStyle = FlatStyle.Flat;
            buttonDone_NFA.Image = Properties.Resources.Done;
            buttonDone_NFA.Location = new Point(83, 3);
            buttonDone_NFA.Name = "buttonDone_NFA";
            buttonDone_NFA.Size = new Size(50, 50);
            buttonDone_NFA.TabIndex = 0;
            toolTip1_NFA.SetToolTip(buttonDone_NFA, "Запустить выполнение программы");
            buttonDone_NFA.UseVisualStyleBackColor = true;
            buttonDone_NFA.Click += buttonDone_NFA_Click;
            buttonDone_NFA.MouseEnter += buttonDone_NFA_MouseEnter;
            // 
            // buttonOpenFile_NFA
            // 
            buttonOpenFile_NFA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_NFA.Image = Properties.Resources.Download2;
            buttonOpenFile_NFA.Location = new Point(12, 3);
            buttonOpenFile_NFA.Name = "buttonOpenFile_NFA";
            buttonOpenFile_NFA.Size = new Size(50, 50);
            buttonOpenFile_NFA.TabIndex = 0;
            toolTip1_NFA.SetToolTip(buttonOpenFile_NFA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_NFA.UseVisualStyleBackColor = true;
            buttonOpenFile_NFA.Click += buttonOpenFile_NFA_Click;
            buttonOpenFile_NFA.MouseEnter += buttonOpenFile_NFA_MouseEnter;
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
            groupBoxInput_NFA.Controls.Add(dataGridViewInput_NFA);
            groupBoxInput_NFA.Dock = DockStyle.Fill;
            groupBoxInput_NFA.Location = new Point(0, 0);
            groupBoxInput_NFA.Name = "groupBoxInput_NFA";
            groupBoxInput_NFA.Size = new Size(362, 322);
            groupBoxInput_NFA.TabIndex = 0;
            groupBoxInput_NFA.TabStop = false;
            groupBoxInput_NFA.Text = "Ввод ";
            // 
            // dataGridViewInput_NFA
            // 
            dataGridViewInput_NFA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInput_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_NFA.ColumnHeadersVisible = false;
            dataGridViewInput_NFA.Dock = DockStyle.Fill;
            dataGridViewInput_NFA.Location = new Point(3, 19);
            dataGridViewInput_NFA.Name = "dataGridViewInput_NFA";
            dataGridViewInput_NFA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInput_NFA.RowHeadersVisible = false;
            dataGridViewInput_NFA.Size = new Size(356, 300);
            dataGridViewInput_NFA.TabIndex = 0;
            // 
            // groupBoxOutput_NFA
            // 
            groupBoxOutput_NFA.Controls.Add(dataGridViewOutput_NFA);
            groupBoxOutput_NFA.Dock = DockStyle.Fill;
            groupBoxOutput_NFA.Location = new Point(0, 0);
            groupBoxOutput_NFA.Name = "groupBoxOutput_NFA";
            groupBoxOutput_NFA.Size = new Size(434, 322);
            groupBoxOutput_NFA.TabIndex = 0;
            groupBoxOutput_NFA.TabStop = false;
            groupBoxOutput_NFA.Text = "Вывод";
            // 
            // dataGridViewOutput_NFA
            // 
            dataGridViewOutput_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_NFA.ColumnHeadersVisible = false;
            dataGridViewOutput_NFA.Dock = DockStyle.Fill;
            dataGridViewOutput_NFA.Location = new Point(3, 19);
            dataGridViewOutput_NFA.Name = "dataGridViewOutput_NFA";
            dataGridViewOutput_NFA.RowHeadersVisible = false;
            dataGridViewOutput_NFA.Size = new Size(428, 300);
            dataGridViewOutput_NFA.TabIndex = 0;
            // 
            // openFileDialogTask_NFA
            // 
            openFileDialogTask_NFA.FileName = "InPutDataFileTask7V14";
            openFileDialogTask_NFA.InitialDirectory = "C:\\DataSprint6\\InPutDataFileTask6V27";
            // 
            // toolTip1_NFA
            // 
            toolTip1_NFA.IsBalloon = true;
            toolTip1_NFA.ToolTipIcon = ToolTipIcon.Info;
            toolTip1_NFA.ToolTipTitle = "Подсказка";
            toolTip1_NFA.Popup += toolTip1_NFA_Popup;
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
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Никифоров Ф. А.";
            WindowState = FormWindowState.Maximized;
            panelButtons_NFA.ResumeLayout(false);
            panelCondition_NFA.ResumeLayout(false);
            groupBoxCondition_NFA.ResumeLayout(false);
            splitContainerInputOutput_NFA.Panel1.ResumeLayout(false);
            splitContainerInputOutput_NFA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInputOutput_NFA).EndInit();
            splitContainerInputOutput_NFA.ResumeLayout(false);
            groupBoxInput_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_NFA).EndInit();
            groupBoxOutput_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_NFA).EndInit();
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
        private GroupBox groupBoxOutput_NFA;
        private Button buttonDone_NFA;
        private ToolTip toolTip1_NFA;
        private OpenFileDialog openFileDialogTask_NFA;
        private Button buttonAbout_NFA;
        private DataGridView dataGridViewInput_NFA;
        private DataGridView dataGridViewOutput_NFA;
        private Button buttonSave_NFA;
        private SaveFileDialog saveFileDialog_NFA;
    }
}
