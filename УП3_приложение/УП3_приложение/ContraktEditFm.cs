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
using System.Text.RegularExpressions;

namespace УП3_приложение
{
    public partial class ContraktEditFm : Form
    {
        public ContraktEditFm()
        {
            InitializeComponent();

            SurnameTb.Enabled = false;
            NameTb.Enabled = false;
            FathernameTb.Enabled = false;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void EditInfATSFm_Activated(object sender, EventArgs e)
        {
            Limitation();

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

        void Limitation() //ограничения
        {

            // запрет на изменение в таблице пользователем
            ContraktDGV.AllowUserToResizeColumns = false;
            ContraktDGV.AllowUserToResizeRows = false;
            ContraktDGV.MultiSelect = false;
            // убираем левый столбец
            ContraktDGV.RowHeadersVisible = false;
        }
        private void EditBt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            //SqlCommand command = new SqlCommand("UPDATE Ведомость_абоненской_платы SET " +
            //    "Абоненты.Фамилия = @sur, Абоненты.Имя = @name, Абоненты.Отчество = @fath,  " +
            //    "Ведомость_абоненской_платы.Месяц = @mes, Ведомость_абоненской_платы.Год = @year," +
            //"Ведомость_абоненской_платы.Количество_минут_на_город = @town, Ведомость_абоненской_платы.Количество_минут_на_межгород = @mej, Ведомость_абоненской_платы.Стоимость = @price, " +
            //"Ведомость_абоненской_платы.Сумма_льготы = @summa, Ведомость_абоненской_платы.Общая_стоимость = @obsh " +
            //   $"FROM Ведомость_абоненской_платы INNER JOIN Абоненты ON Ведомость_абоненской_платы.Код_абонета = Абоненты.Код_абонента WHERE Код_ведомости = {ContraktDGV.Rows[ContraktDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);


            SqlCommand command = new SqlCommand("UPDATE Ведомость_абоненской_платы SET " +
                "Месяц = @mes, Год = @year, Количество_минут_на_город = @town, Количество_минут_на_межгород = @mej, Стоимость = @price, Сумма_льготы = @summa, Общая_стоимость = @obsh " +
               $"FROM Ведомость_абоненской_платы WHERE Код_ведомости = {ContraktDGV.Rows[ContraktDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            //command.Parameters.AddWithValue("@sur", SurnameTb.Text);
            //command.Parameters.AddWithValue("@name", NameTb.Text);
            //command.Parameters.AddWithValue("@fath", FathernameTb.Text);
            command.Parameters.AddWithValue("@mes", MesTb.Text);
            command.Parameters.AddWithValue("@year", YearTb.Text);
            command.Parameters.AddWithValue("@town", TownTb.Text);
            command.Parameters.AddWithValue("@mej", MejTb.Text);
            command.Parameters.AddWithValue("@price", PriceTb.Text);
            command.Parameters.AddWithValue("@summa", SummaTb.Text);
            command.Parameters.AddWithValue("@obsh", ObshTb.Text);

            command.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Данные изменены", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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

        private void MesTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void YearTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TownTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MejTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void SummaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void ObshTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
