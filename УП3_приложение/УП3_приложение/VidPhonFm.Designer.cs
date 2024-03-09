
namespace УП3_приложение
{
    partial class VidPhonFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidPhonFm));
            this.VidPhonDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VidPhonDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // VidPhonDGV
            // 
            this.VidPhonDGV.AllowUserToAddRows = false;
            this.VidPhonDGV.AllowUserToDeleteRows = false;
            this.VidPhonDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VidPhonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VidPhonDGV.Location = new System.Drawing.Point(12, 12);
            this.VidPhonDGV.Name = "VidPhonDGV";
            this.VidPhonDGV.ReadOnly = true;
            this.VidPhonDGV.RowHeadersWidth = 51;
            this.VidPhonDGV.RowTemplate.Height = 24;
            this.VidPhonDGV.Size = new System.Drawing.Size(331, 338);
            this.VidPhonDGV.TabIndex = 1;
            // 
            // VidPhonFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 366);
            this.Controls.Add(this.VidPhonDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VidPhonFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: вид телефона";
            this.Activated += new System.EventHandler(this.VidPhonFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.VidPhonDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VidPhonDGV;
    }
}