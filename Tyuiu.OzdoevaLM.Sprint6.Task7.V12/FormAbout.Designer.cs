namespace Tyuiu.OzdoevaLM.Sprint6.Task7.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            groupBoxqd_OLM = new GroupBox();
            textBoxaabout_OLM = new TextBox();
            pictureBox1 = new PictureBox();
            groupBoxqd_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // groupBoxqd_OLM
            groupBoxqd_OLM.Controls.Add(textBoxaabout_OLM);
            groupBoxqd_OLM.Controls.Add(pictureBox1);
            groupBoxqd_OLM.Dock = DockStyle.Fill;
            groupBoxqd_OLM.Location = new Point(0, 0);
            groupBoxqd_OLM.Name = "groupBoxqd_OLM";
            groupBoxqd_OLM.Size = new Size(800, 450);
            groupBoxqd_OLM.TabIndex = 0;
            groupBoxqd_OLM.TabStop = false;
            // textBoxaabout_OLM
            textBoxaabout_OLM.Location = new Point(326, 40);
            textBoxaabout_OLM.Multiline = true;
            textBoxaabout_OLM.Name = "textBoxaabout_OLM";
            textBoxaabout_OLM.ReadOnly = true;
            textBoxaabout_OLM.Size = new Size(468, 373);
            textBoxaabout_OLM.TabIndex = 1;
            textBoxaabout_OLM.Text = "Разработчик: Оздоева Лейла Магомедовна.\r\nГруппа: ИИПб-25-1.\r\nВариант: 12\r\nЗадание: Таск 7\r\n\r\nОписание:\r\nОбработка матрицы из CSV файла.\r\nВ девятом столбце значения не равные 10 заменяются на 0.";
            textBoxaabout_OLM.TextChanged += new System.EventHandler(textBoxaabout_OLM_TextChanged);
            // pictureBox1
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 373);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // FormAbout
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxqd_OLM);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о разработчике";
            groupBoxqd_OLM.ResumeLayout(false);
            groupBoxqd_OLM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBoxqd_OLM;
        private TextBox textBoxaabout_OLM;
        private PictureBox pictureBox1;
    }
}