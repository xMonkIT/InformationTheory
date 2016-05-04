namespace Goley
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
            this.dgvErrorCheck = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInitialData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAddingData = new System.Windows.Forms.DataGridView();
            this.bCheck = new System.Windows.Forms.Button();
            this.dgvPolynom = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInitialLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCheckerLength = new System.Windows.Forms.NumericUpDown();
            this.bPerfect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddingData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolynom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckerLength)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErrorCheck
            // 
            this.dgvErrorCheck.AllowUserToAddRows = false;
            this.dgvErrorCheck.AllowUserToDeleteRows = false;
            this.dgvErrorCheck.AllowUserToResizeColumns = false;
            this.dgvErrorCheck.AllowUserToResizeRows = false;
            this.dgvErrorCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvErrorCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorCheck.ColumnHeadersVisible = false;
            this.dgvErrorCheck.Location = new System.Drawing.Point(12, 209);
            this.dgvErrorCheck.Name = "dgvErrorCheck";
            this.dgvErrorCheck.RowHeadersVisible = false;
            this.dgvErrorCheck.Size = new System.Drawing.Size(511, 22);
            this.dgvErrorCheck.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Проверка алгоритма:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вставка битов с дополнительной информацией:";
            // 
            // dgvInitialData
            // 
            this.dgvInitialData.AllowUserToAddRows = false;
            this.dgvInitialData.AllowUserToDeleteRows = false;
            this.dgvInitialData.AllowUserToResizeColumns = false;
            this.dgvInitialData.AllowUserToResizeRows = false;
            this.dgvInitialData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInitialData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInitialData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInitialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialData.ColumnHeadersVisible = false;
            this.dgvInitialData.Location = new System.Drawing.Point(12, 86);
            this.dgvInitialData.Name = "dgvInitialData";
            this.dgvInitialData.RowHeadersVisible = false;
            this.dgvInitialData.Size = new System.Drawing.Size(511, 22);
            this.dgvInitialData.TabIndex = 1;
            this.dgvInitialData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Исходный код:";
            // 
            // dgvAddingData
            // 
            this.dgvAddingData.AllowUserToAddRows = false;
            this.dgvAddingData.AllowUserToDeleteRows = false;
            this.dgvAddingData.AllowUserToResizeColumns = false;
            this.dgvAddingData.AllowUserToResizeRows = false;
            this.dgvAddingData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddingData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddingData.ColumnHeadersVisible = false;
            this.dgvAddingData.Location = new System.Drawing.Point(12, 168);
            this.dgvAddingData.Name = "dgvAddingData";
            this.dgvAddingData.ReadOnly = true;
            this.dgvAddingData.RowHeadersVisible = false;
            this.dgvAddingData.Size = new System.Drawing.Size(511, 22);
            this.dgvAddingData.TabIndex = 6;
            // 
            // bCheck
            // 
            this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheck.Location = new System.Drawing.Point(448, 237);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 23);
            this.bCheck.TabIndex = 4;
            this.bCheck.Text = "Проверка";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // dgvPolynom
            // 
            this.dgvPolynom.AllowUserToAddRows = false;
            this.dgvPolynom.AllowUserToDeleteRows = false;
            this.dgvPolynom.AllowUserToResizeColumns = false;
            this.dgvPolynom.AllowUserToResizeRows = false;
            this.dgvPolynom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPolynom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolynom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPolynom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolynom.ColumnHeadersVisible = false;
            this.dgvPolynom.Location = new System.Drawing.Point(12, 127);
            this.dgvPolynom.Name = "dgvPolynom";
            this.dgvPolynom.RowHeadersVisible = false;
            this.dgvPolynom.Size = new System.Drawing.Size(511, 22);
            this.dgvPolynom.TabIndex = 2;
            this.dgvPolynom.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Проверочный полином:";
            // 
            // nudInitialLength
            // 
            this.nudInitialLength.Location = new System.Drawing.Point(196, 12);
            this.nudInitialLength.Name = "nudInitialLength";
            this.nudInitialLength.Size = new System.Drawing.Size(120, 20);
            this.nudInitialLength.TabIndex = 15;
            this.nudInitialLength.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Степень исходного полинома:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Степень проверочного полинома:";
            // 
            // nudCheckerLength
            // 
            this.nudCheckerLength.Location = new System.Drawing.Point(196, 38);
            this.nudCheckerLength.Name = "nudCheckerLength";
            this.nudCheckerLength.Size = new System.Drawing.Size(120, 20);
            this.nudCheckerLength.TabIndex = 17;
            this.nudCheckerLength.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // bPerfect
            // 
            this.bPerfect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPerfect.AutoSize = true;
            this.bPerfect.Location = new System.Drawing.Point(344, 12);
            this.bPerfect.Name = "bPerfect";
            this.bPerfect.Size = new System.Drawing.Size(179, 36);
            this.bPerfect.TabIndex = 19;
            this.bPerfect.Text = "Привести к совершенному виду\r\n(12, 23)";
            this.bPerfect.UseVisualStyleBackColor = true;
            this.bPerfect.Click += new System.EventHandler(this.bPerfect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 268);
            this.Controls.Add(this.bPerfect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCheckerLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudInitialLength);
            this.Controls.Add(this.dgvPolynom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.dgvErrorCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInitialData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddingData);
            this.Name = "MainForm";
            this.Text = "Код Голея";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddingData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolynom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckerLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErrorCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInitialData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAddingData;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.DataGridView dgvPolynom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInitialLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCheckerLength;
        private System.Windows.Forms.Button bPerfect;
    }
}

