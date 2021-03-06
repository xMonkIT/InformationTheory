﻿using System.ComponentModel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiФайл = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiОткрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiАлгоритмыСжатия = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiДеревоХаффмана = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLZ78 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLZV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLZSS = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBitCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBitPerChar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lEntropy = new System.Windows.Forms.ToolStripStatusLabel();
            this.lZippedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.tbAlphabet = new System.Windows.Forms.TextBox();
            this.ofdTextFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiФайл,
            this.tsmiАлгоритмыСжатия});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiФайл
            // 
            this.tsmiФайл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiОткрыть});
            this.tsmiФайл.Name = "tsmiФайл";
            this.tsmiФайл.Size = new System.Drawing.Size(48, 20);
            this.tsmiФайл.Text = "Файл";
            // 
            // tsmiОткрыть
            // 
            this.tsmiОткрыть.Name = "tsmiОткрыть";
            this.tsmiОткрыть.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsmiОткрыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiОткрыть.Size = new System.Drawing.Size(173, 22);
            this.tsmiОткрыть.Text = "Открыть...";
            this.tsmiОткрыть.Click += new System.EventHandler(this.tsmiОткрыть_Click);
            // 
            // tsmiАлгоритмыСжатия
            // 
            this.tsmiАлгоритмыСжатия.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiДеревоХаффмана,
            this.tsmiLZ78,
            this.tsmiLZV,
            this.tsmiLZSS});
            this.tsmiАлгоритмыСжатия.Name = "tsmiАлгоритмыСжатия";
            this.tsmiАлгоритмыСжатия.Size = new System.Drawing.Size(125, 20);
            this.tsmiАлгоритмыСжатия.Text = "Алгоритмы сжатия";
            // 
            // tsmiДеревоХаффмана
            // 
            this.tsmiДеревоХаффмана.Name = "tsmiДеревоХаффмана";
            this.tsmiДеревоХаффмана.Size = new System.Drawing.Size(176, 22);
            this.tsmiДеревоХаффмана.Text = "Дерево Хаффмана";
            this.tsmiДеревоХаффмана.Click += new System.EventHandler(this.tsmiДеревоХаффмана_Click);
            // 
            // tsmiLZ78
            // 
            this.tsmiLZ78.Name = "tsmiLZ78";
            this.tsmiLZ78.Size = new System.Drawing.Size(176, 22);
            this.tsmiLZ78.Text = "LZ78";
            this.tsmiLZ78.Click += new System.EventHandler(this.tsmiLZ78_Click);
            // 
            // tsmiLZV
            // 
            this.tsmiLZV.Name = "tsmiLZV";
            this.tsmiLZV.Size = new System.Drawing.Size(176, 22);
            this.tsmiLZV.Text = "LZV";
            this.tsmiLZV.Click += new System.EventHandler(this.tsmiLZV_Click);
            // 
            // tsmiLZSS
            // 
            this.tsmiLZSS.Name = "tsmiLZSS";
            this.tsmiLZSS.Size = new System.Drawing.Size(176, 22);
            this.tsmiLZSS.Text = "LZSS";
            this.tsmiLZSS.Click += new System.EventHandler(this.tsmiLZSS_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lCharCount,
            this.toolStripStatusLabel2,
            this.lBitCount,
            this.toolStripStatusLabel5,
            this.lBitPerChar,
            this.toolStripStatusLabel3,
            this.lEntropy,
            this.lZippedCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 19);
            this.toolStripStatusLabel1.Text = "Количество символов:";
            // 
            // lCharCount
            // 
            this.lCharCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lCharCount.Name = "lCharCount";
            this.lCharCount.Size = new System.Drawing.Size(17, 19);
            this.lCharCount.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 19);
            this.toolStripStatusLabel2.Text = "Количество бит:";
            // 
            // lBitCount
            // 
            this.lBitCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lBitCount.Name = "lBitCount";
            this.lBitCount.Size = new System.Drawing.Size(17, 19);
            this.lBitCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 19);
            this.toolStripStatusLabel5.Text = "Бит на символ: ";
            // 
            // lBitPerChar
            // 
            this.lBitPerChar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lBitPerChar.Name = "lBitPerChar";
            this.lBitPerChar.Size = new System.Drawing.Size(17, 19);
            this.lBitPerChar.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(63, 19);
            this.toolStripStatusLabel3.Text = "Энтропия:";
            // 
            // lEntropy
            // 
            this.lEntropy.Name = "lEntropy";
            this.lEntropy.Size = new System.Drawing.Size(13, 19);
            this.lEntropy.Text = "0";
            // 
            // lZippedCount
            // 
            this.lZippedCount.Name = "lZippedCount";
            this.lZippedCount.Size = new System.Drawing.Size(0, 19);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbIncoming);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbAlphabet);
            this.splitContainer1.Size = new System.Drawing.Size(806, 389);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 2;
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIncoming.Location = new System.Drawing.Point(0, 0);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(451, 389);
            this.rtbIncoming.TabIndex = 0;
            this.rtbIncoming.Text = resources.GetString("rtbIncoming.Text");
            this.rtbIncoming.TextChanged += new System.EventHandler(this.rtbIncoming_TextChanged);
            // 
            // tbAlphabet
            // 
            this.tbAlphabet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlphabet.Location = new System.Drawing.Point(0, 0);
            this.tbAlphabet.Multiline = true;
            this.tbAlphabet.Name = "tbAlphabet";
            this.tbAlphabet.ReadOnly = true;
            this.tbAlphabet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAlphabet.Size = new System.Drawing.Size(351, 389);
            this.tbAlphabet.TabIndex = 0;
            // 
            // ofdTextFile
            // 
            this.ofdTextFile.Filter = "Текстовые файлы|*.txt|Все файлы|*";
            this.ofdTextFile.Title = "Выберите текстовый файл:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 437);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
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

