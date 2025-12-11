
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4

{
    public partial class Form1 : Form
    {
        // Константа с путем к файлу для тестирования
        private const string TestFilePath = @"C:\DataSprint6\InPutDataFileTask6V4.txt";

        public Form1()
        {
            InitializeComponent();

            // При загрузке формы проверяем существование тестового файла
            LoadTestFileOnStartup();
        }

        private void LoadTestFileOnStartup()
        {
            try
            {
                // Проверяем существование тестового файла
                if (File.Exists(TestFilePath))
                {
                    // Автоматически загружаем тестовый файл при запуске
                    string fileContent = File.ReadAllText(TestFilePath, Encoding.UTF8);
                    textBoxIn.Text = fileContent;

                    // Обработка текста
                    string result = FindWordsWithLetterN(fileContent);
                    textBoxOut.Text = result;

                    // Показываем сообщение об успешной загрузке
                    toolStripStatusLabel.Text = $"Загружен тестовый файл: {TestFilePath}";
                }
                else
                {
                    toolStripStatusLabel.Text = "Тестовый файл не найден. Используйте кнопку 'Загрузить файл'";
                    MessageBox.Show($"Тестовый файл не найден по пути:\n{TestFilePath}\n\nИспользуйте кнопку 'Загрузить файл' для выбора файла вручную.",
                        "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке тестового файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите текстовый файл";

            // Начинаем с директории тестового файла, если он существует
            if (File.Exists(TestFilePath))
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(TestFilePath);
                openFileDialog.FileName = Path.GetFileName(TestFilePath);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загрузить содержимое файла в textBoxIn
                    string fileContent = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                    textBoxIn.Text = fileContent;

                    // Обработать текст: найти слова с буквой 'n'
                    string result = FindWordsWithLetterN(fileContent);
                    textBoxOut.Text = result;

                    toolStripStatusLabel.Text = $"Загружен файл: {openFileDialog.FileName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FindWordsWithLetterN(string text)
        {
            // Разделяем текст на слова, игнорируя пробелы и переносы строк
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);
            List<string> wordsWithN = new List<string>();

            foreach (string word in words)
            {
                // Проверяем, содержит ли слово букву 'n' (регистронезависимо)
                if (word.IndexOf('n', StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    wordsWithN.Add(word);
                }
            }

            // Формируем результирующую строку
            return string.Join(" ", wordsWithN);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // Кнопка для повторной загрузки тестового файла
            LoadTestFileOnStartup();
        }
    }
}