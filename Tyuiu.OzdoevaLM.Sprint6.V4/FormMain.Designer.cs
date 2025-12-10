using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4
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
            textBoxIn_OLM = new TextBox();
            textBoxOut_OLM = new TextBox();
            buttonOpenFile_OLM = new Button();
            buttonDo_OLM = new Button();
            buttonHelp_OLM = new Button();
            openFileDialogTask_OLM = new OpenFileDialog();
            SuspendLayout();

            // textBoxIn_OLM
            textBoxIn_OLM.Location = new Point(12, 12);
            textBoxIn_OLM.Multiline = true;
            textBoxIn_OLM.Name = "textBoxIn_OLM";
            textBoxIn_OLM.ScrollBars = ScrollBars.Both;
            textBoxIn_OLM.Size = new Size(350, 300);
            textBoxIn_OLM.TabIndex = 0;

            // textBoxOut_OLM
            textBoxOut_OLM.Location = new Point(380, 12);
            textBoxOut_OLM.Multiline = true;
            textBoxOut_OLM.Name = "textBoxOut_OLM";
            textBoxOut_OLM.ReadOnly = true;
            textBoxOut_OLM.ScrollBars = ScrollBars.Both;
            textBoxOut_OLM.Size = new Size(350, 300);
            textBoxOut_OLM.TabIndex = 1;

            // buttonOpenFile_OLM
            buttonOpenFile_OLM.Location = new Point(12, 320);
            buttonOpenFile_OLM.Name = "buttonOpenFile_OLM";
            buttonOpenFile_OLM.Size = new Size(120, 40);
            buttonOpenFile_OLM.TabIndex = 2;
            buttonOpenFile_OLM.Text = "Открыть файл";
            buttonOpenFile_OLM.UseVisualStyleBackColor = true;
            buttonOpenFile_OLM.Click += buttonOpenFile_OLM_Click;

            // buttonDo_OLM
            buttonDo_OLM.Enabled = false;
            buttonDo_OLM.Location = new Point(150, 320);
            buttonDo_OLM.Name = "buttonDo_OLM";
            buttonDo_OLM.Size = new Size(120, 40);
            buttonDo_OLM.TabIndex = 3;
            buttonDo_OLM.Text = "Выполнить";
            buttonDo_OLM.UseVisualStyleBackColor = true;
            buttonDo_OLM.Click += buttonDo_OLM_Click;

            // buttonHelp_OLM
            buttonHelp_OLM.Location = new Point(610, 320);
            buttonHelp_OLM.Name = "buttonHelp_OLM";
            buttonHelp_OLM.Size = new Size(120, 40);
            buttonHelp_OLM.TabIndex = 4;
            buttonHelp_OLM.Text = "Справка";
            buttonHelp_OLM.UseVisualStyleBackColor = true;
            buttonHelp_OLM.Click += buttonHelp_OLM_Click;

            // FormMain
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 372);
            Controls.Add(buttonHelp_OLM);
            Controls.Add(buttonDo_OLM);
            Controls.Add(buttonOpenFile_OLM);
            Controls.Add(textBoxOut_OLM);
            Controls.Add(textBoxIn_OLM);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 4 | Оздоева Л. М.";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxIn_OLM;
        private TextBox textBoxOut_OLM;
        private Button buttonOpenFile_OLM;
        private Button buttonDo_OLM;
        private Button buttonHelp_OLM;
        private OpenFileDialog openFileDialogTask_OLM;
    }
}