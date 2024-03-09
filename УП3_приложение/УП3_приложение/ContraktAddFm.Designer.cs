
namespace УП3_приложение
{
    partial class ContraktAddFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContraktAddFm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AbonentCb = new System.Windows.Forms.ComboBox();
            this.абонентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.ObshTb = new System.Windows.Forms.TextBox();
            this.SummaTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.MejTb = new System.Windows.Forms.TextBox();
            this.MesTb = new System.Windows.Forms.TextBox();
            this.TownTb = new System.Windows.Forms.TextBox();
            this.YearTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.абонентыTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.АбонентыTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абонентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AbonentCb);
            this.groupBox1.Controls.Add(this.ObshTb);
            this.groupBox1.Controls.Add(this.SummaTb);
            this.groupBox1.Controls.Add(this.PriceTb);
            this.groupBox1.Controls.Add(this.MejTb);
            this.groupBox1.Controls.Add(this.MesTb);
            this.groupBox1.Controls.Add(this.TownTb);
            this.groupBox1.Controls.Add(this.YearTb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AddBt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 413);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Абонент";
            // 
            // AbonentCb
            // 
            this.AbonentCb.DataSource = this.абонентыBindingSource;
            this.AbonentCb.DisplayMember = "Фамилия";
            this.AbonentCb.FormattingEnabled = true;
            this.AbonentCb.Location = new System.Drawing.Point(182, 30);
            this.AbonentCb.Name = "AbonentCb";
            this.AbonentCb.Size = new System.Drawing.Size(189, 24);
            this.AbonentCb.TabIndex = 83;
            this.AbonentCb.ValueMember = "Код_абонента";
            // 
            // абонентыBindingSource
            // 
            this.абонентыBindingSource.DataMember = "Абоненты";
            this.абонентыBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ObshTb
            // 
            this.ObshTb.Location = new System.Drawing.Point(182, 299);
            this.ObshTb.Name = "ObshTb";
            this.ObshTb.Size = new System.Drawing.Size(189, 22);
            this.ObshTb.TabIndex = 82;
            this.ObshTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObshTb_KeyPress);
            // 
            // SummaTb
            // 
            this.SummaTb.Location = new System.Drawing.Point(182, 263);
            this.SummaTb.Name = "SummaTb";
            this.SummaTb.Size = new System.Drawing.Size(189, 22);
            this.SummaTb.TabIndex = 81;
            this.SummaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SummaTb_KeyPress);
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(182, 226);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(189, 22);
            this.PriceTb.TabIndex = 78;
            this.PriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTb_KeyPress);
            // 
            // MejTb
            // 
            this.MejTb.Location = new System.Drawing.Point(182, 186);
            this.MejTb.Name = "MejTb";
            this.MejTb.Size = new System.Drawing.Size(189, 22);
            this.MejTb.TabIndex = 80;
            this.MejTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MejTb_KeyPress);
            // 
            // MesTb
            // 
            this.MesTb.Location = new System.Drawing.Point(182, 72);
            this.MesTb.Name = "MesTb";
            this.MesTb.Size = new System.Drawing.Size(189, 22);
            this.MesTb.TabIndex = 74;
            this.MesTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MesTb_KeyPress);
            // 
            // TownTb
            // 
            this.TownTb.Location = new System.Drawing.Point(182, 143);
            this.TownTb.Name = "TownTb";
            this.TownTb.Size = new System.Drawing.Size(189, 22);
            this.TownTb.TabIndex = 79;
            this.TownTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TownTb_KeyPress);
            // 
            // YearTb
            // 
            this.YearTb.Location = new System.Drawing.Point(182, 106);
            this.YearTb.Name = "YearTb";
            this.YearTb.Size = new System.Drawing.Size(189, 22);
            this.YearTb.TabIndex = 77;
            this.YearTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearTb_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Общая стоимость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Сумма льготы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Кол-во мин межгород";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Кол-во мин город";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Месяц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Год";
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(224, 349);
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
            // абонентыTableAdapter
            // 
            this.абонентыTableAdapter.ClearBeforeFill = true;
            // 
            // ContraktAddFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 431);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContraktAddFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник: добавление данных об абоненте";
            this.Load += new System.EventHandler(this.ContraktAddFm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абонентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MesTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox MejTb;
        private System.Windows.Forms.TextBox TownTb;
        private System.Windows.Forms.TextBox YearTb;
        private System.Windows.Forms.TextBox ObshTb;
        private System.Windows.Forms.TextBox SummaTb;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AbonentCb;
        private System.Windows.Forms.BindingSource абонентыBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.АбонентыTableAdapter абонентыTableAdapter;
    }
}