
namespace УП3_приложение
{
    partial class UserPhoneEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPhoneEditFm));
            this.UserPhoneDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LgotaCb = new System.Windows.Forms.ComboBox();
            this.MejTownCb = new System.Windows.Forms.ComboBox();
            this.VidCb = new System.Windows.Forms.ComboBox();
            this.видтелефонаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AdresTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.NumberTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FathernameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EditBt = new System.Windows.Forms.Button();
            this.вид_телефонаTableAdapter = new УП3_приложение.TelephoneСonnectionDBDataSetTableAdapters.Вид_телефонаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoneDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видтелефонаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPhoneDGV
            // 
            this.UserPhoneDGV.AllowUserToAddRows = false;
            this.UserPhoneDGV.AllowUserToDeleteRows = false;
            this.UserPhoneDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserPhoneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPhoneDGV.Location = new System.Drawing.Point(359, 12);
            this.UserPhoneDGV.Name = "UserPhoneDGV";
            this.UserPhoneDGV.ReadOnly = true;
            this.UserPhoneDGV.RowHeadersWidth = 51;
            this.UserPhoneDGV.RowTemplate.Height = 24;
            this.UserPhoneDGV.Size = new System.Drawing.Size(792, 320);
            this.UserPhoneDGV.TabIndex = 32;
            this.UserPhoneDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserPhoneDGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LgotaCb);
            this.groupBox1.Controls.Add(this.MejTownCb);
            this.groupBox1.Controls.Add(this.VidCb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AdresTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SurnameTb);
            this.groupBox1.Controls.Add(this.NumberTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FathernameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EditBt);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 446);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать абонента";
            // 
            // LgotaCb
            // 
            this.LgotaCb.FormattingEnabled = true;
            this.LgotaCb.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.LgotaCb.Location = new System.Drawing.Point(133, 252);
            this.LgotaCb.Name = "LgotaCb";
            this.LgotaCb.Size = new System.Drawing.Size(189, 24);
            this.LgotaCb.TabIndex = 66;
            // 
            // MejTownCb
            // 
            this.MejTownCb.FormattingEnabled = true;
            this.MejTownCb.Items.AddRange(new object[] {
            "Есть",
            "Нет"});
            this.MejTownCb.Location = new System.Drawing.Point(133, 215);
            this.MejTownCb.Name = "MejTownCb";
            this.MejTownCb.Size = new System.Drawing.Size(189, 24);
            this.MejTownCb.TabIndex = 65;
            // 
            // VidCb
            // 
            this.VidCb.DataSource = this.видтелефонаBindingSource;
            this.VidCb.DisplayMember = "Название";
            this.VidCb.FormattingEnabled = true;
            this.VidCb.Location = new System.Drawing.Point(133, 138);
            this.VidCb.Name = "VidCb";
            this.VidCb.Size = new System.Drawing.Size(189, 24);
            this.VidCb.TabIndex = 64;
            this.VidCb.ValueMember = "Код_вид_телефона";
            // 
            // видтелефонаBindingSource
            // 
            this.видтелефонаBindingSource.DataMember = "Вид_телефона";
            this.видтелефонаBindingSource.DataSource = this.telephoneСonnectionDBDataSet;
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Адрес";
            // 
            // AdresTb
            // 
            this.AdresTb.Location = new System.Drawing.Point(133, 295);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(189, 64);
            this.AdresTb.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Льгота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Фамилия";
            // 
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(133, 33);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(189, 22);
            this.SurnameTb.TabIndex = 52;
            this.SurnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTb_KeyPress);
            // 
            // NumberTb
            // 
            this.NumberTb.Location = new System.Drawing.Point(133, 177);
            this.NumberTb.Name = "NumberTb";
            this.NumberTb.Size = new System.Drawing.Size(189, 22);
            this.NumberTb.TabIndex = 58;
            this.NumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Межгород";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Отчество";
            // 
            // FathernameTb
            // 
            this.FathernameTb.Location = new System.Drawing.Point(133, 103);
            this.FathernameTb.Name = "FathernameTb";
            this.FathernameTb.Size = new System.Drawing.Size(189, 22);
            this.FathernameTb.TabIndex = 55;
            this.FathernameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FathernameTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Вид телефона";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(133, 67);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(189, 22);
            this.NameTb.TabIndex = 53;
            this.NameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Номер телефона";
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(85, 388);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(123, 52);
            this.EditBt.TabIndex = 24;
            this.EditBt.Text = "Редактировать";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // вид_телефонаTableAdapter
            // 
            this.вид_телефонаTableAdapter.ClearBeforeFill = true;
            // 
            // UserPhoneEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 477);
            this.Controls.Add(this.UserPhoneDGV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPhoneEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник: изменение данных об абоненте";
            this.Activated += new System.EventHandler(this.UserPhoneEditFm_Activated);
            this.Load += new System.EventHandler(this.UserPhoneEditFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoneDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видтелефонаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserPhoneDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.ComboBox LgotaCb;
        private System.Windows.Forms.ComboBox MejTownCb;
        private System.Windows.Forms.ComboBox VidCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdresTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.TextBox NumberTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FathernameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label5;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.BindingSource видтелефонаBindingSource;
        private TelephoneСonnectionDBDataSetTableAdapters.Вид_телефонаTableAdapter вид_телефонаTableAdapter;
    }
}