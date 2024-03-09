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
    public partial class VedonostZvonkovFm : Form
    {
        public VedonostZvonkovFm()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void VedonostZvonkovFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Ведомость_звонков.Код_звонка, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО, Ведомость_звонков.Дата_звонка, Ведомость_звонков.Время_начала, " +
                "Ведомость_звонков.Время_окончания, Ведомость_звонков.Межгород FROM Ведомость_звонков INNER JOIN Абоненты ON Ведомость_звонков.Код_абонента = Абоненты.Код_абонента", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Ведомость_звонков");
            VedomZvonDGV.DataSource = ds.Tables[0];

            this.VedomZvonDGV.Columns["Код_звонка"].Visible = false;

            sqlcon.Close();
        }
        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            VedomZvonDGV.AllowUserToResizeColumns = false;
            VedomZvonDGV.AllowUserToResizeRows = false;
            VedomZvonDGV.MultiSelect = false;
            // убираем левый столбец
            VedomZvonDGV.RowHeadersVisible = false;
        }

        private void VedonostZvonkovFm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneСonnectionDBDataSet.Ведомость_звонков". При необходимости она может быть перемещена или удалена.
            this.ведомость_звонковTableAdapter.Fill(this.telephoneСonnectionDBDataSet.Ведомость_звонков);


        }
    }
}
