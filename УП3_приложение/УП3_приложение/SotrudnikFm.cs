using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows;
using System.Data.SqlClient;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace УП3_приложение
{
    public partial class SotrudnikFm : Form
    {
        public SotrudnikFm()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void VidATSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VidAtsFm vid = new VidAtsFm();
            vid.Show();
        }

        private void VidPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VidPhonFm vf = new VidPhonFm();
            vf.Show();
        }

        private void PriceATSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceFm pf = new PriceFm();
            pf.Show();
        }
        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            ATSDGV.AllowUserToResizeColumns = false;
            ATSDGV.AllowUserToResizeRows = false;
            ATSDGV.MultiSelect = false;
            // убираем левый столбец
            ATSDGV.RowHeadersVisible = false;

            // запрет на изменение в таблице пользователем
            ContraktDGV.AllowUserToResizeColumns = false;
            ContraktDGV.AllowUserToResizeRows = false;
            ContraktDGV.MultiSelect = false;
            // убираем левый столбец
            ContraktDGV.RowHeadersVisible = false;

            // запрет на изменение в таблице пользователем
            PhoneUserDGV.AllowUserToResizeColumns = false;
            PhoneUserDGV.AllowUserToResizeRows = false;
            PhoneUserDGV.MultiSelect = false;
            // убираем левый столбец
            PhoneUserDGV.RowHeadersVisible = false;
        }
        private Excel.Application excelapp; // параметры для работы с excel
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private void DocumPrintBt_Click(object sender, EventArgs e) // документ
        {
            Excel.Range rn;
            excelapp = new Excel.Application();
            excelapp.Visible = true;
            //Получаем набор объектов Workbook (массив ссылок на созданные книги)
            excelappworkbooks = excelapp.Workbooks;

            //Открываем книгу и получаем на нее ссылку
            excelappworkbook = excelapp.Workbooks.Open("C:\\Users\\User\\Desktop\\УП3_приложение\\Исходник.xlsx",
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

            //заполнение соответв строк
            rn = (Excel.Range)excelapp.get_Range("A3").Cells;
            rn.Value = SurnameTb.Text +' '+ NameTb.Text +' '+ FathernameTb.Text;
            rn = (Excel.Range)excelapp.get_Range("B3").Cells;
            rn.Value = MesTb.Text;
            rn = (Excel.Range)excelapp.get_Range("C3").Cells;
            rn.Value = YearTb.Text;
            rn = (Excel.Range)excelapp.get_Range("D3").Cells;
            rn.Value = TownTb.Text;
            rn = (Excel.Range)excelapp.get_Range("E3").Cells;
            rn.Value = MejTb.Text;
            rn = (Excel.Range)excelapp.get_Range("F3").Cells;
            rn.Value = PriceTb.Text;
            rn = (Excel.Range)excelapp.get_Range("G3").Cells;
            rn.Value = SummaTb.Text;
            //rn = (Excel.Range)excelapp.get_Range("H3", "I3").Cells;
            //rn.Value = ObshTb.Text;
            
        }

        private void VedomZvonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VedonostZvonkovFm vf = new VedonostZvonkovFm();
            vf.Show();
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные успешно удалены!", "Информация об операции удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // АТС
        private void AddATSInforntoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATSAddInformFm ad = new ATSAddInformFm();
            ad.Show();
        }

        private void EditATSInformtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATSEditInformFm ed = new ATSEditInformFm();
            ed.Show();
        }

        private void DeleteATStoolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand($"DELETE FROM АТС WHERE Код_АТС = {ATSDGV.Rows[ATSDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon); //TableName - имя таблицы, из которой удаляете запись

            command.ExecuteNonQuery();

            sqlcon.Close();
            try  // при успешном удалении
            {
                DeleteATStoolStripMenuItem.Enabled = true;

                MessageBox.Show("Данные успешно удалены!", "Информация об операции удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch // в случае неудачного удаления
            {
                DeleteATStoolStripMenuItem.Enabled = false;

                MessageBox.Show("Неверно выбрана строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContraktDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sqlcon.Open(); // открываем соединение

            SqlCommand sqlCommand = new SqlCommand("SELECT Ведомость_абоненской_платы.Код_ведомости, Абоненты.Фамилия, Абоненты.Имя, Абоненты.Отчество,  Ведомость_абоненской_платы.Месяц, Ведомость_абоненской_платы.Год," +
            " Ведомость_абоненской_платы.Количество_минут_на_город, Ведомость_абоненской_платы.Количество_минут_на_межгород, Ведомость_абоненской_платы.Стоимость, " +
            " Ведомость_абоненской_платы.Сумма_льготы, Ведомость_абоненской_платы.Общая_стоимость " +
            $"FROM Ведомость_абоненской_платы INNER JOIN Абоненты ON Ведомость_абоненской_платы.Код_абонета = Абоненты.Код_абонента WHERE Код_ведомости = {ContraktDGV.Rows[ContraktDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            SurnameTb.Text = reader[1].ToString(); //1
            NameTb.Text = reader[2].ToString(); //2
            FathernameTb.Text = reader[3].ToString(); //3

            MesTb.Text = reader[4].ToString(); //4
            YearTb.Text = reader[5].ToString(); //5
            TownTb.Text = reader[6].ToString(); //6

            MejTb.Text = reader[7].ToString(); //4
            PriceTb.Text = reader[8].ToString(); //5
            SummaTb.Text = reader[9].ToString(); //6
            ObshTb.Text = reader[10].ToString(); //6
            sqlcon.Close();
        }

        private void SotrudnikFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT АТС.Код_АТС, АТС.Название_АТС, Вид_АТС.Название AS Вид, АТС.Адрес, АТС.Город, АТС.Количество_абонентов " +
                "FROM АТС INNER JOIN Вид_АТС ON АТС.Код_вид = Вид_АТС.Код_вид", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "АТС");
            ATSDGV.DataSource = ds.Tables[0];

            this.ATSDGV.Columns["Код_АТС"].Visible = false;

            sqlcon.Close();

            // Абонент
            sqlcon.Open(); // открываем соединение
            SqlDataAdapter data = new SqlDataAdapter("SELECT Абоненты.Код_абонента, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО, Вид_телефона.Название AS Вид_телефона , Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            "FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb1 = new SqlCommandBuilder(data);
            DataSet ds1 = new DataSet();

            // заполняем таблицу
            data.Fill(ds1, "Абоненты");
            PhoneUserDGV.DataSource = ds1.Tables[0];

            this.PhoneUserDGV.Columns["Код_абонента"].Visible = false;

            sqlcon.Close();

            // Плата
            sqlcon.Open(); // открываем соединение
            SqlDataAdapter data1 = new SqlDataAdapter("SELECT Ведомость_абоненской_платы.Код_ведомости, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО,  Ведомость_абоненской_платы.Месяц, Ведомость_абоненской_платы.Год," +
            " Ведомость_абоненской_платы.[Количество_минут_на_город], Ведомость_абоненской_платы.[Количество_минут_на_межгород], Ведомость_абоненской_платы.Стоимость, " +
            " Ведомость_абоненской_платы.Сумма_льготы, Ведомость_абоненской_платы.Общая_стоимость FROM Ведомость_абоненской_платы INNER JOIN Абоненты ON Ведомость_абоненской_платы.Код_абонета = Абоненты.Код_абонента", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb2 = new SqlCommandBuilder(data1);
            DataSet ds2 = new DataSet();

            // заполняем таблицу
            data1.Fill(ds2, "Ведомость_абоненской_платы");
            ContraktDGV.DataSource = ds2.Tables[0];

            this.ContraktDGV.Columns["Код_ведомости"].Visible = false;

            sqlcon.Close();
        }
        // Абоненты
        private void UserAddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPhoneAddFm userAdd = new UserPhoneAddFm();
            userAdd.Show();
        }

        private void UserEdittoolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPhoneEditFm editFm = new UserPhoneEditFm();
            editFm.Show();
        }

        private void DeleteUserPhonetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand($"DELETE FROM Абоненты WHERE Код_абонента = {PhoneUserDGV.Rows[PhoneUserDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon); //TableName - имя таблицы, из которой удаляете запись

            command.ExecuteNonQuery();

            sqlcon.Close();
            try  // при успешном удалении
            {
                DeleteUserPhonetoolStripMenuItem.Enabled = true;

                MessageBox.Show("Данные успешно удалены!", "Информация об операции удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch // в случае неудачного удаления
            {
                DeleteUserPhonetoolStripMenuItem.Enabled = false;

                MessageBox.Show("Неверно выбрана строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Договоры
        private void AddContrtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContraktAddFm f = new ContraktAddFm();
            f.Show();
        }

        private void EditConytrtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContraktEditFm l = new ContraktEditFm();
            l.Show();
        }

        private void DeleteContrtoolStripMenuItem_Click(object sender, EventArgs e)
        {

            sqlcon.Open();

            SqlCommand command = new SqlCommand($"DELETE FROM Ведомость_абоненской_платы WHERE Код_ведомости = {ContraktDGV.Rows[ContraktDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon); //TableName - имя таблицы, из которой удаляете запись

            command.ExecuteNonQuery();

            sqlcon.Close();
            try  // при успешном удалении
            {
                DeleteContrtoolStripMenuItem.Enabled = true;

                MessageBox.Show("Данные успешно удалены!", "Информация об операции удаления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch // в случае неудачного удаления
            {
                DeleteContrtoolStripMenuItem.Enabled = false;

                MessageBox.Show("Неверно выбрана строка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
