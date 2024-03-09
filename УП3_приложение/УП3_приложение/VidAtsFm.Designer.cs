
namespace УП3_приложение
{
    partial class VidAtsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidAtsFm));
            this.VidAtsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VidAtsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // VidAtsDGV
            // 
            this.VidAtsDGV.AllowUserToAddRows = false;
            this.VidAtsDGV.AllowUserToDeleteRows = false;
            this.VidAtsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VidAtsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VidAtsDGV.Location = new System.Drawing.Point(12, 12);
            this.VidAtsDGV.Name = "VidAtsDGV";
            this.VidAtsDGV.ReadOnly = true;
            this.VidAtsDGV.RowHeadersWidth = 51;
            this.VidAtsDGV.RowTemplate.Height = 24;
            this.VidAtsDGV.Size = new System.Drawing.Size(318, 285);
            this.VidAtsDGV.TabIndex = 1;
            // 
            // VidAtsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 312);
            this.Controls.Add(this.VidAtsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VidAtsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: АТС";
            this.Activated += new System.EventHandler(this.VidAtsFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.VidAtsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VidAtsDGV;
    }
}