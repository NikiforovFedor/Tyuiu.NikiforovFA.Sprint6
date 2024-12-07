using Tyuiu.NikiforovFA.Sprint6.Task2.V16.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_NFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент ПКТб-24-1 Никифоров Ф. А.");
        }

        private void buttonDone_NFA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_NFA.BackColor = Color.Azure;
        }
        private void buttonDone_NFA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_NFA.BackColor = Color.Green;
        }
        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartStep_NFA.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep_NFA.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] res = new double[len];

                res = ds.GetMassFunction(StartStep, StopStep);

                this.chartFunction_NFA.Titles.Add("График функции");
                this.chartFunction_NFA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_NFA.ChartAreas[0].AxisY.Title= "Ось Y";

                for (int i = 0; i <= len; i++)
                {
                    this.dataGridViewFunction_NFA.Rows.Add(Convert.ToString(StartStep), Convert.ToString(res[i]));
                    this.chartFunction_NFA.Series[0].Points.AddXY(StartStep, res[i]);
                    StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}