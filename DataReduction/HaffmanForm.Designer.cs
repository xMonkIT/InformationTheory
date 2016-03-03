using System.ComponentModel;
using System.Windows.Forms;

namespace DataReduction
{
    partial class HaffmanForm
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
            this.tvHaffmanTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvHaffmanTree
            // 
            this.tvHaffmanTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvHaffmanTree.Indent = 7;
            this.tvHaffmanTree.Location = new System.Drawing.Point(12, 12);
            this.tvHaffmanTree.Name = "tvHaffmanTree";
            this.tvHaffmanTree.PathSeparator = "";
            this.tvHaffmanTree.Size = new System.Drawing.Size(305, 489);
            this.tvHaffmanTree.TabIndex = 0;
            // 
            // HaffmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 513);
            this.Controls.Add(this.tvHaffmanTree);
            this.Name = "HaffmanForm";
            this.Text = "HaffmanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvHaffmanTree;
    }
}