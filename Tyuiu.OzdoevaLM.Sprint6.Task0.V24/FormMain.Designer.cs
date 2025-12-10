namespace Tyuiu.OzdoevaLM.Sprint6.Task0.V24
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
            pictureBoxFor_OLM = new PictureBox();
            textBoxFormula_OLM = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxVod_OLM = new GroupBox();
            textBoxX_OLM = new TextBox();
            labelX_OLM = new Label();
            groupBoxResult_OLM = new GroupBox();
            label2 = new Label();
            textBoxResult_OLM = new TextBox();
            buttonCalculate_OLM = new Button();
            buttonHelp_OLM = new Button();
            groupBoxIf_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFor_OLM).BeginInit();
            groupBoxVod_OLM.SuspendLayout();
            groupBoxResult_OLM.SuspendLayout();
            SuspendLayout();

            // groupBoxIf_OLM
            groupBoxIf_OLM.Controls.Add(pictureBoxFor_OLM);
            groupBoxIf_OLM.Controls.Add(textBoxFormula_OLM);
            groupBoxIf_OLM.Location = new Point(12, 34);
            groupBoxIf_OLM.Name = "groupBoxIf_OLM";
            groupBoxIf_OLM.Size = new Size(776, 200);
            groupBoxIf_OLM.TabIndex = 0;
            groupBoxIf_OLM.TabStop = false;
            groupBoxIf_OLM.Text = "условие";

            // pictureBoxFor_OLM
            pictureBoxFor_OLM.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFor_OLM.Image = (Image)resources.GetObject("pictureBoxFor_OLM.Image");
            pictureBoxFor_OLM.Location = new Point(564, 28);
            pictureBoxFor_OLM.Name = "pictureBoxFor_OLM";
            pictureBoxFor_OLM.Size = new Size(206, 81);
            pictureBoxFor_OLM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFor_OLM.TabIndex = 1;
            pictureBoxFor_OLM.TabStop = false;

            // textBoxFormula_OLM
            textBoxFormula_OLM.Location = new Point(6, 28);
            textBoxFormula_OLM.Multiline = true;
            textBoxFormula_OLM.Name = "textBoxFormula_OLM";
            textBoxFormula_OLM.ReadOnly = true;
            textBoxFormula_OLM.Size = new Size(552, 166);
            textBoxFormula_OLM.TabIndex = 0;
            textBoxFormula_OLM.Text = "Вычислить выражение по формуле\r\ny(x) = (x - 1)^(3x + 1)\r\n\r\nПример: x = 3\r\nОкруглить до 3 знаков";

            // groupBoxVod_OLM
            groupBoxVod_OLM.Controls.Add(textBoxX_OLM);
            groupBoxVod_OLM.Controls.Add(labelX_OLM);
            groupBoxVod_OLM.Location = new Point(12, 250);
            groupBoxVod_OLM.Name = "groupBoxVod_OLM";
            groupBoxVod_OLM.Size = new Size(523, 125);
            groupBoxVod_OLM.TabIndex = 1;
            groupBoxVod_OLM.TabStop = false;
            groupBoxVod_OLM.Text = "Ввод данных";

            // textBoxX_OLM
            textBoxX_OLM.Location = new Point(24, 59);
            textBoxX_OLM.Name = "textBoxX_OLM";
            textBoxX_OLM.Size = new Size(116, 29);
            textBoxX_OLM.TabIndex = 1;

            // labelX_OLM
            labelX_OLM.AutoSize = true;
            labelX_OLM.Location = new Point(24, 35);
            labelX_OLM.Name = "labelX_OLM";
            labelX_OLM.Size = new Size(115, 21);
            labelX_OLM.TabIndex = 0;
            labelX_OLM.Text = "Переменная X:";

            // groupBoxResult_OLM
            groupBoxResult_OLM.Controls.Add(label2);
            groupBoxResult_OLM.Controls.Add(textBoxResult_OLM);
            groupBoxResult_OLM.Location = new Point(541, 250);
            groupBoxResult_OLM.Name = "groupBoxResult_OLM";
            groupBoxResult_OLM.Size = new Size(247, 125);
            groupBoxResult_OLM.TabIndex = 2;
            groupBoxResult_OLM.TabStop = false;
            groupBoxResult_OLM.Text = "Вывод данных";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Результат:";

            // textBoxResult_OLM
            textBoxResult_OLM.BackColor = Color.LightGray;
            textBoxResult_OLM.Location = new Point(6, 59);
            textBoxResult_OLM.Name = "textBoxResult_OLM";
            textBoxResult_OLM.ReadOnly = true;
            textBoxResult_OLM.Size = new Size(235, 29);
            textBoxResult_OLM.TabIndex = 0;

            // buttonCalculate_OLM
            buttonCalculate_OLM.BackColor = SystemColors.ActiveCaption;
            buttonCalculate_OLM.Location = new Point(575, 394);
            buttonCalculate_OLM.Name = "buttonCalculate_OLM";
            buttonCalculate_OLM.Size = new Size(136, 42);
            buttonCalculate_OLM.TabIndex = 3;
            buttonCalculate_OLM.Text = "Вычислить";
            buttonCalculate_OLM.UseVisualStyleBackColor = false;
            buttonCalculate_OLM.Click += new EventHandler(buttonCalculate_OLM_Click);

            // buttonHelp_OLM
            buttonHelp_OLM.BackColor = SystemColors.GradientActiveCaption;
            buttonHelp_OLM.Location = new Point(514, 394);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(55, 42);
            buttonHelp_OLM.TabIndex = 4;
            buttonHelp_OLM.Text = "?";
            buttonHelp_OLM.UseVisualStyleBackColor = false;
            buttonHelp_OLM.Click += new EventHandler(buttonHelp_OLM_Click);

            // FormMain
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_OLM);
            Controls.Add(buttonCalculate_OLM);
            Controls.Add(groupBoxResult_OLM);
            Controls.Add(groupBoxVod_OLM);
            Controls.Add(groupBoxIf_OLM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Оздоева Л. М.";
            groupBoxIf_OLM.ResumeLayout(false);
            groupBoxIf_OLM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFor_OLM).EndInit();
            groupBoxVod_OLM.ResumeLayout(false);
            groupBoxVod_OLM.PerformLayout();
            groupBoxResult_OLM.ResumeLayout(false);
            groupBoxResult_OLM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIf_OLM;
        private PictureBox pictureBoxFor_OLM;
        private TextBox textBoxFormula_OLM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxVod_OLM;
        private TextBox textBoxX_OLM;
        private Label labelX_OLM;
        private GroupBox groupBoxResult_OLM;
        private Label label2;
        private TextBox textBoxResult_OLM;
        private Button buttonCalculate_OLM;
        private Button buttonHelp_OLM;
    }
}