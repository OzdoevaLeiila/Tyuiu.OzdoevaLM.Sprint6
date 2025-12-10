using Tyuiu.OzdoevaLM.Sprint6.Task2.V4.Lib;

namespace Tyuiu.OzdoevaLM.Sprint6.Task2.V4
{
    public partial class FormMain_OLM : Form
    {
        public FormMain_OLM()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataService ds = new DataService();

        private void buttonResult_OLM_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVod_OLM.Text);
                int stop = Convert.ToInt32(textBoxVod1_OLM.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                this.chart1.Titles.Add("График функции");
                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                    this.chart1.Series[0].Points.AddXY(start, value[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_OLM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИБ-25-1 Оздоева Лейла Магомедовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxIf_OLM_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_OLM_Click_1(object sender, EventArgs e)
        {

        }
    }
}