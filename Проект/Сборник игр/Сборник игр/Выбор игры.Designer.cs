
namespace Сборник_игр
{
    partial class SelectGameF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGameF));
            this.label1 = new System.Windows.Forms.Label();
            this.DinoPb = new System.Windows.Forms.PictureBox();
            this.SudokuPb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TagPb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DinoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagPb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dino Chrome";
            // 
            // DinoPb
            // 
            this.DinoPb.Image = ((System.Drawing.Image)(resources.GetObject("DinoPb.Image")));
            this.DinoPb.Location = new System.Drawing.Point(12, 12);
            this.DinoPb.Name = "DinoPb";
            this.DinoPb.Size = new System.Drawing.Size(115, 105);
            this.DinoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DinoPb.TabIndex = 2;
            this.DinoPb.TabStop = false;
            this.DinoPb.Click += new System.EventHandler(this.DinoPb_Click);
            // 
            // SudokuPb
            // 
            this.SudokuPb.Image = ((System.Drawing.Image)(resources.GetObject("SudokuPb.Image")));
            this.SudokuPb.Location = new System.Drawing.Point(133, 12);
            this.SudokuPb.Name = "SudokuPb";
            this.SudokuPb.Size = new System.Drawing.Size(115, 105);
            this.SudokuPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SudokuPb.TabIndex = 4;
            this.SudokuPb.TabStop = false;
            this.SudokuPb.Click += new System.EventHandler(this.SudokuPb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label2.Location = new System.Drawing.Point(171, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sudoku";
            // 
            // TagPb
            // 
            this.TagPb.Image = ((System.Drawing.Image)(resources.GetObject("TagPb.Image")));
            this.TagPb.Location = new System.Drawing.Point(254, 12);
            this.TagPb.Name = "TagPb";
            this.TagPb.Size = new System.Drawing.Size(115, 105);
            this.TagPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TagPb.TabIndex = 5;
            this.TagPb.TabStop = false;
            this.TagPb.Click += new System.EventHandler(this.TagPb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.label3.Location = new System.Drawing.Point(297, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tag";
            // 
            // SelectGameF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TagPb);
            this.Controls.Add(this.SudokuPb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DinoPb);
            this.Controls.Add(this.label1);
            this.Name = "SelectGameF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор игры";
            ((System.ComponentModel.ISupportInitialize)(this.DinoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DinoPb;
        private System.Windows.Forms.PictureBox SudokuPb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox TagPb;
        private System.Windows.Forms.Label label3;
    }
}