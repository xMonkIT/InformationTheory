using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataCheck
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.rtbIncoming = new RichTextBox();
            this.label2 = new Label();
            this.nudInfWordLength = new NumericUpDown();
            this.label3 = new Label();
            this.rtbOriginalBits = new RichTextBox();
            this.rtbWithAdditionalBits = new RichTextBox();
            this.label4 = new Label();
            this.bShowExample = new Button();
            ((ISupportInitialize)(this.nudInfWordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст для кодирования:";
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Location = new Point(12, 25);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new Size(412, 96);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new Size(172, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина информационного слова:";
            // 
            // nudInfWordLength
            // 
            this.nudInfWordLength.Location = new Point(190, 127);
            this.nudInfWordLength.Name = "nudInfWordLength";
            this.nudInfWordLength.Size = new Size(234, 20);
            this.nudInfWordLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Исходные биты:";
            // 
            // rtbOriginalBits
            // 
            this.rtbOriginalBits.Location = new Point(12, 171);
            this.rtbOriginalBits.Name = "rtbOriginalBits";
            this.rtbOriginalBits.Size = new Size(412, 96);
            this.rtbOriginalBits.TabIndex = 1;
            this.rtbOriginalBits.Text = "";
            // 
            // rtbWithAdditionalBits
            // 
            this.rtbWithAdditionalBits.Location = new Point(12, 286);
            this.rtbWithAdditionalBits.Name = "rtbWithAdditionalBits";
            this.rtbWithAdditionalBits.Size = new Size(412, 96);
            this.rtbWithAdditionalBits.TabIndex = 5;
            this.rtbWithAdditionalBits.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new Size(204, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Биты с дополнительной информацией:";
            // 
            // bShowExample
            // 
            this.bShowExample.AutoSize = true;
            this.bShowExample.Location = new Point(317, 388);
            this.bShowExample.Name = "bShowExample";
            this.bShowExample.Size = new Size(107, 23);
            this.bShowExample.TabIndex = 6;
            this.bShowExample.Text = "Показать пример";
            this.bShowExample.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(436, 423);
            this.Controls.Add(this.bShowExample);
            this.Controls.Add(this.rtbWithAdditionalBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudInfWordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbOriginalBits);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Код Хэмминга";
            ((ISupportInitialize)(this.nudInfWordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbIncoming;
        private NumericUpDown nudInfWordLength;
        private RichTextBox rtbOriginalBits;
        private RichTextBox rtbWithAdditionalBits;
        private Label label4;
        private Button bShowExample;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}

