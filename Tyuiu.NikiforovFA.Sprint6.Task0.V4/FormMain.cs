using Tyuiu.NikiforovFA.Sprint6.Task0.V4.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResoult_NFA.Text = Convert.ToString(ds.Calculate(3));
            }
            catch { }
        }

        private void buttonHelp_NFA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент ПКТб-24-1 Никифоров Ф. А.");
        }
    }
}
