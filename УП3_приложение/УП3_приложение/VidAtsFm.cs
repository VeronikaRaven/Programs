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
    public partial class VidAtsFm : Form
    {
        public VidAtsFm()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void VidAtsFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT* " +
            "FROM Вид_АТС", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Вид_АТС");
            VidAtsDGV.DataSource = ds.Tables[0];

            //this.VidAtsDGV.Columns["Код_вид"].Visible = false;

            sqlcon.Close();
        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            VidAtsDGV.AllowUserToResizeColumns = false;
            VidAtsDGV.AllowUserToResizeRows = false;
            VidAtsDGV.MultiSelect = false;
            // убираем левый столбец
            VidAtsDGV.RowHeadersVisible = false;
        }
    }
}
