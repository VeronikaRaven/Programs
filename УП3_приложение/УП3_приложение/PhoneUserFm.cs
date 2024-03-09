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

namespace УП3_приложение
{
    public partial class PhoneUserFm : Form
    {
        public PhoneUserFm()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void EditInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserPhoneFm ef = new EditUserPhoneFm();

            ef.Show();
        }

        private void PhoneUserFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Абоненты.Код_абонента, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО, Вид_телефона.Название AS Вид_телефона , Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            "FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Абоненты");
            PhoneUserDGV.DataSource = ds.Tables[0];

            this.PhoneUserDGV.Columns["Код_абонента"].Visible = false;

            sqlcon.Close();
        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            PhoneUserDGV.AllowUserToResizeColumns = false;
            PhoneUserDGV.AllowUserToResizeRows = false;
            PhoneUserDGV.MultiSelect = false;
            // убираем левый столбец
            PhoneUserDGV.RowHeadersVisible = false;
        }
    }
}
