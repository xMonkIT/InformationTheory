using System.ComponentModel;
using System.Windows.Forms;

namespace DataReduction
{
    partial class LZForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.lBuffer = new System.Windows.Forms.Label();
            this.nudDictLength = new System.Windows.Forms.NumericUpDown();
            this.nudBufferLength = new System.Windows.Forms.NumericUpDown();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Dictionary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbZippType = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lZippedCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudDictLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBufferLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер словаря:";
            // 
            // lBuffer
            // 
            this.lBuffer.AutoSize = true;
            this.lBuffer.Location = new System.Drawing.Point(12, 67);
            this.lBuffer.Name = "lBuffer";
            this.lBuffer.Size = new System.Drawing.Size(89, 13);
            this.lBuffer.TabIndex = 2;
            this.lBuffer.Text = "Размер буфера:";
            // 
            // nudDictLength
            // 
            this.nudDictLength.Location = new System.Drawing.Point(112, 39);
            this.nudDictLength.Maximum = new decimal(new int[] {
            65536,
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
            this.nudDictLength.TabIndex = 4;
            this.nudDictLength.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // nudBufferLength
            // 
            this.nudBufferLength.Location = new System.Drawing.Point(112, 65);
            this.nudBufferLength.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudBufferLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBufferLength.Name = "nudBufferLength";
            this.nudBufferLength.Size = new System.Drawing.Size(199, 20);
            this.nudBufferLength.TabIndex = 5;
            this.nudBufferLength.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dictionary,
            this.Code});
            this.dgvData.Location = new System.Drawing.Point(12, 91);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(299, 222);
            this.dgvData.TabIndex = 6;
            // 
            // Dictionary
            // 
            this.Dictionary.HeaderText = "Словарь";
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип сжатия:";
            // 
            // cbZippType
            // 
            this.cbZippType.FormattingEnabled = true;
            this.cbZippType.Location = new System.Drawing.Point(112, 12);
            this.cbZippType.Name = "cbZippType";
            this.cbZippType.Size = new System.Drawing.Size(199, 21);
            this.cbZippType.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lZippedCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(323, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(182, 17);
            this.toolStripStatusLabel1.Text = "Количество бит сжатого текста:";
            // 
            // lZippedCount
            // 
            this.lZippedCount.Name = "lZippedCount";
            this.lZippedCount.Size = new System.Drawing.Size(13, 17);
            this.lZippedCount.Text = "0";
            // 
            // LZForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 338);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbZippType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.nudBufferLength);
            this.Controls.Add(this.nudDictLength);
            this.Controls.Add(this.lBuffer);
            this.Controls.Add(this.label1);
            this.Name = "LZForm";
            this.Text = "Словарно-ориентированные методы кодирования";
            this.Shown += new System.EventHandler(this.LZForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDictLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBufferLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lBuffer;
        private NumericUpDown nudDictLength;
        private NumericUpDown nudBufferLength;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Dictionary;
        private DataGridViewTextBoxColumn Code;
        private Label label2;
        private ComboBox cbZippType;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lZippedCount;
    }
}