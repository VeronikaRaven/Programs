
namespace УП3_приложение
{
    partial class EditUserPhoneFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserPhoneFm));
            this.UserPhoneDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VidPhoneTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AdresTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBt = new System.Windows.Forms.Button();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FathernameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.LgotaTb = new System.Windows.Forms.TextBox();
            this.MejGorodTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoneDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPhoneDGV
            // 
            this.UserPhoneDGV.AllowUserToAddRows = false;
            this.UserPhoneDGV.AllowUserToDeleteRows = false;
            this.UserPhoneDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserPhoneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPhoneDGV.Location = new System.Drawing.Point(363, 12);
            this.UserPhoneDGV.Name = "UserPhoneDGV";
            this.UserPhoneDGV.ReadOnly = true;
            this.UserPhoneDGV.RowHeadersWidth = 51;
            this.UserPhoneDGV.RowTemplate.Height = 24;
            this.UserPhoneDGV.Size = new System.Drawing.Size(792, 320);
            this.UserPhoneDGV.TabIndex = 30;
            this.UserPhoneDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserPhoneDGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VidPhoneTb);
            this.groupBox1.Controls.Add(this.MejGorodTb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AdresTb);
            this.groupBox1.Controls.Add(this.LgotaTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EditBt);
            this.groupBox1.Controls.Add(this.SurnameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumberTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FathernameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 446);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать абонента";
            // 
            // VidPhoneTb
            // 
            this.VidPhoneTb.Location = new System.Drawing.Point(133, 141);
            this.VidPhoneTb.Name = "VidPhoneTb";
            this.VidPhoneTb.Size = new System.Drawing.Size(189, 22);
            this.VidPhoneTb.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Адрес";
            // 
            // AdresTb
            // 
            this.AdresTb.Location = new System.Drawing.Point(133, 298);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(189, 64);
            this.AdresTb.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Льгота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия";
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
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(133, 36);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(189, 22);
            this.SurnameTb.TabIndex = 14;
            this.SurnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
            // 
            // NumberTb
            // 
            this.NumberTb.Location = new System.Drawing.Point(133, 180);
            this.NumberTb.Name = "NumberTb";
            this.NumberTb.Size = new System.Drawing.Size(189, 22);
            this.NumberTb.TabIndex = 22;
            this.NumberTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Межгород";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Отчество";
            // 
            // FathernameTb
            // 
            this.FathernameTb.Location = new System.Drawing.Point(133, 106);
            this.FathernameTb.Name = "FathernameTb";
            this.FathernameTb.Size = new System.Drawing.Size(189, 22);
            this.FathernameTb.TabIndex = 18;
            this.FathernameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FathernameTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Вид телефона";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(133, 70);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(189, 22);
            this.NameTb.TabIndex = 16;
            this.NameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Номер телефона";
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LgotaTb
            // 
            this.LgotaTb.Location = new System.Drawing.Point(133, 255);
            this.LgotaTb.Name = "LgotaTb";
            this.LgotaTb.Size = new System.Drawing.Size(189, 22);
            this.LgotaTb.TabIndex = 27;
            // 
            // MejGorodTb
            // 
            this.MejGorodTb.Location = new System.Drawing.Point(133, 218);
            this.MejGorodTb.Name = "MejGorodTb";
            this.MejGorodTb.Size = new System.Drawing.Size(189, 22);
            this.MejGorodTb.TabIndex = 30;
            // 
            // EditUserPhoneFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 470);
            this.Controls.Add(this.UserPhoneDGV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserPhoneFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абонент: окно редактирования";
            this.Activated += new System.EventHandler(this.EditUserPhoneFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoneDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserPhoneDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FathernameTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdresTb;
        private System.Windows.Forms.Label label7;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.TextBox VidPhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MejGorodTb;
        private System.Windows.Forms.TextBox LgotaTb;
    }
}