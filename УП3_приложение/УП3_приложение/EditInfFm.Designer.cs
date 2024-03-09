
namespace УП3_приложение
{
    partial class EditInfFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfFm));
            this.EditBt = new System.Windows.Forms.Button();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FathernameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(108, 268);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(123, 52);
            this.EditBt.TabIndex = 24;
            this.EditBt.Text = "Редактировать";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EditBt);
            this.groupBox1.Controls.Add(this.SurnameTb);
            this.groupBox1.Controls.Add(this.RoleCb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PasswordTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LoginTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FathernameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 332);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать пользователя";
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
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(82, 36);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(189, 22);
            this.SurnameTb.TabIndex = 14;
            this.SurnameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTb_KeyPress);
            // 
            // RoleCb
            // 
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "Администратор",
            "Сотрудник",
            "Абонент"});
            this.RoleCb.Location = new System.Drawing.Point(82, 218);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(189, 24);
            this.RoleCb.TabIndex = 24;
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
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(82, 180);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(189, 22);
            this.PasswordTb.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Роль";
            // 
            // LoginTb
            // 
            this.LoginTb.Location = new System.Drawing.Point(82, 141);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.Size = new System.Drawing.Size(189, 22);
            this.LoginTb.TabIndex = 20;
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
            this.FathernameTb.Location = new System.Drawing.Point(82, 106);
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
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Логин";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(82, 70);
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
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Пароль";
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(363, 12);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.RowTemplate.Height = 24;
            this.UserDGV.Size = new System.Drawing.Size(792, 320);
            this.UserDGV.TabIndex = 28;
            this.UserDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellClick);
            // 
            // EditInfFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 356);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditInfFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор: редактировать пользователя";
            this.Activated += new System.EventHandler(this.EditInfFm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditBt;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.ComboBox RoleCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FathernameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView UserDGV;
    }
}