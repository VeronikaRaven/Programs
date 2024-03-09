
namespace УП3_приложение
{
    partial class AdministratorFm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorFm));
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddInfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteInfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.ПользователиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDGV
            // 
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(13, 50);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.RowTemplate.Height = 24;
            this.UserDGV.Size = new System.Drawing.Size(727, 150);
            this.UserDGV.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddInfToolStripMenuItem,
            this.EditInformationToolStripMenuItem,
            this.DeleteInfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddInfToolStripMenuItem
            // 
            this.AddInfToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddInfToolStripMenuItem.Name = "AddInfToolStripMenuItem";
            this.AddInfToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.AddInfToolStripMenuItem.Text = "Добавить";
            this.AddInfToolStripMenuItem.Click += new System.EventHandler(this.AddInfToolStripMenuItem_Click);
            // 
            // EditInformationToolStripMenuItem
            // 
            this.EditInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EditInformationToolStripMenuItem.Name = "EditInformationToolStripMenuItem";
            this.EditInformationToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.EditInformationToolStripMenuItem.Text = "Изменить";
            this.EditInformationToolStripMenuItem.Click += new System.EventHandler(this.EditInfToolStripMenuItem_Click);
            // 
            // DeleteInfToolStripMenuItem
            // 
            this.DeleteInfToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteInfToolStripMenuItem.Name = "DeleteInfToolStripMenuItem";
            this.DeleteInfToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.DeleteInfToolStripMenuItem.Text = "Удалить";
            this.DeleteInfToolStripMenuItem.Click += new System.EventHandler(this.DeleteInfToolStripMenuItem_Click);
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            this.пользователиBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // AdministratorFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 230);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор: главное меню";
            this.Activated += new System.EventHandler(this.AdministratorFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddInfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteInfToolStripMenuItem;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
    }
}