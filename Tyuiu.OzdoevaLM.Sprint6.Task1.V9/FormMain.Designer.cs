namespace Tyuiu.OzdoevaLM.Sprint6.Task1.V9
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
            groupBoxIf_OLM = new GroupBox();
            textBoxIf_OLM = new TextBox();
            groupBoxResult_OLM = new GroupBox();
            labelResultat_OLM = new Label();
            textBoxResult_OLM = new TextBox();
            groupBoxVod_OLM = new GroupBox();
            textBoxEnd_OLM = new TextBox();
            textBoxStart_OLM = new TextBox();
            labelEnd_OLM = new Label();
            labelStart_OLM = new Label();
            buttonHelp_OLM = new Button();
            buttonResult_OLM = new Button();
            groupBoxIf_OLM.SuspendLayout();
            groupBoxResult_OLM.SuspendLayout();
            groupBoxVod_OLM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIf_OLM
            // 
            groupBoxIf_OLM.Controls.Add(textBoxIf_OLM);
            groupBoxIf_OLM.Location = new Point(12, 12);
            groupBoxIf_OLM.Name = "groupBoxIf_OLM";
            groupBoxIf_OLM.Size = new Size(599, 422);
            groupBoxIf_OLM.TabIndex = 0;
            groupBoxIf_OLM.TabStop = false;
            groupBoxIf_OLM.Text = "Условие";
            // 
            // textBoxIf_OLM
            // 
            textBoxIf_OLM.Font = new Font("Arial", 10.2F);
            textBoxIf_OLM.Location = new Point(6, 28);
            textBoxIf_OLM.Multiline = true;
            textBoxIf_OLM.Name = "textBoxIf_OLM";
            textBoxIf_OLM.ReadOnly = true;
            textBoxIf_OLM.Size = new Size(587, 388);
            textBoxIf_OLM.TabIndex = 0;
            textBoxIf_OLM.Text = "Протабулировать функцию:\r\nF(x) = 2x - 4 + (2x-1)/(sin(x)+1)\r\n\r\nДиапазон: [-5; 5]\r\nШаг: 1\r\n\r\nПри делении на ноль вернуть значение 0.\r\nЗначения округлить до двух знаков после запятой.";
            // 
            // groupBoxResult_OLM
            // 
            groupBoxResult_OLM.Controls.Add(labelResultat_OLM);
            groupBoxResult_OLM.Controls.Add(textBoxResult_OLM);
            groupBoxResult_OLM.Location = new Point(620, 12);
            groupBoxResult_OLM.Name = "groupBoxResult_OLM";
            groupBoxResult_OLM.Size = new Size(250, 529);
            groupBoxResult_OLM.TabIndex = 1;
            groupBoxResult_OLM.TabStop = false;
            groupBoxResult_OLM.Text = "Результат";
            // 
            // labelResultat_OLM
            // 
            labelResultat_OLM.AutoSize = true;
            labelResultat_OLM.Location = new Point(6, 28);
            labelResultat_OLM.Name = "labelResultat_OLM";
            labelResultat_OLM.Size = new Size(90, 23);
            labelResultat_OLM.TabIndex = 1;
            labelResultat_OLM.Text = "Результат:";
            // 
            // textBoxResult_OLM
            // 
            textBoxResult_OLM.Font = new Font("Consolas", 9F);
            textBoxResult_OLM.Location = new Point(6, 52);
            textBoxResult_OLM.Multiline = true;
            textBoxResult_OLM.Name = "textBoxResult_OLM";
            textBoxResult_OLM.ReadOnly = true;
            textBoxResult_OLM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_OLM.Size = new Size(238, 471);
            textBoxResult_OLM.TabIndex = 0;
            // 
            // groupBoxVod_OLM
            // 
            groupBoxVod_OLM.Controls.Add(textBoxEnd_OLM);
            groupBoxVod_OLM.Controls.Add(textBoxStart_OLM);
            groupBoxVod_OLM.Controls.Add(labelEnd_OLM);
            groupBoxVod_OLM.Controls.Add(labelStart_OLM);
            groupBoxVod_OLM.Location = new Point(18, 440);
            groupBoxVod_OLM.Name = "groupBoxVod_OLM";
            groupBoxVod_OLM.Size = new Size(310, 95);
            groupBoxVod_OLM.TabIndex = 2;
            groupBoxVod_OLM.TabStop = false;
            groupBoxVod_OLM.Text = "Ввод данных";
            // 
            // textBoxEnd_OLM
            // 
            textBoxEnd_OLM.Location = new Point(174, 59);
            textBoxEnd_OLM.Name = "textBoxEnd_OLM";
            textBoxEnd_OLM.Size = new Size(125, 29);
            textBoxEnd_OLM.TabIndex = 3;
            // 
            // textBoxStart_OLM
            // 
            textBoxStart_OLM.Location = new Point(19, 59);
            textBoxStart_OLM.Name = "textBoxStart_OLM";
            textBoxStart_OLM.Size = new Size(125, 29);
            textBoxStart_OLM.TabIndex = 2;
            textBoxStart_OLM.TextChanged += textBoxStart_OLM_TextChanged;
            // 
            // labelEnd_OLM
            // 
            labelEnd_OLM.AutoSize = true;
            labelEnd_OLM.Location = new Point(174, 35);
            labelEnd_OLM.Name = "labelEnd_OLM";
            labelEnd_OLM.Size = new Size(107, 23);
            labelEnd_OLM.TabIndex = 1;
            labelEnd_OLM.Text = "Конец шага:";
            // 
            // labelStart_OLM
            // 
            labelStart_OLM.AutoSize = true;
            labelStart_OLM.Location = new Point(19, 35);
            labelStart_OLM.Name = "labelStart_OLM";
            labelStart_OLM.Size = new Size(102, 23);
            labelStart_OLM.TabIndex = 0;
            labelStart_OLM.Text = "Старт шага:";
            labelStart_OLM.Click += labelStart_OLM_Click;
            // 
            // buttonHelp_OLM
            // 
            buttonHelp_OLM.BackColor = SystemColors.ActiveCaption;
            buttonHelp_OLM.Location = new Point(334, 452);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(102, 83);
            buttonHelp_OLM.TabIndex = 3;
            buttonHelp_OLM.Text = "Справка";
            buttonHelp_OLM.UseVisualStyleBackColor = false;
            buttonHelp_OLM.Click += buttonHelp_OLM_Click;
            // 
            // buttonResult_OLM
            // 
            buttonResult_OLM.BackColor = Color.LimeGreen;
            buttonResult_OLM.Location = new Point(442, 452);
            buttonResult_OLM.Name = "buttonResult_OLM";
            buttonResult_OLM.Size = new Size(163, 83);
            buttonResult_OLM.TabIndex = 4;
            buttonResult_OLM.Text = "Выполнить";
            buttonResult_OLM.UseVisualStyleBackColor = false;
            buttonResult_OLM.Click += buttonResult_OLM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(buttonResult_OLM);
            Controls.Add(buttonHelp_OLM);
            Controls.Add(groupBoxVod_OLM);
            Controls.Add(groupBoxResult_OLM);
            Controls.Add(groupBoxIf_OLM);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 9 | Оздоева Л. М.";
            groupBoxIf_OLM.ResumeLayout(false);
            groupBoxIf_OLM.PerformLayout();
            groupBoxResult_OLM.ResumeLayout(false);
            groupBoxResult_OLM.PerformLayout();
            groupBoxVod_OLM.ResumeLayout(false);
            groupBoxVod_OLM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIf_OLM;
        private TextBox textBoxIf_OLM;
        private GroupBox groupBoxResult_OLM;
        private Label labelResultat_OLM;
        private TextBox textBoxResult_OLM;
        private GroupBox groupBoxVod_OLM;
        private TextBox textBoxEnd_OLM;
        private TextBox textBoxStart_OLM;
        private Label labelEnd_OLM;
        private Label labelStart_OLM;
        private Button buttonHelp_OLM;
        private Button buttonResult_OLM;
    }
}