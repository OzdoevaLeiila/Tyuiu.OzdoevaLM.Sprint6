using System;
using System.Windows.Forms;
using Tyuiu.OzdoevaLM.Sprint6.Task1.V9.Lib;

namespace Tyuiu.OzdoevaLM.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_OLM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПБ-24-2 Оздоева Л. М.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_OLM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_OLM.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_OLM.Text);

                if (startStep > stopStep)
                {
                    MessageBox.Show("Старт не может быть больше конца!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_OLM.Text = "";
                textBoxResult_OLM.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_OLM.AppendText("|    X     |   F(X)   |" + Environment.NewLine);
                textBoxResult_OLM.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    string strLine = String.Format("| {0,5:d}    |  {1,6:f2}  |", startStep, array[i]);
                    textBoxResult_OLM.AppendText(strLine + Environment.NewLine);
                    textBoxResult_OLM.AppendText("+----------+----------+" + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStart_OLM_TextChanged(object sender, EventArgs e)
        {
            // Пустой метод, можно удалить
        }

        private void labelStart_OLM_Click(object sender, EventArgs e)
        {
            // Пустой метод, можно удалить
        }
    }
}