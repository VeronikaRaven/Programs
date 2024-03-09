
namespace УП3_приложение
{
    partial class SotrudnikFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SotrudnikFm));
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.SpravkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VidATSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceATSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VidPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VedomZvonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneСonnectionDBDataSet = new УП3_приложение.TelephoneСonnectionDBDataSet();
            this.ContraktTp = new System.Windows.Forms.TabPage();
            this.ObshTb = new System.Windows.Forms.TextBox();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.AddContrtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditConytrtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContrtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SummaTb = new System.Windows.Forms.TextBox();
            this.MejTb = new System.Windows.Forms.TextBox();
            this.TownTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.MesTb = new System.Windows.Forms.TextBox();
            this.CommentTb = new System.Windows.Forms.TextBox();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.YearTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FathernameTb = new System.Windows.Forms.TextBox();
            this.DocumPrintBt = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.ContraktDGV = new System.Windows.Forms.DataGridView();
            this.UserPhoneTp = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserPhoneAddtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserPhoneEdittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUserPhonetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneUserDGV = new System.Windows.Forms.DataGridView();
            this.ATSTp = new System.Windows.Forms.TabPage();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.AddATSInforntoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditATSInformtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteATStoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ATSDGV = new System.Windows.Forms.DataGridView();
            this.AllVkladkiTp = new System.Windows.Forms.TabControl();
            this.DaraTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumContrTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).BeginInit();
            this.ContraktTp.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContraktDGV)).BeginInit();
            this.UserPhoneTp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneUserDGV)).BeginInit();
            this.ATSTp.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATSDGV)).BeginInit();
            this.AllVkladkiTp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpravkaToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(1016, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(123, 386);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // SpravkaToolStripMenuItem
            // 
            this.SpravkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VidATSToolStripMenuItem,
            this.PriceATSToolStripMenuItem,
            this.VidPhoneToolStripMenuItem,
            this.VedomZvonToolStripMenuItem});
            this.SpravkaToolStripMenuItem.Name = "SpravkaToolStripMenuItem";
            this.SpravkaToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.SpravkaToolStripMenuItem.Text = "Справочники";
            // 
            // VidATSToolStripMenuItem
            // 
            this.VidATSToolStripMenuItem.Name = "VidATSToolStripMenuItem";
            this.VidATSToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.VidATSToolStripMenuItem.Text = "Вид АТС";
            this.VidATSToolStripMenuItem.Click += new System.EventHandler(this.VidATSToolStripMenuItem_Click);
            // 
            // PriceATSToolStripMenuItem
            // 
            this.PriceATSToolStripMenuItem.Name = "PriceATSToolStripMenuItem";
            this.PriceATSToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.PriceATSToolStripMenuItem.Text = "Прайс АТС";
            this.PriceATSToolStripMenuItem.Click += new System.EventHandler(this.PriceATSToolStripMenuItem_Click);
            // 
            // VidPhoneToolStripMenuItem
            // 
            this.VidPhoneToolStripMenuItem.Name = "VidPhoneToolStripMenuItem";
            this.VidPhoneToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.VidPhoneToolStripMenuItem.Text = "Вид телефона";
            this.VidPhoneToolStripMenuItem.Click += new System.EventHandler(this.VidPhoneToolStripMenuItem_Click);
            // 
            // VedomZvonToolStripMenuItem
            // 
            this.VedomZvonToolStripMenuItem.Name = "VedomZvonToolStripMenuItem";
            this.VedomZvonToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.VedomZvonToolStripMenuItem.Text = "Ведомость звоноков";
            this.VedomZvonToolStripMenuItem.Click += new System.EventHandler(this.VedomZvonToolStripMenuItem_Click);
            // 
            // telephoneСonnectionDBDataSet
            // 
            this.telephoneСonnectionDBDataSet.DataSetName = "TelephoneСonnectionDBDataSet";
            this.telephoneСonnectionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContraktTp
            // 
            this.ContraktTp.Controls.Add(this.ObshTb);
            this.ContraktTp.Controls.Add(this.menuStrip5);
            this.ContraktTp.Controls.Add(this.SummaTb);
            this.ContraktTp.Controls.Add(this.MejTb);
            this.ContraktTp.Controls.Add(this.TownTb);
            this.ContraktTp.Controls.Add(this.PriceTb);
            this.ContraktTp.Controls.Add(this.MesTb);
            this.ContraktTp.Controls.Add(this.SurnameTb);
            this.ContraktTp.Controls.Add(this.YearTb);
            this.ContraktTp.Controls.Add(this.FathernameTb);
            this.ContraktTp.Controls.Add(this.DocumPrintBt);
            this.ContraktTp.Controls.Add(this.NameTb);
            this.ContraktTp.Controls.Add(this.ContraktDGV);
            this.ContraktTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContraktTp.Location = new System.Drawing.Point(4, 25);
            this.ContraktTp.Name = "ContraktTp";
            this.ContraktTp.Padding = new System.Windows.Forms.Padding(3);
            this.ContraktTp.Size = new System.Drawing.Size(1005, 351);
            this.ContraktTp.TabIndex = 2;
            this.ContraktTp.Text = "Договора";
            this.ContraktTp.UseVisualStyleBackColor = true;
            // 
            // ObshTb
            // 
            this.ObshTb.Location = new System.Drawing.Point(204, 460);
            this.ObshTb.Name = "ObshTb";
            this.ObshTb.Size = new System.Drawing.Size(189, 24);
            this.ObshTb.TabIndex = 78;
            // 
            // menuStrip5
            // 
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContrtoolStripMenuItem,
            this.EditConytrtoolStripMenuItem,
            this.DeleteContrtoolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(3, 3);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(999, 26);
            this.menuStrip5.TabIndex = 14;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // AddContrtoolStripMenuItem
            // 
            this.AddContrtoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddContrtoolStripMenuItem.Name = "AddContrtoolStripMenuItem";
            this.AddContrtoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.AddContrtoolStripMenuItem.Text = "Добавить";
            this.AddContrtoolStripMenuItem.Click += new System.EventHandler(this.AddContrtoolStripMenuItem_Click);
            // 
            // EditConytrtoolStripMenuItem
            // 
            this.EditConytrtoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EditConytrtoolStripMenuItem.Name = "EditConytrtoolStripMenuItem";
            this.EditConytrtoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.EditConytrtoolStripMenuItem.Text = "Изменить";
            this.EditConytrtoolStripMenuItem.Click += new System.EventHandler(this.EditConytrtoolStripMenuItem_Click);
            // 
            // DeleteContrtoolStripMenuItem
            // 
            this.DeleteContrtoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteContrtoolStripMenuItem.Name = "DeleteContrtoolStripMenuItem";
            this.DeleteContrtoolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.DeleteContrtoolStripMenuItem.Text = "Удалить";
            this.DeleteContrtoolStripMenuItem.Click += new System.EventHandler(this.DeleteContrtoolStripMenuItem_Click);
            // 
            // SummaTb
            // 
            this.SummaTb.Location = new System.Drawing.Point(9, 460);
            this.SummaTb.Name = "SummaTb";
            this.SummaTb.Size = new System.Drawing.Size(189, 24);
            this.SummaTb.TabIndex = 77;
            // 
            // MejTb
            // 
            this.MejTb.Location = new System.Drawing.Point(399, 432);
            this.MejTb.Name = "MejTb";
            this.MejTb.Size = new System.Drawing.Size(189, 24);
            this.MejTb.TabIndex = 76;
            // 
            // TownTb
            // 
            this.TownTb.Location = new System.Drawing.Point(204, 432);
            this.TownTb.Name = "TownTb";
            this.TownTb.Size = new System.Drawing.Size(189, 24);
            this.TownTb.TabIndex = 75;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(594, 432);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(189, 24);
            this.PriceTb.TabIndex = 72;
            // 
            // MesTb
            // 
            this.MesTb.Location = new System.Drawing.Point(594, 404);
            this.MesTb.Name = "MesTb";
            this.MesTb.Size = new System.Drawing.Size(189, 24);
            this.MesTb.TabIndex = 71;
            // 
            // CommentTb
            // 
            this.CommentTb.Location = new System.Drawing.Point(129, 454);
            this.CommentTb.Name = "CommentTb";
            this.CommentTb.Size = new System.Drawing.Size(376, 22);
            this.CommentTb.TabIndex = 9;
            // 
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(9, 404);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(189, 24);
            this.SurnameTb.TabIndex = 60;
            // 
            // YearTb
            // 
            this.YearTb.Location = new System.Drawing.Point(12, 432);
            this.YearTb.Name = "YearTb";
            this.YearTb.Size = new System.Drawing.Size(189, 24);
            this.YearTb.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Комментарий:";
            // 
            // FathernameTb
            // 
            this.FathernameTb.Location = new System.Drawing.Point(399, 404);
            this.FathernameTb.Name = "FathernameTb";
            this.FathernameTb.Size = new System.Drawing.Size(189, 24);
            this.FathernameTb.TabIndex = 64;
            // 
            // DocumPrintBt
            // 
            this.DocumPrintBt.Location = new System.Drawing.Point(883, 288);
            this.DocumPrintBt.Name = "DocumPrintBt";
            this.DocumPrintBt.Size = new System.Drawing.Size(113, 42);
            this.DocumPrintBt.TabIndex = 5;
            this.DocumPrintBt.Text = "Печать";
            this.DocumPrintBt.UseVisualStyleBackColor = true;
            this.DocumPrintBt.Click += new System.EventHandler(this.DocumPrintBt_Click);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(204, 404);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(189, 24);
            this.NameTb.TabIndex = 62;
            // 
            // ContraktDGV
            // 
            this.ContraktDGV.AllowUserToAddRows = false;
            this.ContraktDGV.AllowUserToDeleteRows = false;
            this.ContraktDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContraktDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContraktDGV.Location = new System.Drawing.Point(7, 45);
            this.ContraktDGV.Name = "ContraktDGV";
            this.ContraktDGV.ReadOnly = true;
            this.ContraktDGV.RowHeadersWidth = 51;
            this.ContraktDGV.RowTemplate.Height = 24;
            this.ContraktDGV.Size = new System.Drawing.Size(989, 222);
            this.ContraktDGV.TabIndex = 4;
            this.ContraktDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContraktDGV_CellClick);
            // 
            // UserPhoneTp
            // 
            this.UserPhoneTp.Controls.Add(this.menuStrip1);
            this.UserPhoneTp.Controls.Add(this.PhoneUserDGV);
            this.UserPhoneTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPhoneTp.Location = new System.Drawing.Point(4, 25);
            this.UserPhoneTp.Name = "UserPhoneTp";
            this.UserPhoneTp.Padding = new System.Windows.Forms.Padding(3);
            this.UserPhoneTp.Size = new System.Drawing.Size(1005, 351);
            this.UserPhoneTp.TabIndex = 1;
            this.UserPhoneTp.Text = "Абоненты";
            this.UserPhoneTp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserPhoneAddtoolStripMenuItem,
            this.UserPhoneEdittoolStripMenuItem,
            this.DeleteUserPhonetoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserPhoneAddtoolStripMenuItem
            // 
            this.UserPhoneAddtoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPhoneAddtoolStripMenuItem.Name = "UserPhoneAddtoolStripMenuItem";
            this.UserPhoneAddtoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.UserPhoneAddtoolStripMenuItem.Text = "Добавить";
            this.UserPhoneAddtoolStripMenuItem.Click += new System.EventHandler(this.UserAddtoolStripMenuItem_Click);
            // 
            // UserPhoneEdittoolStripMenuItem
            // 
            this.UserPhoneEdittoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UserPhoneEdittoolStripMenuItem.Name = "UserPhoneEdittoolStripMenuItem";
            this.UserPhoneEdittoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.UserPhoneEdittoolStripMenuItem.Text = "Изменить";
            this.UserPhoneEdittoolStripMenuItem.Click += new System.EventHandler(this.UserEdittoolStripMenuItem_Click);
            // 
            // DeleteUserPhonetoolStripMenuItem
            // 
            this.DeleteUserPhonetoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteUserPhonetoolStripMenuItem.Name = "DeleteUserPhonetoolStripMenuItem";
            this.DeleteUserPhonetoolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.DeleteUserPhonetoolStripMenuItem.Text = "Удалить";
            this.DeleteUserPhonetoolStripMenuItem.Click += new System.EventHandler(this.DeleteUserPhonetoolStripMenuItem_Click);
            // 
            // PhoneUserDGV
            // 
            this.PhoneUserDGV.AllowUserToAddRows = false;
            this.PhoneUserDGV.AllowUserToDeleteRows = false;
            this.PhoneUserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PhoneUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneUserDGV.Location = new System.Drawing.Point(7, 32);
            this.PhoneUserDGV.Name = "PhoneUserDGV";
            this.PhoneUserDGV.ReadOnly = true;
            this.PhoneUserDGV.RowHeadersWidth = 51;
            this.PhoneUserDGV.RowTemplate.Height = 24;
            this.PhoneUserDGV.Size = new System.Drawing.Size(990, 310);
            this.PhoneUserDGV.TabIndex = 3;
            // 
            // ATSTp
            // 
            this.ATSTp.Controls.Add(this.menuStrip4);
            this.ATSTp.Controls.Add(this.ATSDGV);
            this.ATSTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATSTp.Location = new System.Drawing.Point(4, 25);
            this.ATSTp.Name = "ATSTp";
            this.ATSTp.Padding = new System.Windows.Forms.Padding(3);
            this.ATSTp.Size = new System.Drawing.Size(1005, 351);
            this.ATSTp.TabIndex = 0;
            this.ATSTp.Text = "АТС";
            this.ATSTp.UseVisualStyleBackColor = true;
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddATSInforntoolStripMenuItem,
            this.EditATSInformtoolStripMenuItem,
            this.DeleteATStoolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(3, 3);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(999, 26);
            this.menuStrip4.TabIndex = 8;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // AddATSInforntoolStripMenuItem
            // 
            this.AddATSInforntoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATSInforntoolStripMenuItem.Name = "AddATSInforntoolStripMenuItem";
            this.AddATSInforntoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.AddATSInforntoolStripMenuItem.Text = "Добавить";
            this.AddATSInforntoolStripMenuItem.Click += new System.EventHandler(this.AddATSInforntoolStripMenuItem_Click);
            // 
            // EditATSInformtoolStripMenuItem
            // 
            this.EditATSInformtoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EditATSInformtoolStripMenuItem.Name = "EditATSInformtoolStripMenuItem";
            this.EditATSInformtoolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.EditATSInformtoolStripMenuItem.Text = "Изменить";
            this.EditATSInformtoolStripMenuItem.Click += new System.EventHandler(this.EditATSInformtoolStripMenuItem_Click);
            // 
            // DeleteATStoolStripMenuItem
            // 
            this.DeleteATStoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteATStoolStripMenuItem.Name = "DeleteATStoolStripMenuItem";
            this.DeleteATStoolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.DeleteATStoolStripMenuItem.Text = "Удалить";
            this.DeleteATStoolStripMenuItem.Click += new System.EventHandler(this.DeleteATStoolStripMenuItem_Click);
            // 
            // ATSDGV
            // 
            this.ATSDGV.AllowUserToAddRows = false;
            this.ATSDGV.AllowUserToDeleteRows = false;
            this.ATSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ATSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ATSDGV.Location = new System.Drawing.Point(7, 46);
            this.ATSDGV.Name = "ATSDGV";
            this.ATSDGV.ReadOnly = true;
            this.ATSDGV.RowHeadersWidth = 51;
            this.ATSDGV.RowTemplate.Height = 24;
            this.ATSDGV.Size = new System.Drawing.Size(990, 278);
            this.ATSDGV.TabIndex = 0;
            // 
            // AllVkladkiTp
            // 
            this.AllVkladkiTp.Controls.Add(this.ATSTp);
            this.AllVkladkiTp.Controls.Add(this.UserPhoneTp);
            this.AllVkladkiTp.Controls.Add(this.ContraktTp);
            this.AllVkladkiTp.Location = new System.Drawing.Point(1, 0);
            this.AllVkladkiTp.Name = "AllVkladkiTp";
            this.AllVkladkiTp.SelectedIndex = 0;
            this.AllVkladkiTp.Size = new System.Drawing.Size(1013, 380);
            this.AllVkladkiTp.TabIndex = 3;
            // 
            // DaraTb
            // 
            this.DaraTb.Location = new System.Drawing.Point(241, 484);
            this.DaraTb.Name = "DaraTb";
            this.DaraTb.Size = new System.Drawing.Size(99, 22);
            this.DaraTb.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "от";
            // 
            // NumContrTb
            // 
            this.NumContrTb.Location = new System.Drawing.Point(106, 484);
            this.NumContrTb.Name = "NumContrTb";
            this.NumContrTb.Size = new System.Drawing.Size(99, 22);
            this.NumContrTb.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Договор №";
            // 
            // SotrudnikFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 386);
            this.Controls.Add(this.DaraTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumContrTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllVkladkiTp);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.CommentTb);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SotrudnikFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник: основное окно";
            this.Activated += new System.EventHandler(this.SotrudnikFm_Activated);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneСonnectionDBDataSet)).EndInit();
            this.ContraktTp.ResumeLayout(false);
            this.ContraktTp.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContraktDGV)).EndInit();
            this.UserPhoneTp.ResumeLayout(false);
            this.UserPhoneTp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneUserDGV)).EndInit();
            this.ATSTp.ResumeLayout(false);
            this.ATSTp.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATSDGV)).EndInit();
            this.AllVkladkiTp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem SpravkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VidATSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceATSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VidPhoneToolStripMenuItem;
        private TelephoneСonnectionDBDataSet telephoneСonnectionDBDataSet;
        private System.Windows.Forms.ToolStripMenuItem VedomZvonToolStripMenuItem;
        private System.Windows.Forms.TabPage ContraktTp;
        private System.Windows.Forms.Button DocumPrintBt;
        private System.Windows.Forms.DataGridView ContraktDGV;
        private System.Windows.Forms.TabPage UserPhoneTp;
        private System.Windows.Forms.DataGridView PhoneUserDGV;
        private System.Windows.Forms.TabPage ATSTp;
        private System.Windows.Forms.DataGridView ATSDGV;
        private System.Windows.Forms.TabControl AllVkladkiTp;
        private System.Windows.Forms.TextBox CommentTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem AddContrtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditConytrtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteContrtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserPhoneAddtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserPhoneEdittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserPhonetoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem AddATSInforntoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditATSInformtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteATStoolStripMenuItem;
        private System.Windows.Forms.TextBox ObshTb;
        private System.Windows.Forms.TextBox SummaTb;
        private System.Windows.Forms.TextBox MejTb;
        private System.Windows.Forms.TextBox TownTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox MesTb;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.TextBox YearTb;
        private System.Windows.Forms.TextBox FathernameTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox DaraTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumContrTb;
        private System.Windows.Forms.Label label1;
    }
}