using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.OzdoevaLM.Sprint6.Task3.V4.Lib;

namespace Tyuiu.OzdoevaLM.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[,] matrix = {
            { -14, -7, 18, 12, -20 },
            { -2, -15, -19, -19, -3 },
            { -18, -5, -10, 14, -17 },
            { -1, 2, -10, 0, 11 },
            { 6, -18, 0, 19, 16 }
        };
        byte size = 5;

        DataService ds = new DataService();

        private void buttonResult_OLM_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(matrix);
            DisplayMatrix(resultMatrix, dataGridViewIf_OLM);
        }

        private void buttonHelp_OLM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Оздоева Л. М., задание: Спринт 6, Таск 3, Вариант 4", "Справка", MessageBoxButtons.OK);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupDataGridView(dataGridViewIf_OLM);
            DisplayMatrix(matrix, dataGridViewIf_OLM);
        }

        private void DisplayMatrix(int[,] matrix, DataGridView dgv)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void SetupDataGridView(DataGridView dgv)
        {
            dgv.ColumnCount = size;
            dgv.RowCount = size;
            dgv.AllowUserToAddRows = false;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;

            foreach (DataGridViewColumn column in dgv.Columns) { column.Width = 40; }
            foreach (DataGridViewRow row in dgv.Rows) { row.Height = 30; }
        }

    }
}