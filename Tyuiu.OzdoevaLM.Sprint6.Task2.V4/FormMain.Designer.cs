namespace Tyuiu.OzdoevaLM.Sprint6.Task2.V4
{
    partial class FormMain_OLM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxIf_OLM = new GroupBox();
            textBoxIf_OLM = new TextBox();
            groupBoxVod_OLM = new GroupBox();
            textBoxVod1_OLM = new TextBox();
            textBoxVod_OLM = new TextBox();
            labelEnd_OLM = new Label();
            labelStart_OLM = new Label();
            groupBoxResult_OLM = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            buttonHelp_OLM = new Button();
            buttonResult_OLM = new Button();
            groupBoxIf_OLM.SuspendLayout();
            groupBoxVod_OLM.SuspendLayout();
            groupBoxResult_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxIf_OLM
            // 
            groupBoxIf_OLM.Controls.Add(textBoxIf_OLM);
            groupBoxIf_OLM.Location = new Point(12, 12);
            groupBoxIf_OLM.Name = "groupBoxIf_OLM";
            groupBoxIf_OLM.Size = new Size(549, 328);
            groupBoxIf_OLM.TabIndex = 0;
            groupBoxIf_OLM.TabStop = false;
            groupBoxIf_OLM.Text = "Условие";
            // 
            // textBoxIf_OLM
            // 
            textBoxIf_OLM.Location = new Point(6, 28);
            textBoxIf_OLM.Multiline = true;
            textBoxIf_OLM.Name = "textBoxIf_OLM";
            textBoxIf_OLM.ReadOnly = true;
            textBoxIf_OLM.Size = new Size(537, 294);
            textBoxIf_OLM.TabIndex = 0;
            textBoxIf_OLM.Text = "F(x) = 2x - 4 + (2x-1)/(sin(x)+1)";
            textBoxIf_OLM.TextChanged += textBoxIf_OLM_TextChanged;
            // 
            // groupBoxVod_OLM
            // 
            groupBoxVod_OLM.Controls.Add(textBoxVod1_OLM);
            groupBoxVod_OLM.Controls.Add(textBoxVod_OLM);
            groupBoxVod_OLM.Controls.Add(labelEnd_OLM);
            groupBoxVod_OLM.Controls.Add(labelStart_OLM);
            groupBoxVod_OLM.Location = new Point(12, 346);
            groupBoxVod_OLM.Name = "groupBoxVod_OLM";
            groupBoxVod_OLM.Size = new Size(320, 102);
            groupBoxVod_OLM.TabIndex = 1;
            groupBoxVod_OLM.TabStop = false;
            groupBoxVod_OLM.Text = "Ввод данных";
            // 
            // textBoxVod1_OLM
            // 
            textBoxVod1_OLM.Location = new Point(166, 58);
            textBoxVod1_OLM.Name = "textBoxVod1_OLM";
            textBoxVod1_OLM.Size = new Size(125, 29);
            textBoxVod1_OLM.TabIndex = 3;
            // 
            // textBoxVod_OLM
            // 
            textBoxVod_OLM.Location = new Point(8, 58);
            textBoxVod_OLM.Name = "textBoxVod_OLM";
            textBoxVod_OLM.Size = new Size(125, 29);
            textBoxVod_OLM.TabIndex = 2;
            // 
            // labelEnd_OLM
            // 
            labelEnd_OLM.AutoSize = true;
            labelEnd_OLM.Location = new Point(166, 25);
            labelEnd_OLM.Name = "labelEnd_OLM";
            labelEnd_OLM.Size = new Size(97, 21);
            labelEnd_OLM.TabIndex = 1;
            labelEnd_OLM.Text = "Конец шага:";
            // 
            // labelStart_OLM
            // 
            labelStart_OLM.AutoSize = true;
            labelStart_OLM.Location = new Point(6, 25);
            labelStart_OLM.Name = "labelStart_OLM";
            labelStart_OLM.Size = new Size(93, 21);
            labelStart_OLM.TabIndex = 0;
            labelStart_OLM.Text = "Старт шага:";
            // 
            // groupBoxResult_OLM
            // 
            groupBoxResult_OLM.Controls.Add(chart1);
            groupBoxResult_OLM.Controls.Add(dataGridView1);
            groupBoxResult_OLM.Location = new Point(567, 18);
            groupBoxResult_OLM.Name = "groupBoxResult_OLM";
            groupBoxResult_OLM.Size = new Size(661, 430);
            groupBoxResult_OLM.TabIndex = 2;
            groupBoxResult_OLM.TabStop = false;
            groupBoxResult_OLM.Text = "Вывод данных:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(156, 28);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(485, 388);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, Column1 });
            dataGridView1.Location = new Point(16, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(119, 396);
            dataGridView1.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "F(x)";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // buttonHelp_OLM
            // 
            buttonHelp_OLM.BackColor = SystemColors.ActiveCaption;
            buttonHelp_OLM.Location = new Point(338, 358);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(94, 90);
            buttonHelp_OLM.TabIndex = 3;
            buttonHelp_OLM.Text = "Справка";
            buttonHelp_OLM.UseVisualStyleBackColor = false;
            buttonHelp_OLM.Click += buttonHelp_OLM_Click_1;
            // 
            // buttonResult_OLM
            // 
            buttonResult_OLM.BackColor = SystemColors.Highlight;
            buttonResult_OLM.Location = new Point(438, 358);
            buttonResult_OLM.Name = "buttonResult_OLM";
            buttonResult_OLM.Size = new Size(123, 90);
            buttonResult_OLM.TabIndex = 4;
            buttonResult_OLM.Text = "Выполнить";
            buttonResult_OLM.UseVisualStyleBackColor = false;
            buttonResult_OLM.Click += buttonResult_OLM_Click;
            // 
            // FormMain_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 460);
            Controls.Add(buttonResult_OLM);
            Controls.Add(buttonHelp_OLM);
            Controls.Add(groupBoxResult_OLM);
            Controls.Add(groupBoxVod_OLM);
            Controls.Add(groupBoxIf_OLM);
            Name = "FormMain_OLM";
            Text = "Спринт 6 | Таск 2 | Вариант 4 | Оздоева Л. М.";
            groupBoxIf_OLM.ResumeLayout(false);
            groupBoxIf_OLM.PerformLayout();
            groupBoxVod_OLM.ResumeLayout(false);
            groupBoxVod_OLM.PerformLayout();
            groupBoxResult_OLM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIf_OLM;
        private TextBox textBoxIf_OLM;
        private GroupBox groupBoxVod_OLM;
        private TextBox textBoxVod1_OLM;
        private TextBox textBoxVod_OLM;
        private Label labelEnd_OLM;
        private Label labelStart_OLM;
        private GroupBox groupBoxResult_OLM;
        private Button buttonHelp_OLM;
        private Button buttonResult_OLM;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
