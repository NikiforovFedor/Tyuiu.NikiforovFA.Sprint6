using Tyuiu.NikiforovFA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix =  { { 4, 32, -20, 27, 21 },
                            { 17,15,-1,-2,-1},
                            {-3,18,12,-10,29},
                            { 7,-15,2,-8,12 },
                            { -10,25,5,27,21} };
        private void FormLoad(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrix_NFA.RowCount = rows;
            dataGridViewMatrix_NFA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_NFA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_NFA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void labelCondition_NFA_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_NFA_Click(object sender, EventArgs e)
        {
            int[,] res = new int[5, 5];
            res = ds.Calculate(matrix);

            string matrixString = "";


            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++) 
                {
                    matrixString += res[i, j] + " ";
                }
                matrixString += Environment.NewLine; 
            }
            textBoxResoult_NFA.Text = matrixString;
        }

        private void buttonHelp_NFA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент ПКТб-24-1 Никифоров Ф. А.");
        }
    }
}

