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
    public partial class EditUserPhoneFm : Form
    {
        public EditUserPhoneFm()
        {
            InitializeComponent();
            LgotaTb.Enabled = false;
            VidPhoneTb.Enabled = false;
            MejGorodTb.Enabled = false;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\УП3_приложение\DB\TelephoneСonnectionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void EditBt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            SqlCommand command = new SqlCommand("UPDATE Абоненты SET Фамилия = @surname, Имя = @name, Отчество = @fathername, Номер_телефона = @number, " +
                "Адрес = @adress " +
            $"FROM Абоненты WHERE Код_абонента = {UserPhoneDGV.Rows[UserPhoneDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            command.Parameters.AddWithValue("@surname", SurnameTb.Text);
            command.Parameters.AddWithValue("@name", NameTb.Text);
            command.Parameters.AddWithValue("@fathername", FathernameTb.Text);
            command.Parameters.AddWithValue("@number", NumberTb.Text);
            command.Parameters.AddWithValue("@adress", AdresTb.Text);

            command.ExecuteNonQuery();

            sqlcon.Close();
            MessageBox.Show("Данные изменены", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void EditUserPhoneFm_Activated(object sender, EventArgs e)
        {
            Limitation();

            sqlcon.Open(); // открываем соединение
            SqlDataAdapter dat = new SqlDataAdapter("SELECT Абоненты.Код_абонента, Абоненты.Фамилия + ' ' + Абоненты.Имя + ' ' + Абоненты.Отчество AS ФИО, Вид_телефона.Название AS Вид_телефона , Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            "FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона", sqlcon); // отображаем только нужные данные

            SqlCommandBuilder cb = new SqlCommandBuilder(dat);
            DataSet ds = new DataSet();

            // заполняем таблицу
            dat.Fill(ds, "Абоненты");
            UserPhoneDGV.DataSource = ds.Tables[0];

            this.UserPhoneDGV.Columns["Код_абонента"].Visible = false;

            sqlcon.Close();
        }

        void Limitation() //ограничения
        {
            // запрет на изменение в таблице пользователем
            UserPhoneDGV.AllowUserToResizeColumns = false;
            UserPhoneDGV.AllowUserToResizeRows = false;
            UserPhoneDGV.MultiSelect = false;
            // убираем левый столбец
            UserPhoneDGV.RowHeadersVisible = false;
        }

        private void UserPhoneDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlcon.Open(); // открываем соединение

            SqlCommand sqlCommand = new SqlCommand("SELECT Абоненты.Код_абонента, Абоненты.Фамилия, Абоненты.Имя, Абоненты.Отчество, Вид_телефона.Название AS Вид_телефона , Абоненты.Номер_телефона, Абоненты.Межгород, Абоненты.Льгота, Абоненты.Адрес " +
            $"FROM Абоненты INNER JOIN Вид_телефона ON Абоненты.Код_вид_телефона = Вид_телефона.Код_вид_телефона WHERE Код_абонента = {UserPhoneDGV.Rows[UserPhoneDGV.CurrentCell.RowIndex].Cells[0].Value}", sqlcon);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            SurnameTb.Text = reader[1].ToString(); //1
            NameTb.Text = reader[2].ToString(); //2
            FathernameTb.Text = reader[3].ToString(); //3

            VidPhoneTb.Text = reader[4].ToString(); //4
            NumberTb.Text = reader[5].ToString(); //5

            MejGorodTb.Text = reader[6].ToString(); //6
            LgotaTb.Text = reader[7].ToString(); //4
            AdresTb.Text = reader[8].ToString(); //5

            sqlcon.Close();
        }

        private void SurnameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void FathernameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NumberTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
