namespace Tyuiu.OzdoevaLM.Sprint6.Task3.V4
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxIf_OLM = new GroupBox();
            dataGridViewIf_OLM = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBoxIf_OLM = new TextBox();
            groupBoxResult_OLM = new GroupBox();
            labelResult_OLM = new Label();
            textBoxResult_OLM = new TextBox();
            buttonHelp_OLM = new Button();
            buttonResult_OLM = new Button();
            groupBoxIf_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIf_OLM).BeginInit();
            groupBoxResult_OLM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIf_OLM
            // 
            groupBoxIf_OLM.Controls.Add(dataGridViewIf_OLM);
            groupBoxIf_OLM.Controls.Add(textBoxIf_OLM);
            groupBoxIf_OLM.Location = new Point(12, 24);
            groupBoxIf_OLM.Name = "groupBoxIf_OLM";
            groupBoxIf_OLM.Size = new Size(723, 414);
            groupBoxIf_OLM.TabIndex = 0;
            groupBoxIf_OLM.TabStop = false;
            groupBoxIf_OLM.Text = "Условие";
            // 
            // dataGridViewIf_OLM
            // 
            dataGridViewIf_OLM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIf_OLM.ColumnHeadersVisible = false;
            dataGridViewIf_OLM.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewIf_OLM.Location = new Point(398, 39);
            dataGridViewIf_OLM.Name = "dataGridViewIf_OLM";
            dataGridViewIf_OLM.RowHeadersVisible = false;
            dataGridViewIf_OLM.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewIf_OLM.Size = new Size(296, 354);
            dataGridViewIf_OLM.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // textBoxIf_OLM
            // 
            textBoxIf_OLM.Location = new Point(6, 39);
            textBoxIf_OLM.Multiline = true;
            textBoxIf_OLM.Name = "textBoxIf_OLM";
            textBoxIf_OLM.ReadOnly = true;
            textBoxIf_OLM.Size = new Size(362, 354);
            textBoxIf_OLM.TabIndex = 0;
            textBoxIf_OLM.Text = resources.GetString("textBoxIf_OLM.Text");
            // 
            // groupBoxResult_OLM
            // 
            groupBoxResult_OLM.Controls.Add(labelResult_OLM);
            groupBoxResult_OLM.Controls.Add(textBoxResult_OLM);
            groupBoxResult_OLM.Location = new Point(741, 24);
            groupBoxResult_OLM.Name = "groupBoxResult_OLM";
            groupBoxResult_OLM.Size = new Size(193, 370);
            groupBoxResult_OLM.TabIndex = 1;
            groupBoxResult_OLM.TabStop = false;
            groupBoxResult_OLM.Text = "Вывод данных";
            // 
            // labelResult_OLM
            // 
            labelResult_OLM.AutoSize = true;
            labelResult_OLM.Location = new Point(6, 39);
            labelResult_OLM.Name = "labelResult_OLM";
            labelResult_OLM.Size = new Size(83, 21);
            labelResult_OLM.TabIndex = 1;
            labelResult_OLM.Text = "Результат:";
            // 
            // textBoxResult_OLM
            // 
            textBoxResult_OLM.Location = new Point(6, 67);
            textBoxResult_OLM.Name = "textBoxResult_OLM";
            textBoxResult_OLM.Size = new Size(125, 29);
            textBoxResult_OLM.TabIndex = 0;
            // 
            // buttonHelp_OLM
            // 
            buttonHelp_OLM.Location = new Point(741, 400);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(34, 32);
            buttonHelp_OLM.TabIndex = 2;
            buttonHelp_OLM.Text = "?";
            buttonHelp_OLM.UseVisualStyleBackColor = true;
            buttonHelp_OLM.Click += buttonHelp_OLM_Click;
            // 
            // buttonResult_OLM
            // 
            buttonResult_OLM.Location = new Point(787, 400);
            buttonResult_OLM.Name = "buttonResult_OLM";
            buttonResult_OLM.Size = new Size(147, 33);
            buttonResult_OLM.TabIndex = 3;
            buttonResult_OLM.Text = "Выполнить";
            buttonResult_OLM.UseVisualStyleBackColor = true;
            buttonResult_OLM.Click += buttonResult_OLM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(buttonResult_OLM);
            Controls.Add(buttonHelp_OLM);
            Controls.Add(groupBoxResult_OLM);
            Controls.Add(groupBoxIf_OLM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Оздоева Л. М.";
            Load += FormMain_Load;
            groupBoxIf_OLM.ResumeLayout(false);
            groupBoxIf_OLM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIf_OLM).EndInit();
            groupBoxResult_OLM.ResumeLayout(false);
            groupBoxResult_OLM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIf_OLM;
        private TextBox textBoxIf_OLM;
        private GroupBox groupBoxResult_OLM;
        private Label labelResult_OLM;
        private TextBox textBoxResult_OLM;
        private Button buttonHelp_OLM;
        private Button buttonResult_OLM;
        private DataGridView dataGridViewIf_OLM;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}