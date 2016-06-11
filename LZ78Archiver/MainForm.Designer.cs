namespace LZ78Archiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nudDictLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiФайл = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiОткрыть = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenTextOrArchive = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveArchive = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudDictLength)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDictLength
            // 
            this.nudDictLength.Location = new System.Drawing.Point(112, 28);
            this.nudDictLength.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nudDictLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDictLength.Name = "nudDictLength";
            this.nudDictLength.Size = new System.Drawing.Size(199, 20);
            this.nudDictLength.TabIndex = 8;
            this.nudDictLength.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер словаря:";
            // 
            // rtbData
            // 
            this.rtbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbData.Location = new System.Drawing.Point(12, 54);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(537, 265);
            this.rtbData.TabIndex = 10;
            this.rtbData.Text = resources.GetString("rtbData.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiФайл});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiФайл
            // 
            this.tsmiФайл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiОткрыть,
            this.сохранитьКакToolStripMenuItem});
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
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // ofdOpenTextOrArchive
            // 
            this.ofdOpenTextOrArchive.Filter = "Текстовые файлы|*.txt|Архив LZ78|*.lz78|Все файлы|*";
            this.ofdOpenTextOrArchive.Title = "Выберите текстовый файл:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 331);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.nudDictLength);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Архиватор LZ78";
            ((System.ComponentModel.ISupportInitialize)(this.nudDictLength)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudDictLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiФайл;
        private System.Windows.Forms.ToolStripMenuItem tsmiОткрыть;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdOpenTextOrArchive;
        private System.Windows.Forms.SaveFileDialog sfdSaveArchive;
    }
}

