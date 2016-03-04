namespace DataCheck
{
    partial class HammingExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAddingData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInitialData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvErrorCheck = new System.Windows.Forms.DataGridView();
            this.lError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddingData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddingData
            // 
            this.dgvAddingData.AllowUserToAddRows = false;
            this.dgvAddingData.AllowUserToDeleteRows = false;
            this.dgvAddingData.AllowUserToResizeColumns = false;
            this.dgvAddingData.AllowUserToResizeRows = false;
            this.dgvAddingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddingData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddingData.ColumnHeadersVisible = false;
            this.dgvAddingData.Location = new System.Drawing.Point(12, 70);
            this.dgvAddingData.Name = "dgvAddingData";
            this.dgvAddingData.ReadOnly = true;
            this.dgvAddingData.RowHeadersVisible = false;
            this.dgvAddingData.Size = new System.Drawing.Size(511, 191);
            this.dgvAddingData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный код:";
            // 
            // dgvInitialData
            // 
            this.dgvInitialData.AllowUserToAddRows = false;
            this.dgvInitialData.AllowUserToDeleteRows = false;
            this.dgvInitialData.AllowUserToResizeColumns = false;
            this.dgvInitialData.AllowUserToResizeRows = false;
            this.dgvInitialData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInitialData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInitialData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInitialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialData.ColumnHeadersVisible = false;
            this.dgvInitialData.Location = new System.Drawing.Point(12, 29);
            this.dgvInitialData.Name = "dgvInitialData";
            this.dgvInitialData.ReadOnly = true;
            this.dgvInitialData.RowHeadersVisible = false;
            this.dgvInitialData.Size = new System.Drawing.Size(511, 22);
            this.dgvInitialData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вставка битов с дополнительной информацией:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Проверка алгоритма:";
            // 
            // dgvErrorCheck
            // 
            this.dgvErrorCheck.AllowUserToAddRows = false;
            this.dgvErrorCheck.AllowUserToDeleteRows = false;
            this.dgvErrorCheck.AllowUserToResizeColumns = false;
            this.dgvErrorCheck.AllowUserToResizeRows = false;
            this.dgvErrorCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvErrorCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorCheck.Location = new System.Drawing.Point(12, 280);
            this.dgvErrorCheck.Name = "dgvErrorCheck";
            this.dgvErrorCheck.ReadOnly = true;
            this.dgvErrorCheck.RowHeadersVisible = false;
            this.dgvErrorCheck.Size = new System.Drawing.Size(511, 89);
            this.dgvErrorCheck.TabIndex = 5;
            this.dgvErrorCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvErrorCheck_KeyDown);
            // 
            // lError
            // 
            this.lError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(12, 378);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 13);
            this.lError.TabIndex = 6;
            // 
            // HammingExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 400);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.dgvErrorCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInitialData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddingData);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "HammingExampleForm";
            this.Text = "Пример кода Хэмминга";
            this.Load += new System.EventHandler(this.HammingExampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddingData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddingData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInitialData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvErrorCheck;
        private System.Windows.Forms.Label lError;
    }
}