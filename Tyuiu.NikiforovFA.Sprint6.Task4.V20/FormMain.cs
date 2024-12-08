using Tyuiu.NikiforovFA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task4.V20
{
    public partial class FormMain_NFA : Form
    {
        public FormMain_NFA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBoxCondition_NFA_Enter(object sender, EventArgs e)
        {

        }

        private void panelCondition_NFA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChart_NFA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxOutput_NFA_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_NFA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_NFA.Text);

                double[] res = new double[stopStep - startStep + 1];
                res = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_NFA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_NFA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_NFA.Clear();

                chartFunction_NFA.Series[0].Points.Clear();
                for (int i = 0; i < res.Length; i++)
                {
                    this.chartFunction_NFA.Series[0].Points.AddXY(startStep, res[i]);
                    textBoxOutput_NFA.AppendText(res[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ПКТб-24-1 Никифоров Ф. А.");
        }

        private void buttonSave_NFA_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("OutPutFileTask4.txt");
                string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4.txt" });
                File.WriteAllText(s, textBoxOutput_NFA.Text);
                DialogResult dresoult = MessageBox.Show("Файл " + s + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dresoult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = s;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
