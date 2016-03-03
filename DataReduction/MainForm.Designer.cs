using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataReduction
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new MenuStrip();
            this.tsmiФайл = new ToolStripMenuItem();
            this.tsmiОткрыть = new ToolStripMenuItem();
            this.tsmiАлгоритмыСжатия = new ToolStripMenuItem();
            this.tsmiДеревоХаффмана = new ToolStripMenuItem();
            this.tsmiLZ78 = new ToolStripMenuItem();
            this.tsmiLZV = new ToolStripMenuItem();
            this.tsmiLZSS = new ToolStripMenuItem();
            this.statusStrip1 = new StatusStrip();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.lCharCount = new ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new ToolStripStatusLabel();
            this.lBitCount = new ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new ToolStripStatusLabel();
            this.lBitPerChar = new ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new ToolStripStatusLabel();
            this.lEntropy = new ToolStripStatusLabel();
            this.lZippedCount = new ToolStripStatusLabel();
            this.splitContainer1 = new SplitContainer();
            this.rtbIncoming = new RichTextBox();
            this.tbAlphabet = new TextBox();
            this.ofdTextFile = new OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.tsmiФайл,
            this.tsmiАлгоритмыСжатия});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiФайл
            // 
            this.tsmiФайл.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmiОткрыть});
            this.tsmiФайл.Name = "tsmiФайл";
            this.tsmiФайл.Size = new Size(48, 20);
            this.tsmiФайл.Text = "Файл";
            // 
            // tsmiОткрыть
            // 
            this.tsmiОткрыть.Name = "tsmiОткрыть";
            this.tsmiОткрыть.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsmiОткрыть.ShortcutKeys = ((Keys)((Keys.Control | Keys.O)));
            this.tsmiОткрыть.Size = new Size(173, 22);
            this.tsmiОткрыть.Text = "Открыть...";
            this.tsmiОткрыть.Click += new EventHandler(this.tsmiОткрыть_Click);
            // 
            // tsmiАлгоритмыСжатия
            // 
            this.tsmiАлгоритмыСжатия.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmiДеревоХаффмана,
            this.tsmiLZ78,
            this.tsmiLZV,
            this.tsmiLZSS});
            this.tsmiАлгоритмыСжатия.Name = "tsmiАлгоритмыСжатия";
            this.tsmiАлгоритмыСжатия.Size = new Size(125, 20);
            this.tsmiАлгоритмыСжатия.Text = "Алгоритмы сжатия";
            // 
            // tsmiДеревоХаффмана
            // 
            this.tsmiДеревоХаффмана.Name = "tsmiДеревоХаффмана";
            this.tsmiДеревоХаффмана.Size = new Size(176, 22);
            this.tsmiДеревоХаффмана.Text = "Дерево Хаффмана";
            this.tsmiДеревоХаффмана.Click += new EventHandler(this.tsmiДеревоХаффмана_Click);
            // 
            // tsmiLZ78
            // 
            this.tsmiLZ78.Name = "tsmiLZ78";
            this.tsmiLZ78.Size = new Size(176, 22);
            this.tsmiLZ78.Text = "LZ78";
            this.tsmiLZ78.Click += new EventHandler(this.tsmiLZ78_Click);
            // 
            // tsmiLZV
            // 
            this.tsmiLZV.Name = "tsmiLZV";
            this.tsmiLZV.Size = new Size(176, 22);
            this.tsmiLZV.Text = "LZV";
            this.tsmiLZV.Click += new EventHandler(this.tsmiLZV_Click);
            // 
            // tsmiLZSS
            // 
            this.tsmiLZSS.Name = "tsmiLZSS";
            this.tsmiLZSS.Size = new Size(176, 22);
            this.tsmiLZSS.Text = "LZSS";
            this.tsmiLZSS.Click += new EventHandler(this.tsmiLZSS_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lCharCount,
            this.toolStripStatusLabel2,
            this.lBitCount,
            this.toolStripStatusLabel5,
            this.lBitPerChar,
            this.toolStripStatusLabel3,
            this.lEntropy,
            this.lZippedCount});
            this.statusStrip1.Location = new Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(806, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(133, 19);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // lCharCount
            // 
            this.lCharCount.BorderSides = ToolStripStatusLabelBorderSides.Right;
            this.lCharCount.Name = "lCharCount";
            this.lCharCount.Size = new Size(17, 19);
            this.lCharCount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new Size(97, 19);
            this.toolStripStatusLabel2.Text = "Количество бит:";
            // 
            // lBitCount
            // 
            this.lBitCount.BorderSides = ToolStripStatusLabelBorderSides.Right;
            this.lBitCount.Name = "lBitCount";
            this.lBitCount.Size = new Size(17, 19);
            this.lBitCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new Size(93, 19);
            this.toolStripStatusLabel5.Text = "Бит на символ: ";
            // 
            // lBitPerChar
            // 
            this.lBitPerChar.BorderSides = ToolStripStatusLabelBorderSides.Right;
            this.lBitPerChar.Name = "lBitPerChar";
            this.lBitPerChar.Size = new Size(17, 19);
            this.lBitPerChar.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new Size(63, 19);
            this.toolStripStatusLabel3.Text = "Энтропия:";
            // 
            // lEntropy
            // 
            this.lEntropy.Name = "lEntropy";
            this.lEntropy.Size = new Size(13, 19);
            this.lEntropy.Text = "0";
            // 
            // lZippedCount
            // 
            this.lZippedCount.Name = "lZippedCount";
            this.lZippedCount.Size = new Size(0, 19);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.FixedPanel = FixedPanel.Panel2;
            this.splitContainer1.Location = new Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbIncoming);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbAlphabet);
            this.splitContainer1.Size = new Size(806, 389);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 2;
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Dock = DockStyle.Fill;
            this.rtbIncoming.Location = new Point(0, 0);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new Size(451, 389);
            this.rtbIncoming.TabIndex = 0;
            this.rtbIncoming.Text = resources.GetString("rtbIncoming.Text");
            this.rtbIncoming.TextChanged += new EventHandler(this.rtbIncoming_TextChanged);
            // 
            // tbAlphabet
            // 
            this.tbAlphabet.Dock = DockStyle.Fill;
            this.tbAlphabet.Location = new Point(0, 0);
            this.tbAlphabet.Multiline = true;
            this.tbAlphabet.Name = "tbAlphabet";
            this.tbAlphabet.ReadOnly = true;
            this.tbAlphabet.ScrollBars = ScrollBars.Vertical;
            this.tbAlphabet.Size = new Size(351, 389);
            this.tbAlphabet.TabIndex = 0;
            // 
            // ofdTextFile
            // 
            this.ofdTextFile.Filter = "Текстовые файлы|*.txt|Все файлы|*";
            this.ofdTextFile.Title = "Выберите текстовый файл:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(806, 437);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Сжатие данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private RichTextBox rtbIncoming;
        private TextBox tbAlphabet;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lCharCount;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lEntropy;
        private ToolStripMenuItem tsmiФайл;
        private ToolStripMenuItem tsmiОткрыть;
        private ToolStripMenuItem tsmiАлгоритмыСжатия;
        private ToolStripMenuItem tsmiДеревоХаффмана;
        private OpenFileDialog ofdTextFile;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lBitCount;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lBitPerChar;
        private ToolStripStatusLabel lZippedCount;
        private ToolStripMenuItem tsmiLZ78;
        private ToolStripMenuItem tsmiLZV;
        private ToolStripMenuItem tsmiLZSS;
    }
}

