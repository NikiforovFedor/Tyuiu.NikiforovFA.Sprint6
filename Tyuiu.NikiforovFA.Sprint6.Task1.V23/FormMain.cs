using Tyuiu.NikiforovFA.Sprint6.Task1.V23.Lib;
using System.Text;
namespace Tyuiu.NikiforovFA.Sprint6.Task1.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxStartStep_NFA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_NFA.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_NFA.Text);

                string str;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] res = ds.GetMassFunction(startStep, stopStep);
                textBoxResoult_NFA.Text = "";
                textBoxResoult_NFA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResoult_NFA.AppendText("|      x    |      y    |" + Environment.NewLine);
                textBoxResoult_NFA.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,7:d}    | {1, 9:f2} |", startStep, res[i]);
                    textBoxResoult_NFA.AppendText(str + Environment.NewLine);
                    startStep++;
                }
                textBoxResoult_NFA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент ПКТб-24-1 Никифоров Ф. А.");
        }
    }
}
