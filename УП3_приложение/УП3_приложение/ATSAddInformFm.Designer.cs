
namespace УП3_приложение
{
    partial class ATSAddInformFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATSAddInformFm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VidCb = new System.Windows.Forms.ComboBox();
            this.видАТСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.TownTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumbUserTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdressTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.вид_АТСTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.Вид_АТСTableAdapter();
            this.fKАТСВидАТСBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аТСTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.АТСTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видАТСBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKАТСВидАТСBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VidCb);
            this.groupBox1.Controls.Add(this.TownTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumbUserTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AdressTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AddBt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 306);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить АТС";
            // 
            // VidCb
            // 
            this.VidCb.DataSource = this.видАТСBindingSource;
            this.VidCb.DisplayMember = "Название";
            this.VidCb.FormattingEnabled = true;
            this.VidCb.Location = new System.Drawing.Point(182, 66);
            this.VidCb.Name = "VidCb";
            this.VidCb.Size = new System.Drawing.Size(189, 24);
            this.VidCb.TabIndex = 29;
            this.VidCb.ValueMember = "Код_вид";
            // 
            // видАТСBindingSource
            // 
            this.видАТСBindingSource.DataMember = "Вид_АТС";
            this.видАТСBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TownTb
            // 
            this.TownTb.Location = new System.Drawing.Point(182, 137);
            this.TownTb.Name = "TownTb";
            this.TownTb.Size = new System.Drawing.Size(189, 22);
            this.TownTb.TabIndex = 51;
            this.TownTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TownTb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Название";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(182, 32);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(189, 22);
            this.NameTb.TabIndex = 33;
            this.NameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Вид";
            // 
            // NumbUserTb
            // 
            this.NumbUserTb.Location = new System.Drawing.Point(182, 176);
            this.NumbUserTb.Name = "NumbUserTb";
            this.NumbUserTb.Size = new System.Drawing.Size(189, 22);
            this.NumbUserTb.TabIndex = 40;
            this.NumbUserTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbUserTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Адрес";
            // 
            // AdressTb
            // 
            this.AdressTb.Location = new System.Drawing.Point(182, 102);
            this.AdressTb.Name = "AdressTb";
            this.AdressTb.Size = new System.Drawing.Size(189, 22);
            this.AdressTb.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Город";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Количество абонентов";
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(229, 214);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(100, 50);
            this.AddBt.TabIndex = 25;
            this.AddBt.Text = "Добавить";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 23;
            // 
            // вид_АТСTableAdapter
            // 
            this.вид_АТСTableAdapter.ClearBeforeFill = true;
            // 
            // fKАТСВидАТСBindingSource
            // 
            this.fKАТСВидАТСBindingSource.DataMember = "FK_АТС_Вид_АТС";
            this.fKАТСВидАТСBindingSource.DataSource = this.видАТСBindingSource;
            // 
            // аТСTableAdapter
            // 
            this.аТСTableAdapter.ClearBeforeFill = true;
            // 
            // ATSAddInformFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 323);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATSAddInformFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник: добавление данных об АТС";
            this.Load += new System.EventHandler(this.ATSAddInformFm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видАТСBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKАТСВидАТСBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TownTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumbUserTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdressTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VidCb;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.BindingSource видАТСBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.Вид_АТСTableAdapter вид_АТСTableAdapter;
        private System.Windows.Forms.BindingSource fKАТСВидАТСBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.АТСTableAdapter аТСTableAdapter;
    }
}