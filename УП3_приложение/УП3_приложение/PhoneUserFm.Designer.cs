
namespace УП3_приложение
{
    partial class PhoneUserFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneUserFm));
            this.PhoneUserDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EditInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneUserDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneUserDGV
            // 
            this.PhoneUserDGV.AllowUserToAddRows = false;
            this.PhoneUserDGV.AllowUserToDeleteRows = false;
            this.PhoneUserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PhoneUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneUserDGV.Location = new System.Drawing.Point(12, 29);
            this.PhoneUserDGV.Name = "PhoneUserDGV";
            this.PhoneUserDGV.ReadOnly = true;
            this.PhoneUserDGV.RowHeadersWidth = 51;
            this.PhoneUserDGV.RowTemplate.Height = 24;
            this.PhoneUserDGV.Size = new System.Drawing.Size(1073, 150);
            this.PhoneUserDGV.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditInformationToolStripMenuItem
            // 
            this.EditInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EditInformationToolStripMenuItem.Name = "EditInformationToolStripMenuItem";
            this.EditInformationToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.EditInformationToolStripMenuItem.Text = "Изменить";
            this.EditInformationToolStripMenuItem.Click += new System.EventHandler(this.EditInformationToolStripMenuItem_Click);
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhoneUserFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 192);
            this.Controls.Add(this.PhoneUserDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneUserFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь: главное окно";
            this.Activated += new System.EventHandler(this.PhoneUserFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneUserDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PhoneUserDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditInformationToolStripMenuItem;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
    }
}