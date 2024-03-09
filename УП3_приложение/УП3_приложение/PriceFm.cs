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
    public partial class PriceFm : Form
    {
        public PriceFm()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void PriceFm_Activated(object sender, EventArgs e)
        {

            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Прайс_АТС.Код_прайса, АТС.Название_АТС, Прайс_АТС.Цена_на_городские_звонки, Прайс_АТС.[Цена_на_межгородские_звонки] " +
                "FROM Прайс_АТС INNER JOIN АТС ON Прайс_АТС.Код_АТС = АТС.Код_АТС", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Прайс_АТС");
            PriceDGV.DataSource = ds.Tables[0];

            sqlcon.Close();
        }
        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            PriceDGV.AllowUserToResizeColumns = false;
            PriceDGV.AllowUserToResizeRows = false;
            PriceDGV.MultiSelect = false;
            // убираем левый столбец
            PriceDGV.RowHeadersVisible = false;
        }
    }
}
