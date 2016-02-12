﻿namespace DataReduction
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.tbAlphabet = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lEntropy = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiФайл = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tsmiАлгоритмыСжатия = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiДеревоХаффмана = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lByteCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBytePerChar = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lCharCount,
            this.toolStripStatusLabel2,
            this.lByteCount,
            this.toolStripStatusLabel5,
            this.lBytePerChar,
            this.toolStripStatusLabel3,
            this.lEntropy});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            this.splitContainer1.Size = new System.Drawing.Size(919, 368);
            this.splitContainer1.SplitterDistance = 699;
            this.splitContainer1.TabIndex = 2;
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIncoming.Location = new System.Drawing.Point(0, 0);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(699, 368);
            this.rtbIncoming.TabIndex = 0;
            this.rtbIncoming.Text = "";
            // 
            // tbAlphabet
            // 
            this.tbAlphabet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlphabet.Location = new System.Drawing.Point(0, 0);
            this.tbAlphabet.Multiline = true;
            this.tbAlphabet.Name = "tbAlphabet";
            this.tbAlphabet.ReadOnly = true;
            this.tbAlphabet.Size = new System.Drawing.Size(216, 368);
            this.tbAlphabet.TabIndex = 0;
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
            this.lCharCount.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lCharCount.Name = "lCharCount";
            this.lCharCount.Size = new System.Drawing.Size(17, 19);
            this.lCharCount.Text = "0";
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
            // tsmiФайл
            // 
            this.tsmiФайл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.tsmiФайл.Name = "tsmiФайл";
            this.tsmiФайл.Size = new System.Drawing.Size(48, 20);
            this.tsmiФайл.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tsmiАлгоритмыСжатия
            // 
            this.tsmiАлгоритмыСжатия.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiДеревоХаффмана});
            this.tsmiАлгоритмыСжатия.Name = "tsmiАлгоритмыСжатия";
            this.tsmiАлгоритмыСжатия.Size = new System.Drawing.Size(125, 20);
            this.tsmiАлгоритмыСжатия.Text = "Алгоритмы сжатия";
            // 
            // tsmiДеревоХаффмана
            // 
            this.tsmiДеревоХаффмана.Name = "tsmiДеревоХаффмана";
            this.tsmiДеревоХаффмана.Size = new System.Drawing.Size(176, 22);
            this.tsmiДеревоХаффмана.Text = "Дерево Хаффмана";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 19);
            this.toolStripStatusLabel2.Text = "Количество байт:";
            // 
            // lByteCount
            // 
            this.lByteCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lByteCount.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lByteCount.Name = "lByteCount";
            this.lByteCount.Size = new System.Drawing.Size(17, 19);
            this.lByteCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(99, 19);
            this.toolStripStatusLabel5.Text = "Байт на символ: ";
            // 
            // lBytePerChar
            // 
            this.lBytePerChar.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lBytePerChar.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lBytePerChar.Name = "lBytePerChar";
            this.lBytePerChar.Size = new System.Drawing.Size(17, 19);
            this.lBytePerChar.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 416);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbIncoming;
        private System.Windows.Forms.TextBox tbAlphabet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lCharCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lEntropy;
        private System.Windows.Forms.ToolStripMenuItem tsmiФайл;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiАлгоритмыСжатия;
        private System.Windows.Forms.ToolStripMenuItem tsmiДеревоХаффмана;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lByteCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lBytePerChar;
    }
}

