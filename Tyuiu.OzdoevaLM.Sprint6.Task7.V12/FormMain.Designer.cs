namespace Tyuiu.OzdoevaLM.Sprint6.Task7.V12
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelw_OLM = new Panel();
            buttonHelp_OLM = new Button();
            buttonwe_OLM = new Button();
            buttonsave_OLM = new Button();
            buttonFail_OLM = new Button();
            panelq_OLM = new Panel();
            groupBoxIf_OLM = new GroupBox();
            textBox1 = new TextBox();
            panelr_OLM = new Panel();
            groupBoxVod_OLM = new GroupBox();
            dataGridView1 = new DataGridView();
            panele_OLM = new Panel();
            groupBoxResult_OLM = new GroupBox();
            dataGridView2 = new DataGridView();
            splitterw_OLM = new Splitter();
            openFileDialogqw_OLM = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialogTask_OLM = new SaveFileDialog();
            panelw_OLM.SuspendLayout();
            panelq_OLM.SuspendLayout();
            groupBoxIf_OLM.SuspendLayout();
            panelr_OLM.SuspendLayout();
            groupBoxVod_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panele_OLM.SuspendLayout();
            groupBoxResult_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelw_OLM
            // 
            panelw_OLM.Controls.Add(buttonHelp_OLM);
            panelw_OLM.Controls.Add(buttonwe_OLM);
            panelw_OLM.Controls.Add(buttonsave_OLM);
            panelw_OLM.Controls.Add(buttonFail_OLM);
            panelw_OLM.Dock = DockStyle.Top;
            panelw_OLM.Location = new Point(0, 0);
            panelw_OLM.Name = "panelw_OLM";
            panelw_OLM.Size = new Size(924, 92);
            panelw_OLM.TabIndex = 0;
            // 
            // buttonHelp_OLM
            // 
            buttonHelp_OLM.Image = (Image)resources.GetObject("buttonHelp_OLM.Image");
            buttonHelp_OLM.Location = new Point(818, 12);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(94, 74);
            buttonHelp_OLM.TabIndex = 3;
            toolTip1.SetToolTip(buttonHelp_OLM, "информация об разработчике");
            buttonHelp_OLM.UseVisualStyleBackColor = true;
            buttonHelp_OLM.Click += buttonHelp_OLM_Click;
            // 
            // buttonwe_OLM
            // 
            buttonwe_OLM.Enabled = false;
            buttonwe_OLM.Image = (Image)resources.GetObject("buttonwe_OLM.Image");
            buttonwe_OLM.Location = new Point(228, 12);
            buttonwe_OLM.Name = "buttonwe_OLM";
            buttonwe_OLM.Size = new Size(94, 74);
            buttonwe_OLM.TabIndex = 2;
            toolTip1.SetToolTip(buttonwe_OLM, "сохранить");
            buttonwe_OLM.UseVisualStyleBackColor = true;
            buttonwe_OLM.Click += buttonwe_OLM_Click;
            // 
            // buttonsave_OLM
            // 
            buttonsave_OLM.Enabled = false;
            buttonsave_OLM.Image = (Image)resources.GetObject("buttonsave_OLM.Image");
            buttonsave_OLM.Location = new Point(128, 12);
            buttonsave_OLM.Name = "buttonsave_OLM";
            buttonsave_OLM.Size = new Size(94, 74);
            buttonsave_OLM.TabIndex = 1;
            toolTip1.SetToolTip(buttonsave_OLM, "выполнить");
            buttonsave_OLM.UseVisualStyleBackColor = true;
            buttonsave_OLM.Click += buttonsave_OLM_Click;
            // 
            // buttonFail_OLM
            // 
            buttonFail_OLM.Image = (Image)resources.GetObject("buttonFail_OLM.Image");
            buttonFail_OLM.Location = new Point(12, 12);
            buttonFail_OLM.Name = "buttonFail_OLM";
            buttonFail_OLM.Size = new Size(110, 74);
            buttonFail_OLM.TabIndex = 0;
            toolTip1.SetToolTip(buttonFail_OLM, "Откроейте файл\r\nвыберите нужный файл для обработки\r\n");
            buttonFail_OLM.UseVisualStyleBackColor = true;
            buttonFail_OLM.Click += buttonFail_OLM_Click;
            // 
            // panelq_OLM
            // 
            panelq_OLM.Controls.Add(groupBoxIf_OLM);
            panelq_OLM.Dock = DockStyle.Top;
            panelq_OLM.Location = new Point(0, 92);
            panelq_OLM.Name = "panelq_OLM";
            panelq_OLM.Size = new Size(924, 99);
            panelq_OLM.TabIndex = 1;
            // 
            // groupBoxIf_OLM
            // 
            groupBoxIf_OLM.Controls.Add(textBox1);
            groupBoxIf_OLM.Dock = DockStyle.Fill;
            groupBoxIf_OLM.Location = new Point(0, 0);
            groupBoxIf_OLM.Name = "groupBoxIf_OLM";
            groupBoxIf_OLM.Size = new Size(924, 99);
            groupBoxIf_OLM.TabIndex = 0;
            groupBoxIf_OLM.TabStop = false;
            groupBoxIf_OLM.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(918, 71);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelr_OLM
            // 
            panelr_OLM.Controls.Add(groupBoxVod_OLM);
            panelr_OLM.Dock = DockStyle.Left;
            panelr_OLM.Location = new Point(0, 191);
            panelr_OLM.Name = "panelr_OLM";
            panelr_OLM.Size = new Size(458, 326);
            panelr_OLM.TabIndex = 2;
            // 
            // groupBoxVod_OLM
            // 
            groupBoxVod_OLM.Controls.Add(dataGridView1);
            groupBoxVod_OLM.Dock = DockStyle.Fill;
            groupBoxVod_OLM.Location = new Point(0, 0);
            groupBoxVod_OLM.Name = "groupBoxVod_OLM";
            groupBoxVod_OLM.Size = new Size(458, 326);
            groupBoxVod_OLM.TabIndex = 0;
            groupBoxVod_OLM.TabStop = false;
            groupBoxVod_OLM.Text = "Ввод:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(452, 298);
            dataGridView1.TabIndex = 0;
            // 
            // panele_OLM
            // 
            panele_OLM.Controls.Add(groupBoxResult_OLM);
            panele_OLM.Dock = DockStyle.Fill;
            panele_OLM.Location = new Point(458, 191);
            panele_OLM.Name = "panele_OLM";
            panele_OLM.Size = new Size(466, 326);
            panele_OLM.TabIndex = 3;
            // 
            // groupBoxResult_OLM
            // 
            groupBoxResult_OLM.Controls.Add(dataGridView2);
            groupBoxResult_OLM.Dock = DockStyle.Fill;
            groupBoxResult_OLM.Location = new Point(0, 0);
            groupBoxResult_OLM.Name = "groupBoxResult_OLM";
            groupBoxResult_OLM.Size = new Size(466, 326);
            groupBoxResult_OLM.TabIndex = 0;
            groupBoxResult_OLM.TabStop = false;
            groupBoxResult_OLM.Text = "Вывод:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(460, 298);
            dataGridView2.TabIndex = 0;
            // 
            // splitterw_OLM
            // 
            splitterw_OLM.Location = new Point(458, 191);
            splitterw_OLM.Name = "splitterw_OLM";
            splitterw_OLM.Size = new Size(4, 326);
            splitterw_OLM.TabIndex = 4;
            splitterw_OLM.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialogTask_OLM
            // 
            saveFileDialogTask_OLM.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_OLM.Filter = "CSV files (.csv)|.csv|All files (.)|.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 517);
            Controls.Add(splitterw_OLM);
            Controls.Add(panele_OLM);
            Controls.Add(panelr_OLM);
            Controls.Add(panelq_OLM);
            Controls.Add(panelw_OLM);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Оздоева Л. М.";
            Load += FormMain_Load;
            panelw_OLM.ResumeLayout(false);
            panelq_OLM.ResumeLayout(false);
            groupBoxIf_OLM.ResumeLayout(false);
            groupBoxIf_OLM.PerformLayout();
            panelr_OLM.ResumeLayout(false);
            groupBoxVod_OLM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panele_OLM.ResumeLayout(false);
            groupBoxResult_OLM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private Panel panelw_OLM;
        private Panel panelq_OLM;
        private GroupBox groupBoxIf_OLM;
        private Panel panelr_OLM;
        private Panel panele_OLM;
        private Splitter splitterw_OLM;
        private GroupBox groupBoxVod_OLM;
        private GroupBox groupBoxResult_OLM;
        private Button buttonwe_OLM;
        private Button buttonsave_OLM;
        private Button buttonFail_OLM;
        private Button buttonHelp_OLM;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private OpenFileDialog openFileDialogqw_OLM;
        private SaveFileDialog saveFileDialogTask_OLM;
    }
}