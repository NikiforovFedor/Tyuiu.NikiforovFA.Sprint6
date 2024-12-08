using Tyuiu.NikiforovFA.Sprint6.Task5.V5.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V5.txt";
        private void buttonDone_NFA_Click_1(object sender, EventArgs e)
        {
            dataGridViewOutput_NFA.Rows.Clear();

            double[] res = ds.LoadFromDataFile(path);

            dataGridViewOutput_NFA.ColumnCount = 2;
            dataGridViewOutput_NFA.Columns[0].Width = 20;
            dataGridViewOutput_NFA.Columns[1].Width = 50;

            

            this.chartDiarramm_NFA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiarramm_NFA.ChartAreas[0].AxisY.Title = "Ось Y";


            for (int i = 0; i < res.Length; i++)
            {
                dataGridViewOutput_NFA.Rows.Add(Convert.ToString(i), Convert.ToString(res[i]));
                chartDiarramm_NFA.Series[0].Points.AddXY(i, res[i]);
            }
        }
        private void buttonHelp_NFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент ПКТб-24-1 Никифоров Ф. А.");

        }
        private void buttonOpenFile_NFA_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
