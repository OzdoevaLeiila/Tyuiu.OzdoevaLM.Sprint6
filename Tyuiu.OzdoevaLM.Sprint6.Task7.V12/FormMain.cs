using System;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.OzdoevaLM.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private int rows;
        private int cols;
        private string path;
        private int[,] matrix;

        private void buttonHelp_OLM_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonFail_OLM_Click(object sender, EventArgs e)
        {
            openFileDialogqw_OLM.FileName = "";
            openFileDialogqw_OLM.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialogqw_OLM.Title = "Выберите файл";

            if (openFileDialogqw_OLM.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialogqw_OLM.FileName;

                try
                {
                    // Читаем файл
                    string[] lines = File.ReadAllLines(path);

                    // Убираем пустые строки
                    rows = 0;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(lines[i]))
                        {
                            rows++;
                        }
                    }

                    // Создаем новый массив без пустых строк
                    string[] validLines = new string[rows];
                    int index = 0;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(lines[i]))
                        {
                            validLines[index] = lines[i];
                            index++;
                        }
                    }

                    // Определяем максимальное количество столбцов
                    cols = 0;
                    foreach (string line in validLines)
                    {
                        string[] values = line.Split(';');
                        if (values.Length > cols)
                        {
                            cols = values.Length;
                        }
                    }

                    // Создаем матрицу
                    matrix = new int[rows, cols];

                    // Заполняем dataGridView1
                    dataGridView1.RowCount = rows;
                    dataGridView1.ColumnCount = cols;
                    dataGridView2.RowCount = rows;
                    dataGridView2.ColumnCount = cols;

                    // Настраиваем ширину столбцов
                    for (int i = 0; i < cols; i++)
                    {
                        dataGridView1.Columns[i].Width = 50;
                        dataGridView2.Columns[i].Width = 50;
                    }

                    // Заполняем матрицу и DataGridView
                    for (int r = 0; r < rows; r++)
                    {
                        string[] values = validLines[r].Split(';');

                        for (int c = 0; c < cols; c++)
                        {
                            int value = 0;

                            // Если в строке есть значение для этого столбца
                            if (c < values.Length && !string.IsNullOrWhiteSpace(values[c]))
                            {
                                string strValue = values[c].Trim();
                                if (int.TryParse(strValue, out int parsedValue))
                                {
                                    value = parsedValue;
                                }
                            }

                            matrix[r, c] = value;
                            dataGridView1.Rows[r].Cells[c].Value = value;
                        }
                    }

                    buttonsave_OLM.Enabled = true;
                    buttonwe_OLM.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла:\n{ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonsave_OLM_Click(object sender, EventArgs e)
        {
            if (matrix == null) return;

            try
            {
                // Обработка: в 9-м столбце (индекс 8) значения != 10 заменяем на 0
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        int value = matrix[r, c];

                        // Если это 9-й столбец (индекс 8) и значение не равно 10
                        if (c == 8 && value != 10)
                        {
                            dataGridView2.Rows[r].Cells[c].Value = 0;
                        }
                        else
                        {
                            dataGridView2.Rows[r].Cells[c].Value = value;
                        }
                    }
                }

                buttonwe_OLM.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке данных:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonwe_OLM_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_OLM.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_OLM.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogTask_OLM.Title = "Сохранить результат";

            if (saveFileDialogTask_OLM.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialogTask_OLM.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(savePath, false))
                    {
                        for (int r = 0; r < rows; r++)
                        {
                            string line = "";
                            for (int c = 0; c < cols; c++)
                            {
                                object cellValue = dataGridView2.Rows[r].Cells[c].Value;
                                line += (cellValue != null ? cellValue.ToString() : "0");

                                if (c < cols - 1)
                                {
                                    line += ";";
                                }
                            }
                            writer.WriteLine(line);
                        }
                    }

                    MessageBox.Show($"Файл успешно сохранен:\n{savePath}", "Сохранение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}