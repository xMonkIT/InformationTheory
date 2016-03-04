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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudInfWordLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOriginalBits = new System.Windows.Forms.RichTextBox();
            this.rtbWithAdditionalBits = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bShowExample = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbNewString = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfWordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст для кодирования:";
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbIncoming.Location = new System.Drawing.Point(12, 25);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(410, 96);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            this.rtbIncoming.TextChanged += new System.EventHandler(this.rtbIncoming_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина информационного слова:";
            // 
            // nudInfWordLength
            // 
            this.nudInfWordLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInfWordLength.Location = new System.Drawing.Point(190, 127);
            this.nudInfWordLength.Name = "nudInfWordLength";
            this.nudInfWordLength.Size = new System.Drawing.Size(232, 20);
            this.nudInfWordLength.TabIndex = 2;
            this.nudInfWordLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudInfWordLength.ValueChanged += new System.EventHandler(this.nudInfWordLength_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Исходные биты:";
            // 
            // rtbOriginalBits
            // 
            this.rtbOriginalBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOriginalBits.Location = new System.Drawing.Point(0, 19);
            this.rtbOriginalBits.Name = "rtbOriginalBits";
            this.rtbOriginalBits.ReadOnly = true;
            this.rtbOriginalBits.Size = new System.Drawing.Size(203, 175);
            this.rtbOriginalBits.TabIndex = 3;
            this.rtbOriginalBits.Text = "";
            // 
            // rtbWithAdditionalBits
            // 
            this.rtbWithAdditionalBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbWithAdditionalBits.Location = new System.Drawing.Point(0, 19);
            this.rtbWithAdditionalBits.Name = "rtbWithAdditionalBits";
            this.rtbWithAdditionalBits.ReadOnly = true;
            this.rtbWithAdditionalBits.Size = new System.Drawing.Size(203, 175);
            this.rtbWithAdditionalBits.TabIndex = 4;
            this.rtbWithAdditionalBits.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Биты с дополнительной информацией:";
            // 
            // bShowExample
            // 
            this.bShowExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowExample.AutoSize = true;
            this.bShowExample.Location = new System.Drawing.Point(315, 376);
            this.bShowExample.Name = "bShowExample";
            this.bShowExample.Size = new System.Drawing.Size(107, 23);
            this.bShowExample.TabIndex = 5;
            this.bShowExample.Text = "Показать пример";
            this.bShowExample.UseVisualStyleBackColor = true;
            this.bShowExample.Click += new System.EventHandler(this.bShowExample_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 176);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbOriginalBits);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbWithAdditionalBits);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(410, 194);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 6;
            // 
            // cbNewString
            // 
            this.cbNewString.AutoSize = true;
            this.cbNewString.Checked = true;
            this.cbNewString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNewString.Location = new System.Drawing.Point(12, 153);
            this.cbNewString.Name = "cbNewString";
            this.cbNewString.Size = new System.Drawing.Size(275, 17);
            this.cbNewString.TabIndex = 7;
            this.cbNewString.Text = "Каждое информационное слово на новой строке";
            this.cbNewString.UseVisualStyleBackColor = true;
            this.cbNewString.CheckStateChanged += new System.EventHandler(this.cbNewString_CheckStateChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.cbNewString);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bShowExample);
            this.Controls.Add(this.nudInfWordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "MainForm";
            this.Text = "Код Хэмминга";
            ((System.ComponentModel.ISupportInitialize)(this.nudInfWordLength)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private CheckBox cbNewString;
    }
}

