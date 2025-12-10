using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.OzdoevaLM.Sprint6.Task6.V4.Lib;

namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpenFile_OLM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_OLM.ShowDialog();
            openFilePath = openFileDialogTask_OLM.FileName;
            textBoxIn_OLM.Text = File.ReadAllText(openFilePath);
            buttonDo_OLM.Enabled = true;
        }

        private void buttonDo_OLM_Click(object sender, EventArgs e)
        {
            textBoxOut_OLM.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_OLM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Оздоева Л. М., задание: Спринт 6, Таск 6, Вариант 4", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonDo_OLM.Enabled = false;
            openFileDialogTask_OLM.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.Text = "Спринт 6 | Таск 6 | Вариант 4 | Оздоева Л. М.";
        }
    }
}