
namespace УП3_приложение
{
    partial class VedonostZvonkovFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VedonostZvonkovFm));
            this.VedomZvonDGV = new System.Windows.Forms.DataGridView();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.ведомостьзвонковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ведомость_звонковTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.Ведомость_звонковTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VedomZvonDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьзвонковBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VedomZvonDGV
            // 
            this.VedomZvonDGV.AllowUserToAddRows = false;
            this.VedomZvonDGV.AllowUserToDeleteRows = false;
            this.VedomZvonDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VedomZvonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VedomZvonDGV.Location = new System.Drawing.Point(12, 12);
            this.VedomZvonDGV.Name = "VedomZvonDGV";
            this.VedomZvonDGV.ReadOnly = true;
            this.VedomZvonDGV.RowHeadersWidth = 51;
            this.VedomZvonDGV.RowTemplate.Height = 24;
            this.VedomZvonDGV.Size = new System.Drawing.Size(704, 282);
            this.VedomZvonDGV.TabIndex = 0;
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ведомостьзвонковBindingSource
            // 
            this.ведомостьзвонковBindingSource.DataMember = "Ведомость_звонков";
            this.ведомостьзвонковBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // ведомость_звонковTableAdapter
            // 
            this.ведомость_звонковTableAdapter.ClearBeforeFill = true;
            // 
            // VedonostZvonkovFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VedomZvonDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VedonostZvonkovFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: ведомость звонков";
            this.Activated += new System.EventHandler(this.VedonostZvonkovFm_Activated);
            this.Load += new System.EventHandler(this.VedonostZvonkovFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VedomZvonDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ведомостьзвонковBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VedomZvonDGV;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.BindingSource ведомостьзвонковBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.Ведомость_звонковTableAdapter ведомость_звонковTableAdapter;
    }
}