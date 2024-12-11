using Tyuiu.NikiforovFA.Sprint6.Task6.V27.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_NFA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NFA.ShowDialog();
            openFilePath = openFileDialogTask_NFA.FileName;
            textBoxInput_NFA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_NFA.Text = groupBoxInput_NFA.Text + " " + openFileDialogTask_NFA.FileName;
            buttonDone_NFA.Enabled = true;
        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            textBoxOutput_NFA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_NFA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
