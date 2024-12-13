using Tyuiu.NikiforovFA.Sprint6.Task7.V14.Lib;

namespace Tyuiu.NikiforovFA.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        static int columns;
        static int rows;
        public static int[,] ReadFile(string path)
        {
            string FileData = File.ReadAllText(path);
            FileData = FileData.Replace('\n', '\r');

            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return array;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_NFA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NFA.ShowDialog();
            openFilePath = openFileDialogTask_NFA.FileName;
            int[,] array = new int[rows, columns];

            array = ReadFile(openFilePath);

            dataGridViewInput_NFA.RowCount = rows;
            dataGridViewInput_NFA.ColumnCount = columns;
            dataGridViewOutput_NFA.RowCount = rows;
            dataGridViewOutput_NFA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_NFA.Columns[i].Width = 25;
                dataGridViewOutput_NFA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_NFA.Rows[i].Cells[j].Value = array[i, j];
                }
            }
            array = ds.GetMatrix(ReadFile(openFilePath));
            buttonDone_NFA.Enabled = true;
        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            int[,] res = new int[rows, columns];
            res = ds.GetMatrix(ReadFile(openFilePath));
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_NFA.Rows[i].Cells[j].Value = res[i, j];
                }
            }
            buttonSave_NFA.Enabled = true;
        }

        private void buttonAbout_NFA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog_NFA.FileName = "OutputTask7.csv";
            saveFileDialog_NFA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_NFA.ShowDialog();

            string path = saveFileDialog_NFA.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            if (fileexists)
            {
                fileinfo.Delete();
            }
            int rows = dataGridViewOutput_NFA.RowCount;
            int columns = dataGridViewOutput_NFA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != (columns - 1))
                    {
                        str += dataGridViewOutput_NFA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_NFA.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_NFA.ToolTipTitle = "Открыть файл";
        }

        private void toolTip1_NFA_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_NFA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_NFA.ToolTipTitle = "Сохранить";
        }

        private void buttonAbout_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1_NFA.ToolTipTitle = "Справка";
        }
    }
}
