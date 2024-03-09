
namespace УП3_приложение
{
    partial class PriceFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceFm));
            this.PriceDGV = new System.Windows.Forms.DataGridView();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.прайсАТСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.прайс_АТСTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.Прайс_АТСTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсАТСBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDGV
            // 
            this.PriceDGV.AllowUserToAddRows = false;
            this.PriceDGV.AllowUserToDeleteRows = false;
            this.PriceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PriceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDGV.Location = new System.Drawing.Point(12, 12);
            this.PriceDGV.Name = "PriceDGV";
            this.PriceDGV.ReadOnly = true;
            this.PriceDGV.RowHeadersWidth = 51;
            this.PriceDGV.RowTemplate.Height = 24;
            this.PriceDGV.Size = new System.Drawing.Size(613, 303);
            this.PriceDGV.TabIndex = 0;
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // прайсАТСBindingSource
            // 
            this.прайсАТСBindingSource.DataMember = "Прайс_АТС";
            this.прайсАТСBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // прайс_АТСTableAdapter
            // 
            this.прайс_АТСTableAdapter.ClearBeforeFill = true;
            // 
            // PriceFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 328);
            this.Controls.Add(this.PriceDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: прайса АТС";
            this.Activated += new System.EventHandler(this.PriceFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PriceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прайсАТСBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDGV;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.BindingSource прайсАТСBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.Прайс_АТСTableAdapter прайс_АТСTableAdapter;
    }
}